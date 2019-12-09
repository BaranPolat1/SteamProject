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
    public partial class AdminGamePage : Form
    {
        public AdminGamePage()
        {
            InitializeComponent();
        }
        GameRepository service = new GameRepository();
        private void AdminGamePage_Load(object sender, EventArgs e)
        {
            cmbAddCategory.DataSource = service.TakeCategoryList();
            cmbAddCategory.DisplayMember = "Name";
            cmbAddCategory.ValueMember = "Id";
            cmbAddCategory.SelectedIndex = -1;

            cmbAddAuthor.DataSource = service.TakeAppUserList();
            cmbAddAuthor.DisplayMember = "Firstname";
            cmbAddAuthor.ValueMember = "Id";
            cmbAddAuthor.SelectedIndex = -1;

            cmbUpdateCategory.DataSource = service.TakeCategoryList();
            cmbUpdateCategory.DisplayMember = "Name";
            cmbUpdateCategory.ValueMember = "Id";
            cmbUpdateCategory.SelectedIndex = -1;

            cmbUpdateAuthor.DataSource = service.TakeAppUserList();
            cmbUpdateAuthor.DisplayMember = "Firstname";
            cmbUpdateAuthor.ValueMember = "Id";
            cmbUpdateAuthor.SelectedIndex = -1;

            dataGridView1.DataSource = service.TakeList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                service.Add(txtAddGame.Text, txtAddDescreption.Text, decimal.Parse(txtaddPrice.Text), txtaddSystem.Text, DateTime.Parse(mskaddRelease.Text), (int)(cmbAddCategory.SelectedValue), (int)(cmbAddAuthor.SelectedValue), fileName);
                dataGridView1.DataSource = service.TakeList();
                service.TextboxCmbBoxEraser(groupBox1);
            }
            catch (Exception)
            {

                MessageBox.Show("Please check values you entered!");
            }
            
            
        }
        string fileName;
        private void btnAddPictureUrl_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAdd.Filter = "JPG | *.jpg";

                if (ofdAdd.ShowDialog() == DialogResult.OK)
                {
                    txtAddPictureUrl.Text = ofdAdd.FileName;
                    fileName = ofdAdd.FileName;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please check values you entered!");
            }
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                service.Update(int.Parse(txtUpdateID.Text), txtUpdateName.Text, txtUpdateDesc.Text, decimal.Parse(txtUpdatePrice.Text), txtUpdateSystem.Text, DateTime.Parse(mskUpdateRelease.Text), (int)(cmbUpdateCategory.SelectedValue), (int)(cmbUpdateAuthor.SelectedValue), fileName);
                dataGridView1.DataSource = service.TakeList();
                service.TextboxCmbBoxEraser(groupBox3);
            }
            catch (Exception)
            {

                MessageBox.Show("Please check values you entered!");
            }
            
            
        }

        private void btnUpdatePic_Click(object sender, EventArgs e)
        {
            try
            {
                ofdUpdate.Filter = "JPG | *.jpg";
                if (ofdUpdate.ShowDialog() == DialogResult.OK)
                {
                    txtUpdatePic.Text = ofdUpdate.FileName;
                    fileName = ofdUpdate.FileName;
                }
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
                dataGridView1.DataSource = service.GetAll();
                service.TextboxCmbBoxEraser(groupBox4);
            }
            catch (Exception)
            {

                MessageBox.Show("Please check values you entered!");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.FindByName(txtFind.Text);
            service.TextboxCmbBoxEraser(groupBox5);
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetAll();
        }

        private void btnGetByDate_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = service.GetByDateTime(DateTime.Parse(mskdStartDate.Text), DateTime.Parse(mskdEndDate.Text)).ToList();
                service.TextboxCmbBoxEraser(groupBox7);
            }
            catch (Exception)
            {

                MessageBox.Show("Please check values you entered!");
            }
           
        }
    }
}
