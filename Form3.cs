using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Student_Management_System_
{
    public partial class Form3 : Form
    {
        private string studentFilePath = @"C:\Users\trill\OneDrive\Documents\ACADEMIC\2024\PRG272\Project\students.txt";
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

            // Read all student records
            string[] lines = File.ReadAllLines(studentFilePath);
            bool found = false;

            // Update the student record if the ID matches
            for (int i = 0; i < lines.Length; i++)
            {
                var data = lines[i].Split(',');
                if (data[0] == studentID) // Student ID match
                {
                    lines[i] = $"{studentID},{name},{age},{course}"; // Update with new values
                    found = true;
                    break;
                }
            }

            // Save the updated records back to the file
            if (found)
            {
                File.WriteAllLines(studentFilePath, lines);
                MessageBox.Show("Student information updated successfully.");
                this.DialogResult = DialogResult.OK; // Close form with success status
                this.Close();
            }
            else
            {
                MessageBox.Show("Student ID not found.");
            }
        }
    }
}