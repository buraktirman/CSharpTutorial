namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Burak Tırman";
            var result = sentence.Length;
            Console.WriteLine(result);    

            var result2 = sentence.Clone(); // Clone() methodu ile string'i yeni bir referans numarası ile kopyalayabiliriz.
            sentence = "My name is Engin Demiroğ";
            Console.WriteLine(result2); // Clone() methodu ile kopyalanan string'in değeri değişse bile kopyalanan string'in değeri değişmez.

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("namee"); //Bulamazsa -1 döner.
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" "); //Aramaya sondan başlar.
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3, 4); //3. indexten başla 4 karakter al.
            //İkinci parametre verilmezse 3. indexten başlayarak sonuna kadar alır.
            var result10 = sentence.ToUpper();
            var result11 = sentence.ToLower();
            var result12 = sentence.Replace(" ", "-"); //Boşlukları - ile değiştir.
            var result13 = sentence.Remove(4, 3); //4. indexten başla 3 karakter sil.

            Console.WriteLine(result13);
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;
            //Console.WriteLine(result);

            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
