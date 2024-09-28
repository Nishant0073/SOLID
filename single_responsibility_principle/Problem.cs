namespace Problem
{
    public class Employeen
    {
        public required string Name { get; set; }
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }


        //Voilated SRP as save to file is doing file saving functionalyy as well as calculating salary in one class Employee
        public void SaveToFile()
        {
            Console.WriteLine($"Employee.txt Name {Name} hourly worked: {HoursWorked} Hourly rate: {HourlyRate}");
            Console.WriteLine("Saved data to the file!");
        }

        //Voilated SRP as save to file is doing file saving functionalyy as well as calculating salary in one class Employee
        public int CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}