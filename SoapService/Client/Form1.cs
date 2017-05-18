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
        }
    }
}
