// See https://aka.ms/new-console-template for more information
string userResponse = Console.ReadLine();

if (int.TryParse(userResponse, out int value)) 
{

    Console.WriteLine("The entered value is a integer");

}