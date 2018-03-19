using System;

namespace Question2
{
    public class AudioBook : Book, IDigital
    {
        private DigitalDisc.DiscType mediaType;

        DigitalDisc.DiscType IDigital.MediaType
        {
            get { return mediaType; }
            set { mediaType = value; }
        }

        public TimeSpan LengthInSecondsAsATimeSpan;
        public string getHMS()
        {
            LengthInSecondsAsATimeSpan = TimeSpan.FromSeconds(lengthInSeconds);
            return LengthInSecondsAsATimeSpan.ToString();
        }


        private uint lengthInSeconds;

        public uint LengthInSeconds
        {
            get { return lengthInSeconds; }
            set { lengthInSeconds = value; }
        }

        public AudioBook()
                    : base()
        {
            lengthInSeconds = 0;
            mediaType = DigitalDisc.DiscType.CD;
        }

        public AudioBook(uint myISBN, ushort myYear, string myTitle, DigitalDisc.DiscType disc, uint sec)
                    : base(myISBN, myYear, 0, myTitle)
        {
            mediaType = disc;
            lengthInSeconds = sec;
        }
    }
}
