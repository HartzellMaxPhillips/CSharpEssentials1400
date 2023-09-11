using System;


public class Program 
{
    public void Main () 
    {
        //This is how many cookies the familes start with
        float cookiesWard = 10f;
        float cookiesPhillips = 11f;
        
        //Finigan eats a cookie and a bite from both of them
        float finiganEats = 1.1f;
        cookiesWard = cookiesWard - finiganEats;
        cookiesPhillips = cookiesPhillips - finiganEats;

        //Carly eats half a cookie from the wards
        float carlyEats = 0.5f;
        cookiesWard = cookiesWard - carlyEats;

        //The cookies get blessed by a fairy and double up and then some.
        float fairyBless = 2.5f;
        cookiesWard = cookiesWard * fairyBless;
        cookiesPhillips = cookiesPhillips * fairyBless;

        //Finally the cookies get divided amongs everyone evenly
        float numFamilyMembers = 10;
		
		float cookiesW = cookiesWard;
		float cookiesP = cookiesPhillips;

        cookiesW = cookiesWard / numFamilyMembers;
        cookiesP = cookiesPhillips / numFamilyMembers;

        float cookiesTotal = cookiesW + cookiesP;

        

        //writing out the variables as requested.
        Console.WriteLine ("Ward Cookies Before: " +cookiesWard);
        Console.WriteLine ("Phillips Cookies Before: " +cookiesPhillips);
        Console.WriteLine ("Ward Cookies After" +cookiesW);
        Console.WriteLine ("Phillips Cookies After: " +cookiesP);
        Console.WriteLine ("Phillips and Ward cookies after: " +cookiesTotal);


    

    }
}