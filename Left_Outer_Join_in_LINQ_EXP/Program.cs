﻿//Ref: https://dotnettutorials.net/lesson/left-outer-join-in-linq/

using Left_Outer_Join_in_LINQ_EXP;

DataClasses1DataContext objDB = new DataClasses1DataContext("Data Source=.;Initial Catalog=TestDB;Integrated Security=True;TrustServerCertificate=True;");

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

