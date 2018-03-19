namespace Question2
{
    public class Library
    {
        public Borrower Daniel = new Borrower("Daniel", "Daniel's password");

        public AudioBook TestAudioBook = new AudioBook(2233445566, 2005, "This is audio book 1",
            DigitalDisc.DiscType.DVD, 7200);
       
        public Movie TestMovie = new Movie(2008, "This is movie 1", DigitalDisc.DiscType.BlueRay, 7200);

        public Song TestSong = new Song(2001, "This is music 1", DigitalDisc.DiscType.CD, 3000);

        public Library()
        {

        }
    }
}
