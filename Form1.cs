using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System_
{
    public partial class Form1 : Form
    {

        private string studentFilePath = @"C:\Users\kgoth\source\repos\Student-Management-System_\Student.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string id = txtStudentID.Text;
            string name = txtName.Text;
            int age;
            string course = txtCourse.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) ||
                !int.TryParse(txtAge.Text, out age) || string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please enter valid details.");
                return;
            }

            string studentRecord = $"{id},{name},{age},{course}";

            using (StreamWriter sw = new StreamWriter(studentFilePath, true))
            {
                sw.WriteLine(studentRecord);
            }

            MessageBox.Show("Student added successfully!");
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtCourse.Clear();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            Form2 viewForm = new Form2();
            viewForm.Show();
            this.Hide(); // Hide the current form
        }
    }
}
