using Project_Hotel.Controllers;
using Project_Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel.View
{
    public class MainView
    {
        private AccountController accountController = new AccountController();
        private ClientController clientController = new ClientController();

        public void initialInterface()
        {
            /* Base initial interface(Menu) */

            Console.WriteLine("\t1 - Show all Accounts");
            Console.WriteLine("\t2 - Get Account by ID");
            Console.WriteLine("\t3 - Get Account statistics");
            Console.WriteLine("\t4 - Create new Account");
            Console.WriteLine("\t5 - Update Account by ID");
            Console.WriteLine("\t6 - Delete Account by ID");

            int choice;
            do
            {
                Console.Write("\n\n\tEnter the number: ");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    showAllAccounts();
                }
                else if (choice == 2)
                {
                    getAccountById();
                }
                else if (choice == 3)
                {

                }
                else if (choice == 4)
                {
                    createNewAccount();
                }
                else if (choice == 5)
                {
                    updateAccount();
                }
                else if (choice == 6)
                {
                    deleteAccount();
                }

            } while (choice != 0);
        }

        public void showAllAccounts()
        {
            List<Client> client = clientController.getAllClients();

            client.ForEach(client => Console.WriteLine(
                $" Id {client.Id}," +
                $"Full Name {client.Full_Name}," +
                $"Age {client.Age}," +
                $"Room {client.Number_room}," +
                $"date of arrival {client.DateOfArrival}," +
                $" departure date {client.DepartureDate}," +
                $" payment {client.Payment}"));
        }

        public void getAccountById()
        {
            int id;
            Console.Write("\tEnter ID to find Account: ");
            id = Int32.Parse(Console.ReadLine());
            Client client = clientController.getClientById(id);
            Console.WriteLine($"  Account name: {client.Full_Name} \n" +
                $"  Account email: {client.Age} \n" +
                $"  Account password {client.Number_room} \n" +
                $"  Account password {client.DateOfArrival} \n" +
                $"  Account password {client.DepartureDate} \n" +
                $"  Account password {client.Payment}");
        }

        public void createNewAccount()
        {
            Console.Write("Enter Fullname: ");
            string Fullname = Console.ReadLine();

            Console.Write("Enter age: ");
            string Age = Console.ReadLine();

            Console.Write("Enter number_room: ");
            string number_room = Console.ReadLine();

            Console.Write("Enter date_of_arrival: ");
            string date_of_arrival = Console.ReadLine();

            Console.Write("Enter departure_date: ");
            string departure_date = Console.ReadLine();

            Console.Write("Enter  payment: ");
            string payment = Console.ReadLine();

            clientController.createNewClient(Fullname, Age, number_room, date_of_arrival, departure_date, payment);
        }

        public void updateAccount()
        {
            Console.Write("Enter ID to update Account: ");
            int id = Int32.Parse(Console.ReadLine());

            Console.Write("Fullname: ");
            string Fullname = Console.ReadLine();

            Console.Write("Age: ");
            string Age = Console.ReadLine();

            Console.Write("number_room: ");
            string number_room = Console.ReadLine();

            Console.Write("date_of_arrival: ");
            string date_of_arrival = Console.ReadLine();

            Console.Write("departure_date: ");
            string departure_date = Console.ReadLine();

            Console.Write("payment: ");
            string payment = Console.ReadLine();

            clientController.updateClient(id, Fullname, Age, number_room, date_of_arrival, departure_date, payment);
        }

        public void deleteAccount()
        {
            int id;

            Console.Write("Enter ID to delete Account: ");
            id = Int32.Parse(Console.ReadLine());

            clientController.deleteClient(id);
        }


    }
}
