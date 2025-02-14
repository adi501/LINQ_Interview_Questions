**Left Outer Join using LINQ using Query Syntax**

![image](https://github.com/user-attachments/assets/69b0bcfd-2ce9-4363-9cb1-cf87c2891e9a)

'''
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
'''

![image](https://github.com/user-attachments/assets/21b9a8a5-5a64-4684-b090-29e9ec0d9459)

----------------------------------------------------------------------------------------------------------------------------------
