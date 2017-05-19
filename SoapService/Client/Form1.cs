using System;
using System.Windows.Forms;
using Client.ServiceReference;
using SoapService;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ModelBindingSource.DataSource = new Student();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ModelBindingSource.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var student = (Student)ModelBindingSource.DataSource;
            var client = new ServiceClient();
            client.AddUpdateStudent(student);

            GridBindingSource.DataSource = client.GetStudents();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var client = new ServiceClient();
            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                GridBindingSource.DataSource = client.GetStudents();
                return;
            }
            GridBindingSource.DataSource = client.GetStudent(SearchTextBox.Text);
        }
    }
}
