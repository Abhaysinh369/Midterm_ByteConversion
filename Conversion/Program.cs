using Midterm_ByteConversion;
using System;

namespace Conversion
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            start();
        }
        public static void start()
        {
            bool shouldRepeat = true;
            string schoice;
            Console.WriteLine("Hello Users How are You?!");
            Console.WriteLine("Lets Start...");
            bool invalid = true;

            int inputu1 =0;

            Console.WriteLine("This program converts Storage Sizes between Bytes and Megabytes,Gigabytes and Terabytes .\n");
            Console.WriteLine("Which do you want to convert:");
            Console.WriteLine("Enter an integer Number:");
            while (invalid)
            {
                string sinputu = Console.ReadLine();
                if(int.TryParse(sinputu,out int inputu ))
                {
                     inputu1 = inputu;
                    invalid = false;
                }
                else
                {
                    Console.WriteLine("Please Enter valid integer value:");
                    invalid = true;

                }
            }
            


            while (shouldRepeat)
            {
                Console.WriteLine("0. Start");
                Console.WriteLine("1. Megabytes to Bytes");
                Console.WriteLine("2. Gigabytes to Megabytes\n");
                Console.WriteLine("3. Terabytes to Gigabytes\n");
                Console.WriteLine("4. Exit\n");
                Console.Write("Enter your Choitce:");
                schoice = Console.ReadLine();
                var isNumeric = int.TryParse(schoice, out _);
                if (isNumeric == true)
                {
                    switch (schoice)
                    {
                        case "0":
                            start();
                            break;
                        case "1":
                            ByteConversion.ConvertMegabytestoBytes(inputu1);
                            
                            break;
                        case "2":
                            ByteConversion.ConvertGigabytestoMegaBytes(inputu1);
                            
                            break;
                        case "3":
                            ByteConversion.ConvertTerabytestoGigaBytes(inputu1);
                            
                            break;
                        case "4":
                            shouldRepeat = false;
                            isNumeric = false;
                            break;
                    }
                }
            }
        }
    }
}
