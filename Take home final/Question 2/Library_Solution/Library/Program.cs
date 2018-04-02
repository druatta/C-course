using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Library TestLibrary = new Library();
            TestLibrary.Song.CheckOut(TestLibrary.Daniel);
            TestLibrary.Song.CheckIn();
            TestLibrary.Movie.CheckOut(TestLibrary.Daniel);
            TestLibrary.Movie.CheckIn();
            TestLibrary.AudioBook.CheckOut(TestLibrary.Daniel);
            TestLibrary.AudioBook.CheckIn();
            PauseTheConsole();
        }
           
        public static void PauseTheConsole()
        {
            Console.Read();
        }

    }
}
