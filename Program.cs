using System.Xml.Schema;

namespace Topic_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double price;
            Console.WriteLine("Part 1");
            Console.WriteLine("Hello there, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! What is your age?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("So you're " + age + ", eh? That's not old at all! How much do you make, " + name + ".");
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine(price.ToString("C") + "! I hope that's per hour and not per year!!");


            Console.WriteLine("Press ENTER for Part 2");
            Console.ReadLine();
            string firstName, lastName, login;
            int grade, studentID;
            double average;

            Console.Clear();
            Console.WriteLine("Part 2");
            Console.WriteLine("Please enter the following information so I can sell it for a profit. :)");
            Console.Write("First name: ");
            firstName = Console.ReadLine();
            Console.Write("Last name: ");
            lastName = Console.ReadLine();
            Console.Write("Grade (9-12): ");
            Int32.TryParse(Console.ReadLine(), out grade);
            Console.Write("Student ID: ");
            Int32.TryParse(Console.ReadLine(), out studentID);
            Console.Write("Login: ");
            login = Console.ReadLine();
            Console.Write("Average: ");
            Double.TryParse(Console.ReadLine(), out average);
            Console.WriteLine("Your information:");
            Console.WriteLine("Login:\t\t" + login);
            Console.WriteLine("Student ID:\t" + studentID);
            Console.WriteLine("Name:\t\t" + lastName + ", " + firstName);
            Console.WriteLine("Average:\t" + average + "%");
            Console.WriteLine("Grade:\t\t" + grade);
            Console.WriteLine();


            Console.WriteLine("Press ENTER for Part 3");
            Console.ReadLine();
            string myName;
            int myAge;

            Console.Clear();
            Console.WriteLine("Part 3");
            Console.Write("Hello. What is your name? ");
            myName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Hello " + myName + "! How old are you? ");
            Int32.TryParse(Console.ReadLine(), out myAge);
            Console.WriteLine();
            Console.WriteLine("Did you know that in 5 years, you will be " + (myAge + 5) + "?");
            Console.WriteLine("And five years ago you were " + myAge + "! Imagine that!");
            Console.WriteLine();


            Console.WriteLine("Press ENTER for Part 4");
            Console.ReadLine();
            double numberOne, numberTwo, numberThree;

            Console.Clear();
            Console.WriteLine("Part 4");
            Console.WriteLine("Please enter 3 numbers below:");
            Console.Write("First Number: ");
            Double.TryParse(Console.ReadLine(), out numberOne);
            Console.Write("Second Number: ");
            Double.TryParse(Console.ReadLine(), out numberTwo);
            Console.Write("Third Number: ");
            Double.TryParse(Console.ReadLine(), out numberThree);
            Console.WriteLine(numberOne + " and " + numberTwo + " and " + numberThree + " divided by two equals " + (numberOne + numberTwo + numberThree) / 2);
            Console.WriteLine();


            Console.WriteLine("Press ENTER for Part 5!");
            Console.ReadLine();
            string itemNameOne, itemNameTwo;
            double itemPriceOne, itemPriceTwo, total, subtotal, tax, discount;

            Console.Clear();
            Console.WriteLine("Part 5");
            Console.Write("What item did you order today? ");
            itemNameOne = Console.ReadLine();
            Console.Write("How much was it? ");
            Double.TryParse(Console.ReadLine(), out itemPriceOne);
            Console.Write("What other item did you order today? ");
            itemNameTwo = Console.ReadLine();
            Console.Write("How much did that item cost? ");
            Double.TryParse(Console.ReadLine(), out itemPriceTwo);

            Console.WriteLine();
            Console.WriteLine("Sales Receipt");
            Console.WriteLine();
            Console.WriteLine("Item 1: " + itemNameOne);
            Console.WriteLine("Price: " + Math.Round(itemPriceOne, 2).ToString("C"));
            Console.WriteLine("Item 2: " + itemNameTwo);
            Console.WriteLine("Price: " + Math.Round(itemPriceTwo, 2).ToString("C"));
            Console.WriteLine("=====================");
            total = itemPriceOne + itemPriceTwo;
            Console.WriteLine("Total: " + Math.Round(total, 2).ToString("C"));

            discount = total * 0.2;
            subtotal = total - discount;
            tax = subtotal * 0.13;

            Console.WriteLine("Discount (20%): " + Math.Round(discount, 2).ToString("C"));
            Console.WriteLine("Subtotal: " + Math.Round(subtotal, 2).ToString("C"));
            Console.WriteLine("Tax (13%): " + Math.Round(tax, 2).ToString("C"));
            Console.WriteLine("=====================");
            Console.WriteLine("Total Owed: " + Math.Round((subtotal + tax), 2).ToString("C"));
        }
    }
}