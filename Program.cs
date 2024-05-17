

// double myDouble = 9.78D;
// int myInt = (int)myDouble;    // Manual casting: double to int

// Console.WriteLine(myDouble);   // Outputs 9.78
// Console.WriteLine(myInt);      // Outputs 9
// Console.WriteLine(Convert.ToString(myDouble));
// int bigInt = 1999999999;
// Console.WriteLine(bigInt);

// *******************************************************************


// int myNum = 5;               // Integer (whole number) There are two types of integer first is "int"(4 bytes), secong is "long"(8 Bytes)
// double myDoubleNum = 5.99D;  // Floating point number There are two types of floats, first "float"(6 or 7), second is "double"(bis zu 14)
// char myLetter = 'D';         // Character
// bool myBool = true;          // Boolean
// string myText = "Hello";     // String

// Console.WriteLine(myNum);
// Console.WriteLine(myDoubleNum);
// Console.WriteLine(myLetter);
// Console.WriteLine(myBool);
// Console.WriteLine(myText);


// *******************************************************************



// Console.WriteLine("Enter your age:");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your age is: " + age);

// *******************************************************************


// int myInt = 10;
// double myDouble = 5.25;
// bool myBool = true;

// Console.WriteLine(Convert.ToString(myInt));    // convert int to string
// Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
// Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
// Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


// Type typeMyInt = myInt.GetType();
// Console.WriteLine(typeMyInt);


// *******************************************************************

// int myInt = 10;
// Type typeMyInt = myInt.GetType();
// Console.WriteLine(typeMyInt);

// bool myBool = Convert.ToBoolean(myInt);
// Type myDoubleType = myBool.GetType();
// Console.WriteLine(myBool);



// *******************************************************************

// int sum1 = 100 + 50;
// int sum2 = sum1 + 250;
// int sum3 = sum2 + sum2;

// Console.WriteLine(sum1);
// Console.WriteLine(sum2);
// Console.WriteLine(sum3);

// *******************************************************************

// long myNum = Math.Max(8000000000000000000, 1000000000000000000);
// Console.WriteLine(myNum);

// *******************************************************************

// Console.WriteLine(Math.Round(9.99));

// *******************************************************************

// string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
// Console.WriteLine("The length of the txt string is: " + txt.Length);

// string txt = "Hello World";
// Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
// Console.WriteLine(txt.ToLower());   // Outputs "hello world"

// *******************************************************************

// string firstName = "John ";
// string lastName = "Doe";
// string name = string.Concat(firstName, lastName);
// Console.WriteLine(name);

// string firstName = "John";
// string lastName = "Doe";
// string name = $"My full name is: {firstName} {lastName}";
// Console.WriteLine(name);

// string txt = "We are the so-called \"Vikings\" from the north.";
// Console.WriteLine(txt);

// *******************************************************************

// int x = 10;
// int y = 9;
// Console.WriteLine( $"x is bigger then y : {x > y}");
// int x = 10;
// Console.WriteLine(x == 10);
// Console.WriteLine(x == 15);


// *******************************************************************

// int myAge = 25;
// int votingAge = 18;

// if (myAge >= votingAge)
// {
//     Console.WriteLine("Old enough to vote!");
// }
// else
// {
//     Console.WriteLine("Not old enough to vote.");
// }


//else if

// int time = 22;
// if (time < 10)
// {
//     Console.WriteLine("Good morning.");
// }
// else if (time < 20)
// {
//     Console.WriteLine("Good day.");
// }
// else
// {
//     Console.WriteLine("Good evening.");
// }

// *******************************************************************

// int day = 10;
// switch (day)
// {
//     case 1:
//         Console.WriteLine("Monday");
//         break;
//     case 2:
//         Console.WriteLine("Tuesday");
//         break;
//     case 3:
//         Console.WriteLine("Wednesday");
//         break;
//     case 4:
//         Console.WriteLine("Thursday");
//         break;
//     case 5:
//         Console.WriteLine("Friday");
//         break;
//     case 6:
//         Console.WriteLine("Saturday");
//         break;
//     case 7:
//         Console.WriteLine("Sunday");
//         break;
//     default:
//         Console.WriteLine("Looking forward to the Weekend.");
//         break;
// }

// *******************************************************************


// int i = 0;
// while (i < 5)
// {
//     Console.WriteLine(i);
//     i++;
// }


// for (int j = 0; j < 5; j++)
// {

//     Console.WriteLine(j);

// }

// // Outer loop
// for (int i = 1; i <= 3; ++i)
// {
//     Console.WriteLine("Outer: " + i);  // Executes 2 times

//     // Inner loop
//     for (int j = 1; j <= 3; j++)
//     {
//         Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
//     }
// }

// string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

// foreach (string i in cars)
// {
//     Console.WriteLine(i);
// }

// *******************************************************************

// for (int i = 0; i < 10; i++)
// {
//     if (i == 4)
//     {
//         continue; //if i is equel to 4 it skips the value
//      //   break;
//     }
//     Console.WriteLine(i);
// }

// int i = 0;
// while (i < 10)
// {
//     if (i == 4)
//     {
//         i++;
//         continue;
//     }
//     Console.WriteLine(i);
//     i++;
// }

//***********************************************************

// string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
// int[] numbers = { 12, 15, 17, 20 };


// Console.WriteLine(cars[0]);
// cars[0] = "Opel";
// Console.WriteLine(cars[0]);


// for (int i = 0; i< cars.Length; i++){
//     Console.WriteLine(cars[i]);
// }

// for (int i = numbers.Length-1 ; i >= 0 ; i--){
//     Console.WriteLine(numbers[i]);
// }

// foreach (string i in cars)
// {
//     Console.WriteLine(i);
// }


// Array.Sort(cars);
// foreach (string i in cars)
// {
//     Console.WriteLine(i);
// }

// int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
// string[,] cars = { { "Volvo", "Volkswagen" }, { "Golf", "Schwarz" } };
// Console.WriteLine(numbers[1,0]);

// foreach(int i in numbers){
//     Console.WriteLine(i);
// }

// foreach(string i in cars) {
//     Console.WriteLine(i);
// }

//*************************************************************************

// static void MyMethod()
// {
//     Console.WriteLine("I just got executed!");
// }
// MyMethod();


//*********************   Simple Calculator        *********************************************


// static void Rechner(double num1, double num2, char operation)

// {

//     double result;

//     switch (operation)
//     {
//         case '+':
//             result = num1 + num2;
//             break;
//         case '-':
//             result = num1 - num2;
//             break;
//         case '*':
//             result = num1 * num2;
//             break;
//         case '/':
//             if (num2 != 0)
//             {
//                 result = num1 / num2;
//             }
//             else
//             {
//                 Console.WriteLine("Numbers can not be devided by 0!");
//                 return;
//             }
//             break;
//         default:
//             Console.WriteLine("Unvalid Operation");
//             return;
//     }

//     Console.WriteLine("Result: " + result);
// }

// Rechner(10.5, 10, '*');




// static void RechnerMitElseIf(long num1, long num2, char operation)
// {

//     long result;

//     if (operation == '*')
//     {
//         result = num1 * num2;
//         Console.WriteLine($"Result is : {result} ");
//     }

//     else if (operation == '/')
//     {
//         result = num1 / num2;
//         Console.WriteLine($"Result is : {result} ");
//     }

//     else if (operation == '+')
//     {
//         result = num1 + num2;
//         Console.WriteLine($"Result is : {result} ");
//     }
//     else if (operation == '-')
//     {
//         result = num1 - num2;
//         Console.WriteLine($"Result is : {result} ");
//     }

// }

// RechnerMitElseIf(150, 15, '+');



// class Car
// {
//   string color = "red";
//   int year = 2020;
//   static void Main(string[] args)
//   {
//     Car myObj1 = new Car();
//     Console.WriteLine(myObj1.color);
//     Console.WriteLine(myObj1.year);
//     Vehicle myVehicle = new Vehicle();
//     Console.WriteLine(myVehicle.marke);
//     Console.WriteLine(myVehicle.year);
//   }
// }


// Car Ford = new Car();
// Ford.model = "Mustang";
// Ford.color = "red";
// Ford.year = 1969;

// Car Opel = new Car();
// Opel.model = "Astra";
// Opel.color = "white";
// Opel.year = 2005;

// Console.WriteLine(Ford.model);
// Console.WriteLine(Opel.model);
// Console.WriteLine(Opel.year);

//**************************************************************************************************


// class Car
// {
//   public string model;
//   public string color;
//   public int year;

//   // Create a class constructor with a parameter
//   public Car(string modelName, int modelYear, string modelColor)
//   {
//     model = modelName;
//     year = modelYear;
//     color = modelColor;
//   }

//   static void Main(string[] args)
//   {
//      Car Ford = new Car("Mustang", 2020,"White");
//      Console.WriteLine(Ford.model);
//      Console.WriteLine(Ford.year);
//      Console.WriteLine(Ford.color);
//      Console.WriteLine(Ford.color + "  " + Ford.year+ "   " + Ford.color);
//   }
// }














//****************************ENCAPSULATION*******************************

// class Person
// {
//   private string name; // field
//   public string Name   // property
//   {
//     get { return name; }
//     set { name = value; }
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Person myObj = new Person();
//     myObj.Name = "John";
//     Console.WriteLine(myObj.Name);
//   }
// }

//*******************************INHERITANCE****************************

// class Vehicle  // base class (parent) 
// {
//   public string brand = "Ford";  // Vehicle field
//   public void honk()             // Vehicle method 
//   {                    
//     Console.WriteLine("Tuut, tuut!");
//   }
// }

// class Car : Vehicle  // derived class (child)
// {
//   public string modelName = "Mustang";  // Car field
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     // Create a myCar object
//     Car myCar = new Car();

//     // Call the honk() method (From the Vehicle class) on the myCar object
//     myCar.honk();

//     // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
//     Console.WriteLine(myCar.brand + " " + myCar.modelName);
//   }
// }


//****************************************POLYMORPHISM***************************************


// class Animal  // Base class (parent) 
// {
//   public virtual void  animalSound() 
//   {
//     Console.WriteLine("The animal makes a sound");
//   }
// }

// class Pig : Animal  // Derived class (child) 
// {
//   public override void animalSound() 
//   {
//     Console.WriteLine("The pig says: wee wee");
//   }
// }

// class Dog : Animal  // Derived class (child) 
// {
//   public override void animalSound() 
//   {
//     Console.WriteLine("The dog says: bow wow");
//   }
// }

// class Program 
// {
//   static void Main(string[] args) 
//   {
//     Animal myAnimal = new Animal();  // Create a Animal object
//     Animal myPig = new Pig();  // Create a Pig object
//     Animal myDog = new Dog();  // Create a Dog object

//     myAnimal.animalSound();
//     myPig.animalSound();
//     myDog.animalSound();
//   }
// }

//********************************************ABSTRACTION*********************************************

// namespace MyApplication
// {
//   // Abstract class
//   abstract class Animal
//   {
//     // Abstract method (does not have a body)
//     public abstract void animalSound();
//     // Regular method
//     public void sleep()
//     {
//       Console.WriteLine("Zzz");
//     }
//   }
  
//   // Derived class (inherit from Animal)
//   class Pig : Animal
//   {
//     public override void animalSound()
//     {
//       // The body of animalSound() is provided here
//       Console.WriteLine("The pig says: wee wee");
//     }
//   }

//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Pig myPig = new Pig();  // Create a Pig object
//       myPig.animalSound();
//       myPig.sleep();
//     }
//   }
// }