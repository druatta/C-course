namespace Question2
{
    public class Library
    {
        public Borrower Daniel = new Borrower("Daniel", "Daniel's password");

        public AudioBook AudioBook = new AudioBook(2233445566, 2005, "AudioBook1",
            DigitalDisc.DiscType.DVD, 7200);
       
        public Movie Movie = new Movie(2008, "Movie1", DigitalDisc.DiscType.BlueRay, 7200);

        public Song Song = new Song(2001, "Song1", DigitalDisc.DiscType.CD, 3000);

        public Library()
        {

        }
    }
}
