using System;
//Final expansion upon my challenge to make all the numbers inputed

public class Program 
{
    public void Main () 
    {
        //This is how many cookies the familes start with  
        Console.WriteLine("How many cookies does the Ward Family Have?");
		float cookiesWard = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The Ward Family has " + cookiesWard +" Cookies");

        Console.WriteLine("How many cookies does the Phillips Family Have?");
		float cookiesPhillips = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The Phillips Family has " + cookiesPhillips +" Cookies");

        //Finigan eats a certain amount of cookies
        Console.WriteLine("How many cookies does Finigan eat from the Ward family?");
        float finiganEatsW = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many cookies does Finigan eat from the Phillips family?");
        float finiganEatsP = Convert.ToInt32(Console.ReadLine());

        cookiesWard = cookiesWard - finiganEatsW;
        cookiesPhillips = cookiesPhillips - finiganEatsP;

        //Carly eats a certain amount of cookies
        Console.WriteLine("How many cookies does Carly eat from the Ward family?");
        float carlyEatsW = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many cookies does Carly eat from the Phillips family?");
        float carlyEatsP = Convert.ToInt32(Console.ReadLine());
        
        cookiesWard = cookiesWard - carlyEatsW;
        cookiesPhillips = cookiesPhillips - carlyEatsP;

        //The cookies get blessed by a fairy to be multiplied.
        Console.WriteLine("How much does the fairy Multiply all the cookies by?");
        float fairyBless = Convert.ToInt32(Console.ReadLine());

        cookiesWard = cookiesWard * fairyBless;
        cookiesPhillips = cookiesPhillips * fairyBless;

        //Finally the cookies get divided amongs everyone evenly
		Console.WriteLine("How many family members does the cookies get divided amongst?");
        float numFamilyMembers = Convert.ToInt32(Console.ReadLine());

		float cookiesW = cookiesWard;
		float cookiesP = cookiesPhillips;

        cookiesW = cookiesWard / numFamilyMembers;
        cookiesP = cookiesPhillips / numFamilyMembers;

        float cookiesTotal = cookiesW + cookiesP;

        //writing out the variables as requested.
        Console.WriteLine ("Ward Cookies After Eating: " +cookiesW);
        Console.WriteLine ("Phillips Cookies After Eating: " +cookiesP);
        Console.WriteLine ("Phillips and Ward cookies after: " +cookiesTotal);


    

    }
}