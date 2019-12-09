using SteamProject.Repository.Service.Concerte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace SteamProject.UI
{
    public partial class AdminCategoryPage : Form
    {
        public AdminCategoryPage()
        {
            InitializeComponent();
        }
        CategoryRepository service = new CategoryRepository();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                service.Add(txtAddName.Text, txtAddDescription.Text);
                dataGridView1.DataSource = service.TakeList();
                service.TextBoxCmbBoxEraser(groupBox1);
                MessageBox.Show("Category has been added");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check values you entered!");
                
            }
       
        
        }

        private void AdminCategoryPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.TakeList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                service.Update(int.Parse(txtUpdateID.Text), txtUpdateName.Text, txtUpdateDesciption.Text);
                dataGridView1.DataSource = service.TakeList();
                service.TextBoxCmbBoxEraser(groupBox3);
                MessageBox.Show("Category has been updated");
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
                service.TextBoxCmbBoxEraser(groupBox4);
                MessageBox.Show("Category has been deleted");
            }
            catch (Exception)
            {

                MessageBox.Show("Please check values you entered!");
            }
            
           
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.FindByName(txtFindCategory.Text);
            service.TextBoxCmbBoxEraser(groupBox5);
            
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetAll();
        }

        private void btnGetByDate_Click(object sender, EventArgs e)
        {
            try
            {
              dataGridView1.DataSource = service.GetByDate(DateTime.Parse(mskdStartDate.Text),DateTime.Parse(mskdEndDate.Text));
               
                service.TextBoxCmbBoxEraser(groupBox7);
            }
            catch (Exception)
            {

                MessageBox.Show("Please check values you entered!");
            }
        }
    }
}
