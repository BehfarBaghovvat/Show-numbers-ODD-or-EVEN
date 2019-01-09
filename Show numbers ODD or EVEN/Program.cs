namespace Show_numbers_ODD_or_EVEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int EnterNumber, Odd, Even, Result;
            string SelectOption,Number;

            System.Console.WriteLine("          ======================SHOW NUMBERS OOD OR EVEN======================");

            System.Console.WriteLine();

            do
            {

                System.Console.Write
                ("Please specify the end of the numbers: ");

                Number =System.Console.ReadLine();                

                if (Number=="0" || Number=="")
                {

                    break;  

                }

                EnterNumber = int.Parse(Number);

                System.Console.WriteLine();

                System.Console.Write
                    ("Please specify the [ODD] or [EVEN] numbers: ");

                SelectOption = System.Console.ReadLine().ToString();

                System.Console.WriteLine();

                if (SelectOption == "ODD" || SelectOption == "odd" ||
                    SelectOption == "Odd" || SelectOption == "oDD")
                {

                    System.Console.WriteLine("ODD Numbers Is:");

                    System.Console.WriteLine();

                    for (int i = 1; i < EnterNumber; i++)
                    {
                        Result = i % 2;

                        if (Result == 1)
                        {
                            System.Console.WriteLine("Number: " + i);

                            System.Console.WriteLine();

                        }

                    }

                }
                else if (SelectOption == "EVEN" || SelectOption == "even" ||
                    SelectOption == "Even" || SelectOption == "eVEN")
                {

                    System.Console.WriteLine("EVEN Numbers Is:");

                    System.Console.WriteLine();

                    for (int i = 1; i < EnterNumber; i++)
                    {

                        Result = i % 2;

                        if (Result == 0)
                        {

                            System.Console.WriteLine("Number: " + i);

                            System.Console.WriteLine();

                        }

                    }

                }

                else
                {

                    System.Console.WriteLine("Out of range. Please try again...! ");

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
