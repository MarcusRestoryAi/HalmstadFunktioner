namespace Funktioner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Anropa MyFunction
            MyFunction();
            MyFunction();

            //Anropa OneOrTwo med ett parameter värde
            OneOrTwo(1);
            OneOrTwo(2);
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
    }
}