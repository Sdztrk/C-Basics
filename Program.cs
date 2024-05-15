using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine(Math.Round(9.99));






        }
    }
}
