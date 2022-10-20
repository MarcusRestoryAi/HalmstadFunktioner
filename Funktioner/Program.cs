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
        }

        //Skapa en ny function som heter myFunction
        static void MyFunction()
        {
            Console.WriteLine("Inuti en Funktion");
        }


    }
}