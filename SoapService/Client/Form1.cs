using System;
using System.Data;
using System.Windows.Forms;
using Models;

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
            var a = (Models.Student)ModelBindingSource.DataSource;
            //var student = (Student)ModelBindingSource.DataSource;
        }
    }
}
