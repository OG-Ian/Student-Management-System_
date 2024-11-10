using System;
using System.Windows.Forms;

namespace Student_Management_System_
{
    public partial class Form3 : Form
    {
        private string studentID;

        public Form3(string id, string name, int age, string course)
        {
            InitializeComponent();

            // Store the student ID for reference
            studentID = id;

            // Populate the form fields with existing data
            txtStudentID.Text = id;
            txtStudentID.ReadOnly = true; // Prevent editing of Student ID
            txtName.Text = name;
            txtAge.Text = age.ToString();
            txtCourse.Text = course;
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string ageText = txtAge.Text;
            string course = txtCourse.Text;

            // Validate the input fields
            if (string.IsNullOrWhiteSpace(name) ||
                !int.TryParse(ageText, out int age) ||
                string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please enter valid details for updating.");
                return;
            }

            try
            {
                // Use the DataHandler to update the student record
                DataHandler.UpdateStudent(studentID, name, age, course);
                MessageBox.Show("Student information updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the student: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 viewForm = new Form2();
            viewForm.Show();
        }
    }
}
