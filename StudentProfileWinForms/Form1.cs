using System;
using System.Windows.Forms;

namespace StudentProfileWinForms
{
    public partial class Form1 : Form
    {
        
        private const int TotalClassDays = 30;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Smart Student Profile Processor";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
        private void btnProcess_Click(object sender, EventArgs e)
        {
            
            if (!ValidateInputs(out string name, out int age, out int grade, out int days))
                return;

           
            Student student = new Student(name, age, grade, days);

            
            string readinessFull = student.CalculateReadiness();
            string readinessAcademic = student.CalculateReadiness(grade);

            
            rtbOutput.Clear();
            rtbOutput.AppendText("=== PROCESSED STUDENT PROFILE ===\n\n");
            rtbOutput.AppendText($"Name          : {student.Name}\n");
            rtbOutput.AppendText($"Age           : {student.Age}\n");
            rtbOutput.AppendText($"Grade         : {student.GradePercent}%\n");
            rtbOutput.AppendText($"Attendance    : {student.DaysAttended}/{TotalClassDays} days ({(double)student.DaysAttended / TotalClassDays:P0})\n");
            rtbOutput.AppendText(new string('-', 40) + "\n");
            rtbOutput.AppendText($"Readiness (Full)      : {readinessFull}\n");
            rtbOutput.AppendText($"Readiness (Academic)  : {readinessAcademic}\n");
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtGrade.Clear();
            txtDaysAttended.Clear();
            rtbOutput.Clear();
            txtName.Focus();
        }

        
        private bool ValidateInputs(out string name, out int age, out int grade, out int days)
        {
            name = txtName.Text.Trim();
            age = grade = days = 0;

            
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            
            if (!int.TryParse(txtAge.Text, out age) || age < 16 || age > 100)
            {
                MessageBox.Show("Age must be a whole number between 16 and 100.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return false;
            }

            
            if (!int.TryParse(txtGrade.Text, out grade) || grade < 0 || grade > 100)
            {
                MessageBox.Show("Grade must be a whole number between 0 and 100.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrade.Focus();
                return false;
            }

            
            if (!int.TryParse(txtDaysAttended.Text, out days) || days < 0 || days > TotalClassDays)
            {
                MessageBox.Show($"Days attended must be between 0 and {TotalClassDays}.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDaysAttended.Focus();
                return false;
            }

            return true;
        }
    }

    
    public class Student
    {
        private readonly string name;
        private readonly int age;
        private readonly int gradePercent;
        private readonly int daysAttended;

        private const int TotalDays = 30;

        public string Name => name;
        public int Age => age;
        public int GradePercent => gradePercent;
        public int DaysAttended => daysAttended;

        public Student(string name, int age, int gradePercent, int daysAttended)
        {
            this.name = name;
            this.age = age;
            this.gradePercent = gradePercent;
            this.daysAttended = daysAttended;
        }

        public string CalculateReadiness()
        {
            double attendanceRatio = (double)daysAttended / TotalDays;
            int score = (int)(gradePercent * 0.6 + attendanceRatio * 100 * 0.4);

            if (score >= 70 && attendanceRatio >= 0.75)
                return " READY";
            else if (score >= 50 || attendanceRatio >= 0.5)
                return " CONDITIONAL";
            else
                return " NOT READY";
        }

        public string CalculateReadiness(int gradeOnly)
        {
            if (gradeOnly >= 70)
                return " READY (Academic)";
            else if (gradeOnly >= 50)
                return " CONDITIONAL (Academic)";
            else
                return " NOT READY (Academic)";
        }
    }
}