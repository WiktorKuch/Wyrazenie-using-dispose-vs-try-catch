using WyrażenieUsing;

namespace WyrazenieUsing{

    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "C:\\Users\\Wiktro Kucharek\append\fileUsing.txt";
            var fileContent = File.ReadAllLines(filePath);

            using(var someClass = new SomeClass())
            {
                someClass.Say("Hi");
            }




            using (var readFileStream = new FileStream(filePath, FileMode.Open)) // do zmiennej przypisujemy stworzony obiekt 
            {                                                                     //a do jego konstruktora ścieżke oraz tryb otwarcia
                                                                                  // using zastępuje blok try catch oraz throw new Exception()  
              //readFileStream.Read();                                          // blok using mozemy wykorzystać dla każdej klasy która implementuje 
                                                                                  // interface IDisposable- tam metoda void Dispose() - zwalnia zasoby

            }




            var writeFileStream = new FileStream(filePath, FileMode.Open);
            try
            {
                // writeFileStream.Write();
            }
            finally
            {
                ((IDisposable)writeFileStream).Dispose();
            }


            writeFileStream.Close();

        }
    }

}