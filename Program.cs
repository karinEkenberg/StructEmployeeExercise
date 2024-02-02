namespace StructEmployeeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dd = 0, mm = 0, yy = 0;
            int total = 2;
            Console.WriteLine("Creating a nested structure to store data in an array:");
            Console.WriteLine("------------------------------------------------------");
            Employee[] emp = new Employee[total];
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Enter name of the employee:");
                string eName = Console.ReadLine();
                emp[i].name = eName;

                Console.WriteLine("Enter day of birth:");
                dd = int.Parse(Console.ReadLine());
                emp[i].Date.Day = dd;

                Console.WriteLine("Enter month of birth:");
                mm = int.Parse(Console.ReadLine());
                emp[i].Date.Month = mm;

                Console.WriteLine("Enter year of birth:");
                yy = int.Parse(Console.ReadLine());
                emp[i].Date.Year = yy;
            }
        }
    }
}
