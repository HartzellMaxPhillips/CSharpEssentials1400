using System; //My first use of foreach loop

    public class Program 
    {
        public void Main ()
        {
            string[] mechs = {"ShadowCat", "Hellspawn", "Cougar", "Raven", "Catapult"};
			Console.WriteLine(mechs.Length);
			foreach(var mech in mechs) {
				Console.WriteLine(mech + " online");
			}
        }
    }

    //for loop, reorganized lines etc.

using System;

    public class Program 
    {
        public void Main ()
        {
            string[] mechs = {"ShadowCat", "Hellspawn", "Cougar", "Raven", "Catapult"};
			
			for (var i = 0;i < mechs.Length; i++) 
			{
				mechs[i] = "Stalker";
			}
			foreach(var mech in mechs) {
				Console.WriteLine(mech);
			}
        }
    }

    //