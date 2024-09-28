namespace Solution
{
    public class Employee{
        public required string Name { get; set; }
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }
    }
    //class responsible for saving data
    public class EmployeeData{
        public void SaveToFile(Employee employee)
        {
            Console.WriteLine($"Employee.txt Name {employee.Name} hourly worked: {employee.HoursWorked} Hourly rate: {employee.HourlyRate}");
            Console.WriteLine("Saved data to the file!");
        }
    }
    public class EmployeeSalary{
        public int CalculateSalary(Employee employee)
        {
            return employee.HourlyRate * employee.HoursWorked;
        }
    }
    //class responsible for calculating salary
}