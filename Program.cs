// Задача 1. Напишите программу, которая на вход принимает 2 числа и определяет какое число большее, а какое меньшее.
Console.WriteLine("Please enter two numbers to derminate which number is bigger and which is smaller. ");
Console.WriteLine("Please enter the first number:");
double Number_1=Convert.ToDouble(readline());//Enter the first number
Console.WriteLine("Please enter the second number:");
double Number_2=Convert.ToDouble(readline());//Enter the second number
if (Number_1>Number_2) //Check if the first number is bigger than the second.
{
    Console.WriteLine("The first number="+" "+Number_1+"is bigger." "The second number="+" "+Number_2+"is smaller.");
}
else if (Number_1<Number_2) //Check if the second number is bigger than the first.
{
    Console.WriteLine("The second number="+" "+Number_2+"is bigger." "The first number="+" "+Number_1+"is smaller.");
}
else // If the first=the second
{
    Console.WriteLine("Both numbers are equal.); 
}