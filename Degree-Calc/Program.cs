namespace Degree_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classA = new Student(5, new double[] { 80.5, 85, 93, 97.5, 98 });
            var classB = new Student(5, new double[] { 70.5, 75, 83, 87.5, 88 });

            classA.PrintClassInfo();
            classB.PrintClassInfo();


        }
    }
}
