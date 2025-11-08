using System;

// Ứng dụng hiển thị menu cho người dùng chọn hình để in ra console.
public class Program
{
     public static void Main(string[] args)
     {
          while (true)
          {
               Console.WriteLine("Menu");
               Console.WriteLine("1. Draw the triangle");
               Console.WriteLine("2. Draw the square");
               Console.WriteLine("3. Draw the rectangle");
               Console.WriteLine("0. Exit");
               Console.Write("Enter your choice: ");

                 string input = Console.ReadLine() ?? string.Empty;
               if (!int.TryParse(input, out int choice))
               {
                    Console.WriteLine("Invalid input. Please enter a number (0-3).\n");
                    continue;
               }

               switch (choice)
               {
                    case 1:
                         Console.WriteLine("Draw the triangle");
                         Console.WriteLine("******");
                         Console.WriteLine("*****");
                         Console.WriteLine("****");
                         Console.WriteLine("***");
                         Console.WriteLine("**");
                         Console.WriteLine("*");
                         break;
                    case 2:
                         Console.WriteLine("Draw the square");
                         Console.WriteLine("* * * * * *");
                         Console.WriteLine("* * * * * *");
                         Console.WriteLine("* * * * * *");
                         Console.WriteLine("* * * * * *");
                         Console.WriteLine("* * * * * *");
                         Console.WriteLine("* * * * * *");
                         break;
                    case 3:
                         Console.WriteLine("Draw the rectangle");
                         Console.WriteLine("* * * * * *");
                         Console.WriteLine("* * * * * *");
                         Console.WriteLine("* * * * * *");
                         break;
                    case 0:
                         Console.WriteLine("Exiting...");
                         return;
                    default:
                         Console.WriteLine("No choice! Please select 0-3.");
                         break;
               }

               Console.WriteLine();
          }
     }
}
