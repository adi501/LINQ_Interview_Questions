**Left Outer Join using LINQ using Query Syntax**

![image](https://github.com/user-attachments/assets/69b0bcfd-2ce9-4363-9cb1-cf87c2891e9a)

![image](https://github.com/user-attachments/assets/5c1fee3f-addc-466b-b7ea-a1af672d2dbb)

```
//Performing Left Outer Join using LINQ using Query Syntax
//Left Data Source: tbl_Courses
//Right Data Source: tbl_Students
//Note: Left and Right Data Source Matters
var data = from course in objDB.tbl_Courses  //Left Data Source
           join student in objDB.tbl_Students  //Right Data Source
           on course.Id equals student.Course_Id //Inner Join Condition
           into stude //Performing LINQ Group Join
           from stu in stude.DefaultIfEmpty() //Performing Left Outer Join
           select new { stu.Name, course_Name = course.Name }; //Projecting the Result to Anonymous Type

foreach (var d in data)
{
    Console.WriteLine(d.Name+"---"+d.course_Name);

}
Console.ReadLine();
```

![image](https://github.com/user-attachments/assets/21b9a8a5-5a64-4684-b090-29e9ec0d9459)

----------------------------------------------------------------------------------------------------------------------------------

**Find Even Numbers given List using LINQ**

```
List<int> numbers=new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Method 1 : find Even Numbers from List
var evenNumbers = from num in numbers
                  where num % 2 == 0
                  select num;

//Method 2 : find Even Numbers from List
var evenNumbers2 = numbers.FindAll(numbers => numbers % 2 == 0);


//Method 3 : find Even Numbers from List
var evenNumbers3 = numbers.Where(numbers => numbers % 2 == 0);
foreach(var num in evenNumbers3)
{
    Console.WriteLine(num);  //O/P : 2,4,6,8,10
}
Console.ReadLine();
```
---------------------------------------------------------------------------------------------------------------------------------
**Group By in LINQ**
```
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
```
---------------------------------------------------------------------------------------------------------------------------------
