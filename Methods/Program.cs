namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metot
            //Add();

            //Parametreli metotlar
            //var result = Add2(20,30);
            //Console.WriteLine(result);


            //Default parametreli metotlar
            //var result2 = Add3(50);
            //Console.WriteLine(result2);


            //Ref Keyword
            int number1 = 20;
            int number2 = 100;
            var result3 = Add4(ref number1, number2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);


            //out Keyword
            int number3;
            int number4 = 200;
            var result4 = Add5(out number3, number4);
            Console.WriteLine(result4);
            Console.WriteLine(number3);


            //Method Overloading
            //Console.WriteLine(Multiply(2,4));
            //Console.WriteLine(Multiply(2,4,5));

            //params
            Console.WriteLine(Add6(1, 2, 3, 5, 4, 6, 8));
        }

        //Metot
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //Parametreli metotlar
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        //default parametreli metotlar
        static int Add3(int number1, int number2 = 30) //Tek bir default değer her zaman parametrenin sonuna yazılır
        {
            var result2 = number1 + number2;
            return result2;
        }

        //Ref Keyword
        static int Add4(ref int number1, int number2) //Metottan gönderilen değişkenin referansının kullanılmasını
                                                      //istiyorsak 'ref' keyword'ünün eklenmesi gerekir
        {
            number1 = 30;
            return number1 + number2;

        }

        //Out Keyword
        static int Add5(out int number3, int number4) //'out' için bir değişken değeri atamasına ihtiyaç yoktur.
                                                      //Fakat metot içinde değer atanması şarttır.
                                                      //(Metota göndermeden değer atansa bile)
        {
            number3 = 100;
            return number3 + number4;

        }

        //Method Overloading
        static int Multiply(int number1, int number2)
        { 
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add6(int number, params int[] numbers) //params'tan sonra parametre tanımlanamaz
        {
            return numbers.Sum() + number;
        }
    }
}
