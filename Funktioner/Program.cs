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

            Console.WriteLine(SayHey("Anders"));

            //Global vairabel carColor
            Console.WriteLine("Min bil har färgen {0}", carColor);
            Car();
            Console.WriteLine("Min bil har färgen {0}", carColor);

            //Funktion för att summera 2 st tal
            int summa = Add(3, 7);
            summa += Add(x);
            summa += Add();
            Console.WriteLine(summa);

            // En metod returnerar ett värde som parameter till en annan metod
            Console.WriteLine("Dagens {1} meddelanden är: {0}", SayHey("Jacob"), Add(3, 5));

            //Anrop till BiggestNumber med funktion som parameter
            summa = BiggestNumber(3, BiggestNumber(5, Add(2, 2)));
            Console.WriteLine($"Största nummret är {summa}");

            //Anropar MyFunc1
            Console.WriteLine(MyFunc1(summa));
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
            }
            else if (input == 2)
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

        //Funktion för att tilldela värde till global vairabel
        static void Car()
        {
            carColor = "Röd";
        }

        //Funktion för att returnera summa av 2 parametrar
        static int Add(int tal1 = 0, int tal2 = 0)
        {
            return tal1 + tal2;
        }

        //Funktion BiggestNumber, returnerar det största nummret
        static int BiggestNumber(int tal1, int tal2)
        {
            //If sats för att returnera största nummret
            if (tal1 > tal2) return tal1;
            else return tal2;

            //Kod som är omöjlig att nå
            return tal1;
        }

        //2st Funktioner som anropar varandra
        static int MyFunc1(int value)
        {
            int x = MyFunc2(value);
            return x;

            // return MyFunc2(value);
        }
        static int MyFunc2(int value)
        {
            return value * 2;
        }
    }
}