//The goal for this challenge is to make a final exam grader reading A,B,C,D, and F grades. 
//

using System;

public class Program //Standard stuff
{
    public ExamReader myExamReader;  //Calling from the call ExamReader

    public void Main ()
    {
        myExamReader = new ExamReader(); //Setting up ExamReader to be used in the running program

        myExamReader.gradeTest(95); //Calling the class and then specifying  which function within the class
        myExamReader.gradeTest(85);
        myExamReader.gradeTest(75);
        myExamReader.gradeTest(65);
        myExamReader.gradeTest(55);
		myExamReader.gradeTest(0);
		myExamReader.gradeTest(100);
		myExamReader.gradeTest(101);
		myExamReader.gradeTest(-1);
    }
}

public class ExamReader {  //Class to hold our function
    public void gradeTest (int grade) { //Function along with the integer needed
        if (grade >= 90 && grade <= 100) { //Had to use && for the "and" comparison.  Just a fun thing I learned making this.  
            Console.WriteLine("You're grade is an A");
        } else if (grade >= 80 && grade < 90) {
            Console.WriteLine("You're grade is an B");
        } else if (grade >= 70  && grade < 80){
            Console.WriteLine("You're grade is an C");
        } else if (grade >= 60 && grade < 70){
            Console.WriteLine("You're grade is an D");
        } else if (grade < 60 && grade >= 0){
            Console.WriteLine("You're grade is an F");
        } else if (grade > 100 || grade < 0){
			Console.WriteLine("Invalid Input");
		}
    }
}