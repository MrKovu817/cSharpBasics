string instructorName = "DeJuan";
string[] instructors = new string[] { "Michael", "Joshua", instructorName };

foreach (string name in instructors)
{
    Console.WriteLine(name);
}


//Bronze Challenge
Write a for loop to print the numbers 500 through 525

for (int i = 500; i <= 525; i++)
{
    Console.WriteLine(i);
}

//Silver Challenge
Create a for loop to print the numbers from 0-100 by 5's.

for (int i = 0; i <= 100; i += 5)
{
    Console.WriteLine(i);
}

// or alternative Silver
for (int i = 0; i <= 100; i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}

//Gold Challenge
Create a for loop to print the numbers 1-100. If the number is 
divisible by 3, print Fizz instead of the number. 
If it's divisible by 5, print Buzz, instead of the number. 
If it's divisible by both 3 and 5, print FizzBuzz otherwise print the number.

for (int i = 0; i <= 100; i++)
{
    if (i % 15 == 0) // alternatively (i % 5 == 0 && i % 3 ==0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}