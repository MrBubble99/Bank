using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {







        static void Main(string[] args)
        {
           User Us = new User();
           Transaction Trans = new Transaction();

           List<Transaction> TransList = new List<Transaction>();
           List<User> UserList = new List<User>();



            Us.Unsername = "Emilio";
            Us.PassWort = "123";
            Us.USD = 2500;
            Us.BankNumber = 12345;
            UserList.Add(Us);


            Us.Unsername = "Valentina";
            Us.PassWort = "456";
            Us.USD = 2500;
            Us.BankNumber = 345678;
            UserList.Add(Us);


            //Us.Unsername = "Amelia";
            //Us.PassWort = "789";
            //Us.USD = 2500;
            //Us.BankNumber = 89101112;
            //UserList.Add(Us);

            var rand = new Random();
            string actualUser = "";
            int actualUserAccount = 0;
            bool logedIn = false;
            int actualUserMony = 0;
            int actualUserId;
            for (int y = 0; y < 4; y++)
            {

                Console.WriteLine("Do yo have a User? Answer with yes / no");
                string answer = Console.ReadLine();

                if (answer.ToLower().Equals("yes"))
                {


                    Console.WriteLine("Introduce your Username");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Introduce your Passwort");
                    string passwort = Console.ReadLine();

                    for (int i = 0; i < UserList.Count; i++)
                    {
                        if (userName == UserList[i].Unsername && passwort == UserList[i].PassWort)
                        {
                            actualUser = UserList[i].Unsername;
                            actualUserAccount = UserList[i].BankNumber;
                            actualUserMony = UserList[i].USD;
                            actualUserId = i;

                            logedIn = true;
                            Console.WriteLine("your logedin");
                            Console.WriteLine($"your balance is: {UserList[i].USD}");
                            Console.WriteLine("Do you want to make a transaction? Yes/No");
                            string trans = Console.ReadLine();
                            if (trans.ToLower() == "yes")
                            {
                                Console.WriteLine("Introduce the name from the benefited");
                                Trans.RecivingUser = Console.ReadLine();
                                Console.WriteLine("Introduce the Acount number from the benefited");
                                Trans.AcountNoRU = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Introdce the amount you will transfer");
                                Trans.TrasAmount = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Introdce the reference for the transfer");
                                Trans.RefTrans = Console.ReadLine();
                                Trans.AcountNoPU = actualUserAccount;
                                Trans.PayingUser = actualUser;

                                for (int x = 0; x < UserList.Count; x++)
                                {
                                    if (Trans.RecivingUser == UserList[x].Unsername && Trans.AcountNoRU == UserList[x].BankNumber && Trans.TrasAmount <= actualUserMony)
                                    {
                                        UserList[actualUserId].USD = /*UserList[actualUserId].USD */- Trans.TrasAmount;
                                        UserList[x].USD = /*UserList[x].USD*/ + Trans.TrasAmount;
                                        

                                        TransList.Add(Trans);
                                        Console.WriteLine("your transaction was done succesfuly");
                                       
                                    }
                                }





                            }
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Create your User now !!!");
                    Console.WriteLine("Introduce your Username");
                    Us.Unsername = Console.ReadLine();
                    Console.WriteLine("Introduce your Passwort");
                    Us.PassWort = Console.ReadLine();
                    Console.WriteLine("Introduce how mutch mony you will deposti to your balance");
                    Us.USD = Convert.ToInt32(Console.ReadLine());
                    Us.BankNumber = rand.Next();
                    UserList.Add(Us);
                    Console.WriteLine("Your user is created. Please Login");

                }


            }

        }


        }


    }
