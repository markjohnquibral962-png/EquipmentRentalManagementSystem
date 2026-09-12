using System;

namespace EquipmentRentalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Equipment Rental Management System");

            Console.WriteLine("Enter 1 - for Admin Login");
            Console.WriteLine("Enter 2 - for Customer Login");
            Console.WriteLine("Enter x - to exit");

            Console.Write("User Input: ");

            string adminUsername = "admin";
            string adminPassword = "1234";

            string customerNumber = "2026-001";
            string customerName = "Mark";

            string equipmentName = "Projector";
            int availableEquipment = 5;
            int rentalPrice = 500;

            string checkLogin = Console.ReadLine();

            while (checkLogin != "x")
            {
                if (checkLogin == "1")
                {
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();

                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();

                    if (username == adminUsername && password == adminPassword)
                    {
                        Console.WriteLine("\nWelcome Admin!");

                        Console.WriteLine("Type 1 - to view equipment");
                        Console.WriteLine("Type 2 - to add equipment");
                        Console.WriteLine("Type 3 - to exit");

                        Console.Write("Enter your option: ");
                        int choice = Convert.ToInt16(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("\nEquipment: " + equipmentName);
                                Console.WriteLine("Available: " + availableEquipment);
                                Console.WriteLine("Rental Price: PHP " + rentalPrice);
                                break;

                            case 2:
                                Console.Write("Enter additional equipment quantity: ");
                                int additionalEquipment =
                                    Convert.ToInt16(Console.ReadLine());

                                availableEquipment += additionalEquipment;

                                Console.WriteLine(
                                    "Equipment added successfully!"
                                );
                                break;

                            case 3:
                                Console.WriteLine("Admin logged out.");
                                break;

                            default:
                                Console.WriteLine("Incorrect input...");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid username or password.");
                    }
                }

                else if (checkLogin == "2")
                {
                    Console.Write("Enter customer number: ");
                    string userInput = Console.ReadLine();

                    if (userInput == customerNumber)
                    {
                        Console.WriteLine("\nWelcome " + customerName + "!");

                        Console.WriteLine("Type 1 - to view equipment");
                        Console.WriteLine("Type 2 - to rent equipment");
                        Console.WriteLine("Type 3 - to exit");

                        Console.Write("Enter your option: ");
                        int choice = Convert.ToInt16(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("\nEquipment: " + equipmentName);
                                Console.WriteLine("Available: " + availableEquipment);
                                Console.WriteLine(
                                    "Rental Price per day: PHP " + rentalPrice
                                );
                                break;

                            case 2:
                                Console.Write(
                                    "Enter number of days to rent: "
                                );
                                int days = Convert.ToInt16(
                                    Console.ReadLine()
                                );

                                if (availableEquipment > 0)
                                {
                                    int total = rentalPrice * days;

                                    availableEquipment--;

                                    Console.WriteLine("\nRental successful!");
                                    Console.WriteLine(
                                        "Equipment: " + equipmentName
                                    );
                                    Console.WriteLine(
                                        "Number of days: " + days
                                    );
                                    Console.WriteLine(
                                        "Total rental fee: PHP " + total
                                    );
                                    Console.WriteLine(
                                        "Remaining equipment: "
                                        + availableEquipment
                                    );
                                }
                                else
                                {
                                    Console.WriteLine(
                                        "Equipment is currently unavailable."
                                    );
                                }

                                break;

                            case 3:
                                Console.WriteLine("Customer logged out.");
                                break;

                            default:
                                Console.WriteLine("Incorrect input...");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid customer number.");
                    }
                }

                else
                {
                    Console.WriteLine("Incorrect input...");
                }

                Console.WriteLine("\nEnter 1 - for Admin Login");
                Console.WriteLine("Enter 2 - for Customer Login");
                Console.WriteLine("Enter x - to exit");

                Console.Write("User Input: ");
                checkLogin = Console.ReadLine();
            }

            Console.WriteLine("Thank you for using Equipment Rental Management System");
        }
    }
}