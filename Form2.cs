using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Student_Management_System_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadStudents();
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("StudentID", "Student ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("Course", "Course");

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
        }

        private void LoadStudents()
        {
            dataGridView1.Rows.Clear();
            var students = DataHandler.LoadStudents();
            foreach (var student in students)
            {
                dataGridView1.Rows.Add(student[0], student[1], student[2], student[3]);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string studentID = selectedRow.Cells["StudentID"].Value.ToString();
            string name = selectedRow.Cells["Name"].Value.ToString();
            int age = int.Parse(selectedRow.Cells["Age"].Value.ToString());
            string course = selectedRow.Cells["Course"].Value.ToString();

            using (Form3 updateForm = new Form3(studentID, name, age, course))
            {
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadStudents();
                }
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string searchID = txtStudentID.Text;
            dataGridView1.Rows.Clear();
            var students = DataHandler.LoadStudents();
            var student = students.FirstOrDefault(s => s[0] == searchID);

            if (student != null)
            {
                dataGridView1.Rows.Add(student[0], student[1], student[2], student[3]);
            }
            else
            {
                MessageBox.Show("Student ID not found.");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            string id = txtStudentID.Text;
            DataHandler.DeleteStudent(id);
            MessageBox.Show("Student record deleted.");
            LoadStudents();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
                var students = DataHandler.LoadStudents();
                int totalStudents = students.Count;
                double averageAge = totalStudents > 0 ? students.Average(s => int.Parse(s[2])) : 0;

                lblTotalStudents.Text = $"Total Students: {totalStudents}";
                lblAverageAge.Text = $"Average Age: {averageAge:F2}";

                string summaryFilePath = @"C:\Users\trill\OneDrive\Documents\ACADEMIC\2024\PRG272\PROJECT PRG272 (1)\Student-Management-System_\Summary.txt";

                // Write the summary information to Summary.txt
                using (StreamWriter sw = new StreamWriter(summaryFilePath))
                {
                    sw.WriteLine($"Total Students: {totalStudents}");
                    sw.WriteLine($"Average Age: {averageAge:F2}");
                }

                MessageBox.Show("Summary report generated and saved to Summary.txt.");

        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

    }
}
