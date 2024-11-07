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
using System.Xml.Linq;

namespace Student_Management_System_
{

    public partial class Form2 : Form
    {
        private string studentFilePath = @"C:\Users\trill\OneDrive\Documents\ACADEMIC\2024\PRG272\PRG272_PROJECT\students.txt";

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

            if (File.Exists(studentFilePath))
            {
                var lines = File.ReadAllLines(studentFilePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    dataGridView1.Rows.Add(data[0], data[1], data[2], data[3]);
                }
            }
            else
            {
                MessageBox.Show("No student records found.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            // Get selected student data from the DataGridView
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string studentID = selectedRow.Cells["StudentID"].Value.ToString();
            string name = selectedRow.Cells["Name"].Value.ToString();
            int age = int.Parse(selectedRow.Cells["Age"].Value.ToString());
            string course = selectedRow.Cells["Course"].Value.ToString();

            // Open Form3 for updating
            using (Form3 updateForm = new Form3(studentID, name, age, course))
            {
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh DataGridView if the update was successful
                    LoadStudents();
                }
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string searchID = txtStudentID.Text;
            dataGridView1.Rows.Clear();

            if (File.Exists(studentFilePath))
            {
                var lines = File.ReadAllLines(studentFilePath);
                var found = lines.Where(line => line.Split(',')[0] == searchID).FirstOrDefault();

                if (found != null)
                {
                    var data = found.Split(',');
                    dataGridView1.Rows.Add(data[0], data[1], data[2], data[3]);
                }
                else
                {
                    MessageBox.Show("Student ID not found.");
                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
             string id = txtStudentID.Text;
            List<string> lines = File.ReadAllLines(studentFilePath).ToList();
            bool removed = lines.RemoveAll(line => line.Split(',')[0] == id) > 0;

            if (removed)
            {
                File.WriteAllLines(studentFilePath, lines);
                MessageBox.Show("Student record deleted.");
                LoadStudents(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Student ID not found.");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (!File.Exists(studentFilePath))
            {
                MessageBox.Show("No student records found.");
                return;
            }

            var lines = File.ReadAllLines(studentFilePath);
            int totalStudents = lines.Length;
            int totalAge = lines.Sum(line => int.Parse(line.Split(',')[2]));

            double averageAge = totalStudents > 0 ? (double)totalAge / totalStudents : 0;

            lblTotalStudents.Text = $"Total Students: {totalStudents}";
            lblAverageAge.Text = $"Average Age: {averageAge:F2}";

            using (StreamWriter sw = new StreamWriter("summary.txt"))
            {
                sw.WriteLine($"Total Students: {totalStudents}");
                sw.WriteLine($"Average Age: {averageAge:F2}");
            }

            MessageBox.Show("Summary report generated.");
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
