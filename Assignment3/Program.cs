using System;

namespace Assignment3
{
    class Program
    {
        #region Hidden

        public static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-10) for the question to run or 0 to exit: ");
                number = Console.ReadLine();
                ShowTitle(number);

                switch (number)
                {
                    case "1":
                        Question1();
                        break;
                    case "2":
                        Question2();
                        break;
                    case "3":
                        Question3();
                        break;
                    case "4":
                        Question4();
                        break;
                    case "5":
                        Question5();
                        break;
                    case "6":
                        Question6();
                        break;
                    case "7":
                        Question7();
                        break;
                    case "8":
                        Question8();
                        break;
                    case "9":
                        Question9();
                        break;
                    case "10":
                        Question10();
                        break;
                }
            } while (number != "0");
        }

        public static void ShowTitle(string number)
        {
            Console.Clear();
            Console.WriteLine("Question {0}", number);
            Console.WriteLine("------------");
            Console.WriteLine();
        }

        #endregion

        /// <summary>
        /// Write code that prompts the user for a menu choice.
        /// The program will display a message based on the following:
        ///   Choice            Message
        ///   1                 "Calculate area"
        ///   2                 "Calculate volume"
        ///   3                 "Calculate surface area"
        ///   4                 "Exit the program"
        ///   any other input   "ERROR: Invalid choice"
        /// </summary>
        public static void Question1()
        {
            string menuChoice;
            Console.Write("Enter the menu choice (1-4): ");
            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    Console.WriteLine("Calculate area");
                    break;
                case "2":
                    Console.WriteLine("Calculate volume");
                    break;
                case "3":
                    Console.WriteLine("Calculate surface area");
                    break;
                case "4":
                    Console.WriteLine("Exit the program");
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid Choice");
                    break;
            }

        }

        /// <summary>
        /// Write code that allows the user to enter two integers and a character.
        /// If the character is 'A', then add the two integers.
        /// If the character is 'S', then subtract the second integer from the first.
        /// Otherwise, multiply the integers.
        /// Display the results of the arithmetic.
        /// </summary>
        public static void Question2()
        {
            string character;
            int result;

            Console.WriteLine("Enter the first integer: ");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the second integer: ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the Character(A-To add/ S-To subtract): ");
            character = Console.ReadLine().ToUpper();

            switch (character)
            {
                case "A":
                    result = a + b;
                    Console.WriteLine("The result of calculation is:"+result);
                    break;
                case "S":
                    result = a - b;
                    Console.WriteLine("The result of calculation is:" + result);
                    break;

                default:
                    Console.WriteLine("ERROR: Invalid Character from the choices(A/S)");
                    break;
            }

        }

        /// <summary>
        /// Write code that prompts the user for the number of courses and residency status
        /// (domestic or international) and calculates tuition cost. Cost is calculated based on the
        /// folowing:
        ///     Domestic        $325 per course
        ///     International   $1375 per course
        /// You decide how you want the user to enter their residency status and prompt accordingly.
        /// You must use named constants for the cost per course.
        /// Display the total cost.
        /// </summary>
        public static void Question3()
        {
            string residencyStatus;
            int tutionCost;
            int Domestic = 325;
            int International = 1375;

            Console.WriteLine("Enter the number of Courses: ");
            int courses = Convert.ToInt16(Console.ReadLine());

          
            Console.WriteLine("Enter the residence status(D- Domestic/ I- International): ");
            residencyStatus = Console.ReadLine().ToUpper();

            switch (residencyStatus)
            {
                case "D":
                    tutionCost= Domestic * courses;
                    Console.WriteLine("The result of calculation is:" + tutionCost);
                    break;
                case "I":
                    tutionCost = International * courses;
                    Console.WriteLine("The total tuition cost is:" + tutionCost);
                    break;

                default:
                    Console.WriteLine("ERROR: Invalid Residence Status.");
                    break;
            }

        }

        /// <summary>
        /// Write code that prompts the user for a day of the week. The program will display a 
        /// message based on the following:
        ///     Choice      Message
        ///     Sun         Home
        ///     Mon         Work
        ///     Tue         Work
        ///     Wed         Home
        ///     Thu         Work
        ///     Fri         Work
        ///     Sat         Work
        /// </summary>
        public static void Question4()
        {
            string Choice;
            Console.Write("Enter the day of the week (Sun, Mon, Tue, Wed, Thu. Fri, Sat): ");
            Choice = Console.ReadLine().ToUpper();

            switch (Choice)
            {
                case "SUN":
                    Console.WriteLine("Home");
                    break;
                case "MON":
                    Console.WriteLine("Work");
                    break;
                case "TUE":
                    Console.WriteLine("Work");
                    break;
                case "WED":
                    Console.WriteLine("Home");
                    break;
                case "THU":
                    Console.WriteLine("Work");
                    break;
                case "FRI":
                    Console.WriteLine("Work");
                    break;
                case "SAT":
                    Console.WriteLine("Work");
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid day of the week.");
                    break;
            }

        }

        /// <summary>
        /// Write code for a furniture company. Ask the user to choose Pine, Oak or Mahogany.
        /// Show the price of a table manufactured with the choosen wood. Pine tables cost $100, 
        /// Oak tables cost $125, and Mahogany tables cost $310. You must use named constants and
        /// a switch statement. You must accept any variation on the case (Eg. Pine, pine, PINE, piNe, etc
        /// </summary>
        public static void Question5()
        {
            string woodType;
            const int pine = 100;
            const int oak = 125;
            const int mahogany = 310;
            Console.Write("Enter the wood type of the table you want (Pine, Oak, Mahogany): ");
            woodType= Console.ReadLine().ToUpper();
            switch (woodType)
            {
                case "PINE":
                    Console.WriteLine("The price of a table manufuctured with Pine is : $"+pine);
                    break;
                case "OAK":
                    Console.WriteLine("The price of a table manufuctured with Oak is : $" + oak);
                    break;
                case "MAHOGANY":
                    Console.WriteLine("The price of a table manufuctured with Mahogany is : $" + mahogany);
                    break;
                
                default:
                    Console.WriteLine("ERROR: Invalid Wood type of the tables.");
                    break;
            }
        }

        /// <summary>
        /// Write code that prompts the user for an hourly pay rate. If the value entered is less than
        /// $5.65, display an error message
        /// </summary>
        public static void Question6()
        {
            Console.WriteLine("Enter the hourly pay rate: ");
            double hourlyPayRate= double.Parse(Console.ReadLine());

            if (hourlyPayRate < 5.65)
            {
                Console.WriteLine("ERROR : The value below minimum expected");
            }
        }

        /// <summary>
        /// Write code that prompt a user for an hourly pay rate. If the user enters a value less than
        /// $5.65 or greater than $49.99, prompt the user again. If the user enters an invalid value again,
        /// display an appropriate error message. If the user enters a valid value on either the first or
        /// second attempt, display the pay rate as well as the weekly rate which is calculated as 40 times 
        /// the hourly rate.
        /// </summary>
        public static void Question7()
        {
            int caseinfo = 1;
            Console.WriteLine("Please enter the hourly pay rate:");
            double HourlyPayRate = Convert.ToDouble(Console.ReadLine());
            double WeeklyRate = HourlyPayRate * 40;
            switch (caseinfo)
            {
                case 1:
                    {
                        if (HourlyPayRate < 5.65 || HourlyPayRate > 49.99)
                        {
                            Console.WriteLine("Please, try again: ");
                             HourlyPayRate = Convert.ToDouble(Console.ReadLine());
                            if (HourlyPayRate < 5.65 || HourlyPayRate > 49.99)
                            {
                                Console.WriteLine("Error! Invalid input.");
                            }
                            else
                            {
                                Console.WriteLine($"The hourly pay rate: " + HourlyPayRate + "\n Weekly rate of: " + WeeklyRate);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"The hourly pay rate: "+HourlyPayRate+"\n Weekly rate of: "+WeeklyRate);
                        }
                    }
                    break;

                default:

                    break;
            
            
        }
    }

        /// <summary>
        /// Write a program for a college's admissions office. The user enters a numeric high school grade
        /// point average (ex. 3.2) and an admission test score. Print the message "Accept" if the student
        /// meets either of the following requirements:
        ///     A grade point average of 3.0 or higher and an admission test score of at least 60
        ///     A grade point average of less than 3.0 and an admission test score of at least 80
        /// If the student does not meet either of the qualification criteria, print "Reject"
        /// </summary>
        public static void Question8()
        {
            double grade;
            double score;
            string criteriainfo;

            Console.WriteLine("Enter your numeric high school grade point average : ");
            grade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your admission test score");
            score = Convert.ToDouble(Console.ReadLine());
            if (grade >= 3.0 && score >= 60)
            {
                criteriainfo = "Accept";
            }
            else if (grade < 3.0 && score >= 80)
            {
                criteriainfo = "Accept";
            }
            else
            {
                criteriainfo = "Reject";
            }
            switch (criteriainfo)
            {
                case "Accept":
                    Console.WriteLine("Accept");
                    break;
                case "Reject":
                    Console.WriteLine("Reject");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        

        }

        /// <summary>
        /// Write code that prompts the uesr for an hourly pay rate and hours worked. Compute gross pay
        /// (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax).
        /// Withholding tax is computed as a percentage of gross pay based on the following:
        ///     Gross pay                       Withholding Percentage
        ///     Up to an including 300.00       10%
        ///     300.01 and up                   12%
        /// </summary>
        public static void Question9()
        {
            int payRate;
            int hour;
            Console.WriteLine("Enter hourly pay rate: ");
            payRate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hours worked: ");
            hour = int.Parse(Console.ReadLine());
        
            double grossPay = payRate * hour;

            double netPay;
            double withholdingTax;
            double withholdingParcentage;

            if (grossPay <= 300)
            {
                withholdingParcentage = .10;
            }
            else if (grossPay >= 300.01)
            {
                withholdingParcentage = .12;
            }
            else
            {
                withholdingParcentage = .0;
            }

            switch (withholdingParcentage)
            {
                case .10:
                    {
                        withholdingTax = (grossPay * withholdingParcentage);
                        netPay = grossPay - withholdingTax;
                        Console.WriteLine($"Your Grosspay "+ grossPay+"\n Withholdtax "+ withholdingTax+"\n Netpay "+netPay);
                }
                    break;
                case .12:
                    {
                        withholdingTax = grossPay * withholdingParcentage;
                        netPay = grossPay - withholdingTax;
                        Console.WriteLine($"Your Grosspay " + grossPay + "\n Withholdtax " + withholdingTax + "\n Netpay " + netPay);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Invalid");
                    }
                    break;
            }

        }

        /// <summary>
        /// Write code for a lawn-mowing service. The lawn-mowing season lasts 20 weeks. The weekly fee
        /// for mowing a lot under 400 square feet is $25. The fee for a lot that is 400 square feet or more,
        /// but under 600 square feet, is $35 per week. The fee for a lot that is 600 square feet or over is 
        /// $50 per week. Prompt the user for the length and width of a lawn, and then print the weekly
        /// mowing fee, as well as the total fee for the 20-week season.
        /// </summary>
        public static void Question10()
        {
            int Length, Width, SizeOfLawn, Weeks, Price;
            Weeks = 20;
            Price = 60;
            char LMH;
            int Cost;
         
            Console.WriteLine("Input the Length of the lawn :");
            Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Width of the lawn : ");
            Width = Convert.ToInt32(Console.ReadLine());
            SizeOfLawn = Length * Width;
            if (SizeOfLawn <= 400)
            {
                LMH = 'L';
            }
            else if (SizeOfLawn <= 600)
            {
                LMH = 'M';
            }
            else
            {
                LMH = 'H';
            }
            switch (LMH)
            {
                case 'L':
                    Price = 25;
                    break;
                case 'M':
                    Price = 35;
                    break;
                case 'H':
                    Price = 50;
                    break;
                default:
                    Price = 50;
                    break;
            }
            Cost = SizeOfLawn * Price * Weeks;
            Console.WriteLine("The Weekly Mowing fess is : " + Price);
            Console.WriteLine("The total cost for 20 weeks is " + Cost);

        }
    }
}
