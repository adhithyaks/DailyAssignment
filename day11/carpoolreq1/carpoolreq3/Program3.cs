using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpoolreq3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) valid car registration number");
            Console.WriteLine("2) convert car registration number");
            Console.WriteLine("valid driving license");
            Console.WriteLine("enter choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter car registration number:");
                    string carRegNumber = Console.ReadLine();
                    if (IsValidCarRegistrationNumber(carRegNumber))
                        Console.WriteLine(carRegNumber + "is Valid");
                    else
                        Console.WriteLine(carRegNumber + "is Invalid");
                    break;

                case 2:
                    Console.WriteLine("enter car registration number:");
                    string carRegNumberToConvert = Console.ReadLine();
                    string convertedCarRegNumber = ConvertCarRegistrationNumber(carRegNumberToConvert);
                    Console.WriteLine(convertedCarRegNumber);
                    break;
                case 3:
                    Console.WriteLine("enter driving license issue date (dd-MM-YYYY:");
                    DateTime issueDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-YYYY", null);
                    if (IsValidDrivingLicense(issueDate))
                        Console.WriteLine((DateTime.Now.Year - issueDate.Year) + "years old license - expired");
                    else
                        Console.WriteLine((DateTime.Now.Year - issueDate.Year) + "years old license - valid ");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        static bool IsValidCarRegistrationNumber(string carRegNumber)
        {
            string pattern = @"^[A-Z]{2}-\d{2}-[A-Z]{2}-\d{4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(carRegNumber,pattern);
        }
        static string ConvertCarRegistrationNumber(string carRegNumber)
        {
            return carRegNumber.Replace('@', '-').Replace('*', '-').ToUpper();
        }

        static bool IsValidDrivingLicense(DateTime issueDate)
        {
            DateTime currentDate  = DateTime.Now;
            DateTime expiryDate = issueDate.AddYears(10);
            return currentDate > expiryDate;
        }



    }

        }


