using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Journalen
{
    class Program
    {
        #region Fields
        //instantiating object
        Logic logic = new Logic();
        #endregion
        #region Main
        static void Main(string[] args)
        {
            Program p = new Program();
            p.UserInterface();
            
            Console.ReadKey();
        }
        #endregion
        #region Methods
        public void UserInterface()
        {
            Program p = new Program();
            //Creates int to store users choice
            int choice = 0;
            //looping so an user can use multiple services
            do
            {
                //Printing a menu for the user
                Console.Write("Chose a service:" + "\n\n1. Create Journal" + "\n2. Show journal" + "\n3. Exit" + "\n\nEnter your choice: ");
                //Catches if the user inserts anything else than a number
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You have to insert a number");
                }
                //Picking a case depending on what the user inputs
                switch (choice)
                {
                    case 1:
                        p.CreateJournal();
                        break;
                    case 2:
                        Console.WriteLine(p.ReadJournal());
                        logic.CalcuateAge();
                        p.HealthData();
                        break;
                }
                //Makes the user press any key to continue
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                //clears the console
                Console.Clear();
                //Countinues the loop if the user didnt insert 3
            } while (choice != 3);
        }
        public void CreateJournal()
        {
            Console.WriteLine("Insert name of the patient");
            string name = Console.ReadLine();
            Console.WriteLine("Insert cpr number");
            string cpr = (Console.ReadLine());
            Console.WriteLine("Insert adress");
            string adress = Console.ReadLine();
            Console.WriteLine("Insert preferred doctor");
            string prefDoctor = Console.ReadLine();
            Console.WriteLine("Insert phone number");
            string phone = Console.ReadLine();
            Console.WriteLine("Insert email");
            string email = Console.ReadLine();
            logic.CreateJournal(name, cpr, adress, prefDoctor, phone, email);
            Console.WriteLine(name + " has been added");
        }
        public string ReadJournal()
        {
            Console.WriteLine("Enter name of the person you want to find");
            string findName = Console.ReadLine();
            Console.Clear();
            return logic.ReadJournal(findName);
        }
        public void HealthData()
        {
            DateTime tidNu = DateTime.Now;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(tidNu + "\tDoctor: Bob");
            Console.WriteLine("\n\nOndt i halsen\n----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press p for previous page                                                                 Press n for next page");
            if (Console.ReadKey().Key == ConsoleKey.N)
            {

            }
        }
        #endregion
    }
}
