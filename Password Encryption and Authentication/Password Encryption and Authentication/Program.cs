using System;
using System.Collections.Generic;
using System.Linq;

namespace Password_Encryption_and_Authentication
{
    class Program
    {

        /// <summary>
        /// IN THIS PROGRAM I CRERATED MY OWN SIMPLE HASHING ALGORITHM THAT CHANGES THE WORDS AND SYMBOLS INTO NUMBERS AND SPREADS EACH NUMBER INTO A LIST
        /// </summary>
        static void Main()
        {
            Dictionary<string, List<int>> account = new Dictionary<string, List<int>>();
            Encrypt encrypt = new Encrypt();
            int exit = 0;
            while (exit == 0)
            {
                
                Console.WriteLine("PASSWORD AUTHENTICATION SYSTEM");
                Console.WriteLine();
                Console.WriteLine("Please select one option: \n1.Establish an account \n2.Authenticate a user \n3.Exit the system ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int enter = 0;
                        Console.WriteLine("Please enter a username and a Password\n\n Username:");
                        string userName = Console.ReadLine();
                        if (account.ContainsKey(userName) ==true)
                        {
                            Console.WriteLine("Username is taken");
                            Console.ReadLine();
                        }
                        else if (account.ContainsKey(userName) == false)
                        {
                            enter = 1;
                        }
                        while (enter == 1)
                        {
                            Console.WriteLine("Password(15 characters MAX):");
                            string passWord = Console.ReadLine();
                            List<int> test = encrypt.CrossMix(passWord);
                            Console.WriteLine("Encrypted Password" + string.Join("", test));
                            account.Add(userName, test);
                            enter = 0;
                            Console.ReadLine();
                        }
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Sign in");
                        Console.WriteLine("Username: ");
                        string verifyUSN = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        string verifyPSW = Console.ReadLine();
                        List<int> test1 = encrypt.CrossMix(verifyPSW);                   
                        foreach (KeyValuePair<string, List<int>> element in account)
                        {
                            
                            string name = element.Key;
                            List<int> age = element.Value;
                            bool isEqual = Enumerable.SequenceEqual(age, test1);
                            if (name == verifyUSN && isEqual)
                            {
                                Console.WriteLine("Welcome" + name);

                            }
                        }
                        Console.Clear();
                        break;
                    case 3:

                        exit = 1;
                        Console.Clear();
                        break;
                }
            }


            
        }
        
        
    }
}
