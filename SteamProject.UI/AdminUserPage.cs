using ClassLibrary1.ORM.Entity.Concerte;
using SteamProject.Repository.Service.Concerte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamProject.UI
{
    public partial class AdminUserPage : Form
    {
        public AdminUserPage()
        {
            InitializeComponent();
        }
        AppUserReposityory service = new AppUserReposityory();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                service.Add(txtAddFirstName.Text, txtAddLastName.Text, txtAddEmail.Text, mskAddedPhone.Text, txtAddAdress.Text, txtAddCountry.Text, (Role)Enum.Parse(typeof(Role), cmbAddRole.Text), DateTime.Parse(mskAddBirthDate.Text));
                dataGridView1.DataSource = service.TakeList();
                service.TextboxCmbBoxEraser(groupBox1);
            }
            catch (Exception)
            {

                MessageBox.Show("Please check values you entered!");
            }
            
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                service.Update(int.Parse(txtUpdateID.Text), txtUpdateFirstName.Text, txtUpdateLastName.Text, txtUpdateEmail.Text, mskUpdatePhone.Text, txtUpdateAdress.Text, txtUpdateCountry.Text, (Role)Enum.Parse(typeof(Role), cmbUpdateRole.Text), DateTime.Parse(mskUpdateBirthDate.Text));
                dataGridView1.DataSource = service.TakeList();
                service.TextboxCmbBoxEraser(groupBox3);
            }
            catch (Exception)
            {

                MessageBox.Show("Please check values you entered!");
            }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                service.Delete(int.Parse(txtDelete.Text));
                service.GetAll();
                service.TextboxCmbBoxEraser(groupBox4);
            }
            catch (Exception)
            {

                MessageBox.Show("Please check values you entered!");
            }
        }

     

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = service.FindByName(txtFindFirstName.Text, txtFindLastName.Text);
            }
            catch (Exception)
            {

                
            } 
            
        }

        

        private void btnGetByDate_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = service.GetByDateTime(DateTime.Parse(mskdStartDate.Text), DateTime.Parse(mskdEndDate.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Please check values you entered!");
            } 
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetAll();
        }

        private void AdminUserPage_Load(object sender, EventArgs e)
        {
            service.GetEnum(cmbAddRole, cmbUpdateRole);
            dataGridView1.DataSource = service.TakeList();
        }
    }
}
