using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {







        static void Main(string[] args)
        {
           
           List<Transaction> TransList = new List<Transaction>();
           List<User> UserList = new List<User>();

            bool logedIn = false;
            User Us = new User();
            Transaction Trans = new Transaction();
            UserList.Add(new User { Unsername = "Master", PassWort = "123", USD = 0000, BankNumber = 57646099 });
            UserList.Add(new User { Unsername = "Emilio", PassWort = "123", USD = 2500, BankNumber = 12345 });
            UserList.Add(new User { Unsername = "Valentina", PassWort = "123", USD = 2500, BankNumber = 345678 });

            var rand = new Random();
            string actualUser = "";
            int actualUserAccount = 0;
         
            int actualUserMony = 0;
            int actualUserId;

            try { 
            for (int y = 0; y < 100; y++)
            {
                    
                    

                Console.WriteLine("Do yo have a User? Answer with yes / no");
                string answer = Console.ReadLine();

                if (answer.ToLower().Equals("yes"))
                {
                        
                        

                    Console.WriteLine("Introduce your Username");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Introduce your Passwort");
                    string passwort = Console.ReadLine();
                        //Check user list to verificate introduced pw and user
                    for (int i = 0; i < UserList.Count; i++)
                    {
                        if (userName == UserList[i].Unsername && passwort == UserList[i].PassWort)
                        {
                            actualUser = UserList[i].Unsername;
                            actualUserAccount = UserList[i].BankNumber;
                            actualUserMony = UserList[i].USD;
                            actualUserId = i;

                            logedIn = true;
                            Console.WriteLine($"Hello {actualUser}");
                            Console.WriteLine($"your balance is: {UserList[i].USD}");
                            Console.WriteLine($"your Account Number is: {actualUserAccount}");
                                //Acction to do in account
                            Console.WriteLine("Do you want to make a transaction? Pres 1 / Do you want see the transaction historial press 2 / To logout press 3");
                                if (actualUser.Equals("Master"))
                                {
                                    Console.WriteLine("Put mony on the account to transfere to user press 4 / See Total of mony in circulation press 5");
                                    int MasterOption = Convert.ToInt32(Console.ReadLine());
                                    if (MasterOption.Equals(4))
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

                                            if (Trans.RecivingUser == UserList[x].Unsername && Trans.AcountNoRU == UserList[x].BankNumber)
                                            { 
                                                UserList[x].USD = UserList[x].USD + Trans.TrasAmount;
                                                UserList[0].USD = UserList[0].USD + 1;



                                                TransList.Add(Trans);
                                                Console.WriteLine("your transaction was done succesfuly");
                                                Console.WriteLine($"your Balance is :  {UserList[actualUserId].USD}");
                                                Console.WriteLine($"From : {TransList[0].AcountNoPU} To : {TransList[0].AcountNoRU}  amount: {TransList[0].TrasAmount} Reference: {TransList[0].RefTrans}");
                                                Console.WriteLine($"Charge the person $ {Trans.TrasAmount + 1}");
                                                break;
                                            }
                                           
                                        }

                                        
                                    }
                                    if (MasterOption.Equals(5))
                                    {
                                        int TotalMony = 0;
                                        for (int z = 0; z < UserList.Count; z++)
                                        {
                                            TotalMony = TotalMony + UserList[z].USD;

                                           
                                              
                                            }
                                        Console.WriteLine(TotalMony);
                                        break;
                                    }
                                }
                            string trans = Console.ReadLine();
                               if (trans.Equals("1"))
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
                                            UserList[actualUserId].USD = UserList[actualUserId].USD - Trans.TrasAmount;
                                            UserList[x].USD = UserList[x].USD + Trans.TrasAmount;
                                            UserList[actualUserId].USD = UserList[actualUserId].USD - 1;
                                            UserList[0].USD = UserList[0].USD + 1;



                                            TransList.Add(Trans);
                                            Console.WriteLine("your transaction was done succesfuly");
                                            Console.WriteLine($"your Balance is :  {UserList[actualUserId].USD}");
                                            Console.WriteLine($"From : {TransList[0].AcountNoPU} To : {TransList[0].AcountNoRU}  amount: {TransList[0].TrasAmount} Reference: {TransList[0].RefTrans}");
                                            break;
                                        }
                                    }
                                        
                               }else if (trans.Equals("2")) 
                                {
                                    if (actualUser.Equals("Master"))
                                    {
                                        int TotalAmountInCirculation = 0;
                                        for (int g = 0; g < TransList.Count; g++)
                                        {
                                            Console.WriteLine($"From : {TransList[g].AcountNoPU} To : {TransList[g].AcountNoRU}  amount: {TransList[g].TrasAmount} Reference: {TransList[g].RefTrans}");
                                            TotalAmountInCirculation = + UserList[g].USD;
                                        }
                                        Console.WriteLine($"The total amount {TotalAmountInCirculation}");
                                        break;
                                    }
                                    else 
                                    {
                                        for (int g = 0; g < TransList.Count; g++)
                                        {
                                            if (actualUserAccount.Equals(TransList[g].AcountNoPU) || actualUserAccount.Equals(TransList[g].AcountNoRU))
                                            { Console.WriteLine($"From : {TransList[g].AcountNoPU} To : {TransList[g].AcountNoRU}  amount: {TransList[g].TrasAmount} Reference: {TransList[g].RefTrans}"); }
                                            break;
                                        }
                                    }
                                } else if (trans.Equals("3"))
                                {
                                    logedIn = false;
                                    break;
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
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        

        }


    }
