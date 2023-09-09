//This is where I'll be keeping track of attempts to practice code and work on homework.
//As a general statement I've been doing some before I started documenting in here.  
//I'm making an attempt to make Hello World print out.
//I should note that a lot of the links in the excersizes portion of the Module just straight up didn't work, so I've been improvising.  I hope it's good enough.  

using system;

namespace HelloWorld
{
     class PracticeProof 
     {
          static void main() 
          {
               Console.Write ("Hello World!");
          }
     }
}

//So I think I just learned that this would work in this file if I had a debugger and such, but when I copy and paste this over to a seperate Debuger it told me
//that both using system and Console doesn't exist in this context. So I'll be going through the material in this repository instead.

// I watched the Variable and Operator video and ended up with this code by working along with him.  I am also going to add this code to a new file called Weapons 2.
// In that file I will also change some variables and operators from this to that so I can show that I understand how it works.

using System;
					
public class Program
{
	public Weapon miniGun;
	public PowerUp weaponPowerUp;
	
	public void Main()
	{
		miniGun = new Weapon();
		weaponPowerUp = new PowerUp();
		
		miniGun.ammoCount++;
		miniGun.firePower += weaponPowerUp.powerLevel;
		Console.WriteLine(miniGun.weaponName + " has an ammo count of " + miniGun.ammoCount + ".");
		Console.WriteLine("The fire power of it is now " + miniGun.firePower + ", it has increased. ");
	}
}

public class Weapon {
	public int ammoCount = 10;
	public string weaponName = "Mini Gun";
	public float firePower = 11.5f;
}

public class PowerUp {
	public float powerLevel = 2.5f;
}

//I am now working on the MyClass.cs code.  I will copy and paste the code from there to here.
