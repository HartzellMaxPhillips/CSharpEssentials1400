using System;

namespace MyApplication
{
  public class Program
  {
    public void Main()
    {
      //Concantenation is a fun word and something I'm using in my demonstration
      //This is a String Variable
      string nameString = "Max";
      Console.WriteLine("My name(String) is: " + nameString); 
      //Output: My name(String) is: Max

      //This is an integer Variable
      int intNumber = 2;
      Console.WriteLine("My age(integer) is: " + intNumber);
      //Output: My age(integer) is: 2
      
      //This is a float Variable, it holds some decimal places
      float myFloat = 7.5f;
      Console.WriteLine("My float is: " + myFloat);
      //Output: My float is: 7.5;

      //This is a Double Variable, it can hold a lot of Decimal places
      double myDouble = 78.193785692;
      Console.WriteLine("My Double: " + myDouble);
      //Output: My Double: 78.193785692

      //This is a Char or Character Variable
      char myChar = 'A';
      Console.WriteLine("My char: " + myChar);
      //Output: My char: A

      //This is a Boolean
      bool myBool = true;
      Console.WriteLine("My boolean: " + myBool);
      //Output: My boolean: True

      
      //Now this is where I will demonstrate operators with the variables that I have
      //I will put additional variables here just in case I need them. :)
      int intNumber1 = 4;
      int intNumber2 = 9;
      float myFloat1 = 4.5f;
      double myDouble1 = 34.34732947D;
      char myChar1 = 'B';
      bool myBool1 = false;


      //Addition operator
      Console.WriteLine(myDouble + myDouble1);
      //Output: 112.541115162

      //Subtraction operator
      Console.WriteLine(myFloat - myFloat1);
      //Output: 3

      //Multiplication Operator
      Console.WriteLine(intNumber * intNumber1);
      //Output: 8

      //Division Operator
      Console.WriteLine(intNumber1 / intNumber);
      //Output: 2

      //Modulus Operator
      Console.WriteLine(intNumber2 % intNumber1);
      //Output: 1

      //Increment and Decrement Operators
      Console.WriteLine(intNumber1++);
      Console.WriteLine(intNumber2--);
      //Output: 5 and 8 respectively
     }
  }

  public class variableExamples 
  {

  }
}
