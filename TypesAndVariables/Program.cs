namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Value Types

            //Integer Veri Tipi
            int number1 = 2147483647;  //* -2 147 483 648 milyar  değeri alabilir  // 10 karakter değeri alır  //32bitlik yer kaplar
            Console.WriteLine("Number 1 is {0}", number1);

            //Long Veri Tipi 
            long number2 = 2147483648;  // 19 karakter almaktadır //64bitlik yer kaplar
            Console.WriteLine("Number 2 is {0}", number2);

            //Short Veri Tipi
            short number3 = -32768; //16 bit yer kaplar
            Console.WriteLine("Number 3 is {0}", number3);

            //byte Veri Tipi
            byte number4 = 255; // 8 bit
            Console.WriteLine("Number 4 is {0}", number4);

            // Bool Veri Tipi
            bool condition = true; //true veya false olarak şartlı ifadelerde kullanılır.

            //Char Veri Tipi
            char character = 'A';
            Console.WriteLine("Character is : {0}", (int)character);


            // Double Veri Tipi
            double number5 = 10.1; //64 bitlik veri tutar // virgülden sonra 15-16 hane tutabilir
            Console.WriteLine("Number 5 is {0}", number5);


            //Decimal Veri Tipi
            decimal number6 = 10.1m;  // virgülden sonra 28-29 hane tutabilir
            Console.WriteLine("Number 6 is {0}", number6);

            //Enum Veri Tipi : indexlenmiş olarak enum sabitlerini tutar
            Console.WriteLine((int)Days.Friday);


            // Var   Değişken Tutma
            var number7 = 10; //var içine belirtilen değişken integer olarak tutulur
            number7 = 'A'; // char ataması ile karakter sayısal değerini belirtir
            //number7 = "A";  integer veriye string veri olarak tanımlanamayacağından hata alınır
            Console.WriteLine("Number 7 is {0}", number7);
        }
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
            //  Monday = 10, Tuesday = 20 olarak atanıp diğer günlere değer atanmazsa
            //  Wednesday = 21, Thursday = 22, Friday = 23, Saturday = 24
            //  olarak devam eder.
        }
    }
}
