namespace Funktioner
{
    internal class Program
    {
        // Deklarerar en global variabel
        static string carColor;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Anropa MyFunction
            MyFunction();
            MyFunction();

            //Anropa OneOrTwo med ett parameter värde
            int x = 2;
            OneOrTwo(1);
            OneOrTwo(2);
            OneOrTwo(x);
            OneOrTwo(3);

            //Anropar funktionen SayHey och sparar returvärdet i variabel
            string meddelande = SayHey("Marcus");
            Console.WriteLine(meddelande);

            Console.WriteLine( SayHey("Anders") );

            //Global vairabel carColor
            Console.WriteLine("Min bil har färgen {0}", carColor);
            Car();
            Console.WriteLine("Min bil har färgen {0}", carColor);
        }

        //Skapa en ny function som heter myFunction
        static void MyFunction()
        {
            Console.WriteLine("Inuti en Funktion");
        }

        //Skapa funktionen OneOrTwo som tar in ett parameter värde
        static void OneOrTwo(int input)
        {
            if (input == 1)
            {
                Console.WriteLine("Input är 1");
            } else if (input == 2)
            {
                Console.WriteLine("Input är 2");
            }
        }

        //Skapa en funktion som returnerar ett hälsningsmeddelande
        static string SayHey(string name)
        {
            string message = "Hejsan " + name;
            return message;
        }

        static void Car()
        {
            carColor = "Röd";
        }
    }
}