using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SingleResponsability
{
    public class ExportHelper
    {
        public void ExportData<T>(IEnumerable<T> data, Func<T, string> dataToString)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("| Id | Fullname           |Grades |");

            data.ToList().ForEach(item => sb.AppendLine(dataToString(item)));

            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString());
        }

        public void ExportStudents(IEnumerable<Student> students)
        {
            ExportData(students, student => $"| {student.Id,-2} | {student.Fullname,-18} | {string.Join("|",student.Grades)} |");
        }
    }
}
