// Declaring a variable to use in our loop's boolean expression
int number = 0;

// While the value in number is less than or equal to 100, run the following
while (number <= 100)
{
    // Write the value of number to the console and then increment by 5
    Console.WriteLine(number);
    number = number + 5;
}

//To make the above loop an infinite loop could be done a couple ways, such as modifying the boolean expression to be 
number % 5 == 0 or number != 1 
//as both of these conditions will currently ALWAYS evaluate as true.
//Basically, anything like while (true) {} will be infinite.

//For Loop Structure
for (initializer; condition; iterator)
    body
    