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
            TestLibrary.TestAudioBook1.CheckOut(TestLibrary.Daniel);
            Console.WriteLine("Length of this audiobook is " + TestLibrary.TestAudioBook1.getHMS());
            TestLibrary.TestAudioBook1.CheckIn();
        }

        public static void CheckOutAndCheckInATestSong()
        {
            TestLibrary.TestSong1.CheckOut(TestLibrary.Daniel);
        }
        

        public static void PauseTheConsole()
        {
            Console.Read();
        }
    }
}
