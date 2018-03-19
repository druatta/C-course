using System;

namespace Question2
{
    class Program
    {
        static Library TestLibrary = new Library();
        static void Main(string[] args)
        {
            CheckOutAndCheckInATestAudioBook();
            PauseTheConsole();
        }

        public static void CheckOutAndCheckInATestAudioBook()
        {
            TestLibrary.TestAudioBook.CheckOut(TestLibrary.Daniel);
            Console.WriteLine("Length of this audiobook is " + TestLibrary.TestAudioBook.getHMS());
            TestLibrary.TestAudioBook.CheckIn();
        }

        public static void CheckOutAndCheckInATestSong()
        {
            TestLibrary.TestSong.CheckOut(TestLibrary.Daniel);
        }
        

        public static void PauseTheConsole()
        {
            Console.Read();
        }
    }
}
