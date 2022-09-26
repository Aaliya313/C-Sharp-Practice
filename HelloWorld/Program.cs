// See https://aka.ms/new-console-template for more information
//LEARNING C#

using System.Collections;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
String? x = Console.ReadLine(); //All inputs are treated as strings. String? to account for null inputs
//int num = x.ToString; //can change string input to another type of data-type
//casting by CONVERSION METHOD
int num2 = Convert.ToInt32(x);
num2 = num2 + 100;
Console.WriteLine(num2);

//IF statement
int y = 5;
if (y==5)
{
    Console.WriteLine($"y is {y}"); //$ is a string notation when you can just reference the variables straight away
}   //equivalent of Java concantentation 
else
{
    Console.WriteLine("y does not equal 5");
}


//SWITCH AND CASE
//cna have them calling other methods if you wanted
//need to wrap with a loop if you want
Console.WriteLine("Main Menu");
Console.WriteLine("1. Print Page");
Console.WriteLine("2. Edit a Page");
Console.WriteLine("3. Exit Program");
string? userInput = Console.ReadLine();
switch (userInput)
{
    case "1":
        Console.WriteLine("Page Printed");
        break;
    case "2":
        Console.WriteLine("Page editted");
        break;
    case "3":
        Console.WriteLine("Exit Program");
        break;
    default:
        Console.WriteLine("Entry not recognised");
        break;
}

//FOR LOOP
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + 1);
}


//WHILE LOOP
//bool student = true;
//while (student)
//{
//write code properly, state condition 
//}

//DO-WHILE LOOP
//do
//{

//} while {

//}

//ARRAYS
//int[] arr = {1,2,3,4,5,6};
//array with multiple dimensions use a comma
//int[,] arr2 = new int[5, 5]; // 2D array of 5 by 5 
//int[,,] arr3 = new int[5, 5, 5]; //3D array of 5 by 5 by 5

//ARRAY-LIST
ArrayList list = new ArrayList();
list.Add("Aaliya");
list.Add("1");
foreach (string i in list)
{
    Console.WriteLine(i);

}

// LINK-LISTS
LinkedList<string> list2 = new LinkedList<string>();
list2.AddFirst("aaliya");
list2.AddLast("2");
foreach (string i in list2)
{
    Console.WriteLine(i);
}

//METHODS AND CLASSES
class program: notProgram //Inheritance
{
    public static void Main(string[] args)
    {

        int myAge = 16;
        gettingOlder(myAge);
        Console.WriteLine($"My Age is {myAge}");
    }
}
class notProgram { 
    protected static int gettingOlder(int age) //protected is not the same as in Java - need to use inheritance in main class
    {
        age++;
        //Console.WriteLine(age.ToString());
        return age;
    }
  }

//CREATING OBJECTS
//need to create a psvm on another winow and call the class and create an obejct
//need to create a class by right-clicking on the right hand side on helloworld to create a class