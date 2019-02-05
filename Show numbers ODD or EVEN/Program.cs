namespace Show_numbers_ODD_or_EVEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int enternumberInt, resultInt;
            string selectoptionString,numberString;

            System.Console.WriteLine
                ("          ======================SHOW NUMBERS OOD OR EVEN======================");

            System.Console.WriteLine();

            do
            {

                System.Console.Write
                ("Please specify the end of the numbers: ");

                numberString =System.Console.ReadLine();                

                if (numberString=="0" || numberString=="")
                {

                    break;  

                }

                enternumberInt = int.Parse(numberString);

                System.Console.WriteLine();

                System.Console.Write
                    ("Please specify the [ODD] or [EVEN] numbers: ");

                selectoptionString = System.Console.ReadLine().ToString();

                System.Console.WriteLine();

                if (selectoptionString == "ODD" || selectoptionString == "odd" ||
                    selectoptionString == "Odd" || selectoptionString == "oDD")
                {

                    System.Console.WriteLine
                        ("ODD Numbers Is:");

                    System.Console.WriteLine();

                    for (int i = 1; i < enternumberInt; i++)
                    {
                        resultInt = i % 2;

                        if (resultInt == 1)
                        {
                            System.Console.WriteLine
                                ("Number: " + i);

                            System.Console.WriteLine();

                        }

                    }

                }
                else if (selectoptionString == "EVEN" ||
                    selectoptionString == "even" ||
                    selectoptionString == "Even" ||
                    selectoptionString == "eVEN")
                {

                    System.Console.WriteLine
                        ("EVEN Numbers Is:");

                    System.Console.WriteLine();

                    for (int i = 1; i < enternumberInt; i++)
                    {

                        resultInt = i % 2;

                        if (resultInt == 0)
                        {

                            System.Console.WriteLine
                                ("Number: " + i);

                            System.Console.WriteLine();

                        }
                    }

                }

                else
                {

                    System.Console.WriteLine
                        ("Out of range. Please try again...! ");

                }

            } while (true);

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.Write("Please [ENTER] To EXIT... ");
            System.Console.Read();
        }
    }
}
