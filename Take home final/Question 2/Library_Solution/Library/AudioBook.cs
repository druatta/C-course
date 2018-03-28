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

        public AudioBook(uint myISBN, ushort myYear, string myTitle, DigitalDisc.DiscType disc, uint sec)
                    : base(myISBN, myYear, 0, myTitle)
        {
            mediaType = disc;
            lengthInSeconds = sec;
        }

        public new void CheckOut(User NewUser)
        {
            if (isAvailable == true)
            {
                currentUser = NewUser;
                checkOutTime = DateTime.Now;
                isAvailable = false;
                isOnHold = false;
                Console.WriteLine(title + " is issued to " +
                    currentUser.UserName + " at " + checkOutTime
                    + " with length " + getHMS());
            }
            else
            {
                throw new InvalidOperationException(title + " is not available to check out");
            }
        }
    }
}
