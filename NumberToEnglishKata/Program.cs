using System;

namespace NumberToEnglishKata
{
    public class NumberToEnglish
    {
        public static string TripleDigit(double num)
        {
            if (num < 20)
            {
                return DoubleDigitTeens(num);
            }
            else if (num < 100)
            {
                return DoubleDigit(num);
            }
            string numAsString = num.ToString();
            string thirdDigit = numAsString.Substring(numAsString.Length - 3, 1);
            string secondDigit = numAsString.Substring(numAsString.Length - 2, 1);
            string firstDigit = numAsString.Substring(numAsString.Length - 1, 1);
            switch (thirdDigit)
            {
                case "1":
                    if (secondDigit != "0")
                    {
                        return "One Hundred " + DoubleDigit(num);
                    }
                    else if (firstDigit != "0")
                    {
                        return "One Hundred " + SingleDigit(num);
                    }
                    return "One Hundred";
                case "2":
                    if (secondDigit != "0")
                    {
                        return "Two Hundred " + DoubleDigit(num);
                    }
                    else if (firstDigit != "0")
                    {
                        return "Two Hundred " + SingleDigit(num);
                    }
                    return "Two Hundred";
                case "3":
                    if (secondDigit != "0")
                    {
                        return "Three Hundred " + DoubleDigit(num);
                    }
                    else if (firstDigit != "0")
                    {
                        return "Three Hundred " + SingleDigit(num);
                    }
                    return "Three Hundred";
                case "4":
                    if (secondDigit != "0")
                    {
                        return "Four Hundred " + DoubleDigit(num);
                    }
                    else if (firstDigit != "0")
                    {
                        return "Four Hundred " + SingleDigit(num);
                    }
                    return "Four Hundred";
                case "5":
                    if (secondDigit != "0")
                    {
                        return "Five Hundred " + DoubleDigit(num);
                    }
                    else if (firstDigit != "0")
                    {
                        return "Five Hundred " + SingleDigit(num);
                    }
                    return "Five Hundred";
                case "6":
                    if (secondDigit != "0")
                    {
                        return "Six Hundred " + DoubleDigit(num);
                    }
                    else if (firstDigit != "0")
                    {
                        return "Six Hundred " + SingleDigit(num);
                    }
                    return "Six Hundred";
                case "7":
                    if (secondDigit != "0")
                    {
                        return "Seven Hundred " + DoubleDigit(num);
                    }
                    else if (firstDigit != "0")
                    {
                        return "Seven Hundred " + SingleDigit(num);
                    }
                    return "Seven Hundred";
                case "8":
                    if (secondDigit != "0")
                    {
                        return "Eight Hundred " + DoubleDigit(num);
                    }
                    else if (firstDigit != "0")
                    {
                        return "Eight Hundred " + SingleDigit(num);
                    }
                    return "Eight Hundred";
                case "9":
                    if (secondDigit != "0")
                    {
                        return "Nine Hundred " + DoubleDigit(num);
                    }
                    else if (firstDigit != "0")
                    {
                        return "Nine Hundred " + SingleDigit(num);
                    }
                    return "Nine Hundred";
                default:
                    return null;
            }
        }
        public static string DoubleDigit(double num)
        {
            if (num < 10) // May be unnessessary, check if need to remove later
            {
                return SingleDigit(num);
            }
            if (num < 20)
            {
                return DoubleDigitTeens(num);
            }
            string numAsString = num.ToString();
            int numIndex2 = numAsString.Length - 2;
            int numIndex1 = numAsString.Length - 1;
            string secondDigit = numAsString.Substring(numIndex2, 1);
            string firstDigit = numAsString.Substring(numIndex1, 1);
            if (secondDigit == "1")
            {
                return DoubleDigitTeens(num);
            }
            switch (secondDigit)
            {
                case "2":
                    if (firstDigit == "0")
                    {
                        return "Twenty";
                    }
                        return "Twenty" + "-" + SingleDigit(num);
                case "3":
                    if (firstDigit == "0")
                    {
                        return "Thirty";
                    }
                    return "Thirty" + "-" + SingleDigit(num);
                case "4":
                    if (firstDigit == "0")
                    {
                        return "Fourty";
                    }
                    return "Fourty" + "-" + SingleDigit(num);
                case "5":
                    if (firstDigit == "0")
                    {
                        return "Fifty";
                    }
                    return "Fifty" + "-" + SingleDigit(num);
                case "6":
                    if (firstDigit == "0")
                    {
                        return "Sixty";
                    }
                    return "Sixty" + "-" + SingleDigit(num);
                case "7":
                    if (firstDigit == "0")
                    {
                        return "Seventy";
                    }
                    return "Seventy" + "-" + SingleDigit(num);
                case "8":
                    if (firstDigit == "0")
                    {
                        return "Eighty";
                    }
                    return "Eighty" + "-" + SingleDigit(num);
                case "9":
                    if (firstDigit == "0")
                    {
                        return "Ninty";
                    }
                    return "Ninty" + "-" + SingleDigit(num);
                default:
                    return null;
            }

        }
        public static string DoubleDigitTeens(double num)
        {
            if (num < 10) // May be unnessessary, check if need to remove later
            {
                return SingleDigit(num);
            }
            int numIndex = num.ToString().Length - 2;
            string numAsString = num.ToString();
            string num1 = numAsString.Substring(numIndex, 2);
            switch (num1)
            {
                case "10":
                    return "Ten";
                case "11":
                    return "Eleven";
                case "12":
                    return "Twelve";
                case "13":
                    return "Thirteen";
                case "14":
                    return "Fourteen";
                case "15":
                    return "Fifteen";
                case "16":
                    return "Sixteen";
                case "17":
                    return "Seventeen";
                case "18":
                    return "Eighteen";
                case "19":
                    return "Nineteen";
                default:
                    return null;
            }
        }

        public static string SingleDigit(double num)
        {
            int numIndex = num.ToString().Length - 1;
            string numAsString = num.ToString();
            string num1 = numAsString.Substring(numIndex, 1);
            if (num1 == "0" && num == 0)
            {
                return "Zero";
            }
            switch (num1)
            {
                case "0":
                    return "";
                case "1":
                    return "One";
                case "2":
                    return "Two";
                case "3":
                    return "Three";
                case "4":
                    return "Four";
                case "5":
                    return "Five";
                case "6":
                    return "Six";
                case "7":
                    return "Seven";
                case "8":
                    return "Eight";
                case "9":
                    return "Nine";
                default:
                    return null;
            }
        }
    }

    class Program
    {
        public static bool KeepGoing()
        {
            while (true)
            {
                Console.Write("Would you like to continue? (Y/N): ");
                string input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    return true;
                }
                else if (input == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("That is not valid input.");
                }
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("What number are you converting to English: ");
                double input = double.Parse(Console.ReadLine());
                Console.WriteLine(NumberToEnglish.TripleDigit(input));
            } while (KeepGoing());
        }
    }
}
