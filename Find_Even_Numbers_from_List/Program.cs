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
    Console.WriteLine(num);
}
Console.ReadLine();


