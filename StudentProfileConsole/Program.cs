using System;

namespace StudentProfileConsole
{
    class Program
    {
        
        const int TotalClassDays = 30;

        static void Main(string[] args)
        {
            Console.Title = "Smart Student Profile Processor (Console)";
            Console.WriteLine("=== Student Readiness Capture System ===\n");

            
            string name = GetValidatedString("Enter student full name: ");
            int age = GetValidatedInt("Enter age (16‑100): ", 16, 100);
            int grade = GetValidatedInt("Enter grade percentage (0‑100): ", 0, 100);
            int daysAttended = GetValidatedInt($"Days attended (0‑{TotalClassDays}): ", 0, TotalClassDays);

            
            Student student = new Student(name, age, grade, daysAttended);

            
            string readiness1 = student.CalculateReadiness();          
            string readiness2 = student.CalculateReadiness(grade);     

            
            Console.Clear();
            Console.WriteLine("=== PROCESSED STUDENT PROFILE ===\n");
            student.DisplayProfile();
            Console.WriteLine($"Readiness (Full Assessment) : {readiness1}");
            Console.WriteLine($"Readiness (Academic Only)   : {readiness2}");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        
        static string GetValidatedString(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(input))
                    Console.WriteLine(" Name cannot be empty. Please try again.");
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        static int GetValidatedInt(string prompt, int min, int max)
        {
            int value;
            bool isValid;
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out value) && value >= min && value <= max;
                if (!isValid)
                    Console.WriteLine($" Please enter a whole number between {min} and {max}.");
            } while (!isValid);
            return value;
        }
    }

    
    public class Student
    {
        
        private string name;
        private int age;
        private int gradePercent;
        private int daysAttended;

        
        public string Name => name;
        public int Age => age;
        public int GradePercent => gradePercent;
        public int DaysAttended => daysAttended;

        
        private const int TotalDays = 30;

        
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

        
        public void DisplayProfile()
        {
            Console.WriteLine($"Name          : {name}");
            Console.WriteLine($"Age           : {age}");
            Console.WriteLine($"Grade         : {gradePercent}%");
            Console.WriteLine($"Attendance    : {daysAttended}/{TotalDays} days ({(double)daysAttended / TotalDays:P0})");
            Console.WriteLine(new string('-', 40));
        }
    }
}