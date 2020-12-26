using System;

namespace Deliverables_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Create a Password Below. Password Must Contain: \n \tAt least one lowercase letter." +
                "\n\tAt least one uppercase letter. \n\tA minimum of seven characters. " +
                "\n\tA maximum of twelve characters.\n\tAn exclaimation point");
            string password = Console.ReadLine();
          
            bool hasUpper = false;
            bool hasLower = false;
            for (int i = 0; i<password.Length; i++) 
            { 
                if (char.IsUpper(password[i])) { hasUpper = true; }
                if (char.IsLower(password[i])) { hasLower = true; }
            } 


            if (password.Length >= 7 && password.Length <= 12) 
            {
                if (password.Contains("!")) 
                {
                    if (hasLower && hasUpper) 
                    { 
                        Console.WriteLine("Password valid and accepted"); 
                    }
                    else { Console.WriteLine("Error"); }

                }
                else { Console.WriteLine("Error"); }

            }
            else { Console.WriteLine("Error"); }
        }



    }
}
