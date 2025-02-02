    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Degree_Calc
    {
        public class Student
        {
            public int numberOfStudents;
            public double[] studentGrades;

            public Student(int numberOfStudents, double[] studentGrades)
            {
                this.numberOfStudents = numberOfStudents;
                this.studentGrades = studentGrades;
            }

            public double CalculateMaximumGrade()
            {
                double maxGrade = this.studentGrades.Max();
                return maxGrade;
            }

            public double CalculateMinimumGrade()
            {
                double minGrade = this.studentGrades.Min();
                return minGrade;
            }

            public double CalculateAverageGrade()
            {
                double averageGrade = this.studentGrades.Average();
                return averageGrade;
            }

            public double[] CalculateMaximumGradeToAverage()
            {
                double average = CalculateAverageGrade();
                IList<double> maxGrades = new List<double>();
                foreach (var grade in this.studentGrades)
                {
                    if (grade > average)
                    {
                        maxGrades.Add(grade);
                    }
                }

                return maxGrades.ToArray();
            }

            public double[] CalculateMinimumGradeToAverage()
            {
                double average = CalculateAverageGrade();
                IList<double> minGrades = new List<double>();
                foreach (var grade in this.studentGrades)
                {
                    if (grade < average)
                    {
                        minGrades.Add(grade);
                    }
                }

                return minGrades.ToArray();
            }

            public void PrintClassInfo()
            {
                Console.WriteLine($"The Maximum Grade is: {CalculateMaximumGrade()}");
                Console.WriteLine($"The Minimum Grade is: {CalculateMinimumGrade()}");
                Console.WriteLine($"The Average Grade is: {CalculateAverageGrade()}");
                Console.WriteLine($"The Maximum Average Grade is: {string.Join(" ", CalculateMaximumGradeToAverage())}");
                Console.WriteLine($"The Minimum Average Grade is: {string.Join(" ", CalculateMinimumGradeToAverage())}");
            }
        }
    }
