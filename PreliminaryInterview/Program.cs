//Task 1:
//Declare and initialize the following variables:

//A string variable named name with the value "John Doe"
//An integer variable named age with the value 25
//A boolean variable named isAdmin with the value true
//Print the values of these variables to the console.
//Answer

string name = "John Doe";
int age  = 25;
bool isAdmin = true;
Console.WriteLine($"My name is {name}");
Console.WriteLine($"And am {age} years old.");
Console.WriteLine($"isAdmin is ={isAdmin}");


//Task 2:
//Write a program that takes an integer input from the user and prints out whether the number is even or odd.
//Use an if-else statement to determine whether the number is even or odd.
//Print "Even" if the number is even, and "Odd" if the number is odd.


Console.Write("Enter a number:");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"{number} is Even number");
}

else
{
Console.WriteLine($"{number} is Odd number");
};


//Task 3:
//Write a program that prints out the numbers 1 to 10 using a for loop.
//Use a for loop to iterate from 1 to 10.
//Print each number to the console.


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//Task 4: 
//Declare and initialize an integer array with the values 2, 4, 6, 8, 10.
//Print the sum of all elements in the array to the console.
//Use a foreach loop to iterate over the array and print each element to the console.

int[] numbers = { 2, 4, 6, 8, 10 };
int sum = 0;
foreach (var item in numbers)
{
    sum+= item;
}

Console.WriteLine($"The addition of all the array is {sum}");


//Task 5:
//Write a method named Greet that takes a string parameter name and prints out a personalized greeting message.
//The method should print "Hello, !" to the console.
//Call the Greet method from the Main method with the argument "Alice".

string greet = Greet("Alice");
Console.WriteLine(greet);


static string Greet(string name)
{
    return $"Hello,{name}!";
}





