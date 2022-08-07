// See https://aka.ms/new-console-template for more information

// Protorype - Defines the function (type, name and parameters)
//Definition - Has the code. It contains the code block
//Function Call - Makes the fucntion
// DRY - Don't Repaat Yourself
//YAGNI - You are't going to need it

// Void Functions - Completas a taks and moves along
void PrintName()
{
	Console.WriteLine("Joanbelk Garcia Alvarado");
}

void Addition(int num1, int num2)
{
	Console.WriteLine($"THe sum of {num1} and {num2} is {num1 + num2}");
}
	// value Returning Functions - Completes a task, return a result
int LargestNumber(int num1, int num2, int num3)
{
	int largest = num1;
	if(largest < num2)
	{
		largest = num2;
	}
	if(largest < num3)
	{
		largest = num3;
	}
	return largest;
}




PrintName();

Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);
Console.WriteLine("End of Void Function");

Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"Largest number is: {result}");