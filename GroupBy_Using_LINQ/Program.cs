List<Employee> _employees = new List<Employee>
{
    new Employee { Id = 1, Name = "A", Department = "HR", Salary = 10000 },
    new Employee { Id = 2, Name = "B", Department = "IT", Salary = 15000 },
    new Employee { Id = 3, Name = "C", Department = "IT", Salary = 12000 },
    new Employee { Id = 4, Name = "D", Department = "HR", Salary = 11000 },
    new Employee    { Id = 5, Name = "E", Department = "HR", Salary = 9000 },
    new     Employee { Id = 6, Name = "F", Department = "IT", Salary = 13000 }

};
//Method1: Group By Department and find Max Salary and Total Salary
var groupData1 = from emp in _employees
                 group emp by emp.Department into egroup
                 select new
                 {
                     Department = egroup.Key,
                     //Employees = egroup,
                     MaxSal = egroup.Max(e => e.Salary),
                     TotalSal = egroup.Sum(e => e.Salary)
                 };
//Method2: Group By Department and find Max Salary and Total Salary
var groupData2 = _employees.GroupBy(e => e.Department)
    .Select(g => new { Department = g.Key, MaxSal = g.Max(e => e.Salary), TotalSal = g.Sum(e => e.Salary) });
foreach (var d in groupData2)
{
    Console.WriteLine(d.Department + " " + d.MaxSal + " " + d.TotalSal);
}
Console.ReadLine();

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}