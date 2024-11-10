using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Student_Management_System_
{
    public class DataHandler
    {
        // Specify the path to Student.txt file
        private static string filePath = @"C:\Users\trill\OneDrive\Documents\ACADEMIC\2024\PRG272\PROJECT PRG272 (1)\Student-Management-System_\Student.txt";

        public static List<string[]> LoadStudents()
        {
            List<string[]> students = new List<string[]>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    students.Add(data);
                }
            }
            return students;
        }

        public static void AddStudent(string id, string name, int age, string course)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{id},{name},{age},{course}");
            }
        }

        public static void UpdateStudent(string id, string name, int age, string course)
        {
            var students = LoadStudents();
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var student in students)
                {
                    if (student[0] == id)
                    {
                        sw.WriteLine($"{id},{name},{age},{course}");
                    }
                    else
                    {
                        sw.WriteLine(string.Join(",", student));
                    }
                }
            }
        }

        public static void DeleteStudent(string id)
        {
            var students = LoadStudents();
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var student in students)
                {
                    if (student[0] != id)
                    {
                        sw.WriteLine(string.Join(",", student));
                    }
                }
            }
        }
    }
}
