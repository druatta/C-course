using System;

namespace Question2
{
    public class Song : Item, Iloanable, IDigital
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
            LengthInSecondsAsATimeSpan = TimeSpan.FromSeconds(lengthSeconds);
            return LengthInSecondsAsATimeSpan.ToString();
        }


        private uint lengthSeconds;

        public uint LengthInSeconds
        {
            get { return lengthSeconds; }
            set { lengthSeconds = value; }
        }


        public Song(ushort myYear, string myTitle, DigitalDisc.DiscType disc, uint sec)
            : base(myTitle, myYear)
        {
            mediaType = disc;
            lengthSeconds = sec;
            isAvailable = true;
            isOnHold = false;
        }


        #region Iloanable Members

        public User currentUser { get; set; }

        public DateTime checkOutTime { get; set; }

        public DateTime checkInTime { get; set; }

        public bool isAvailable { get; set; }

        public bool isOnHold { get; set; }

        public void CheckOut(User u)
        {
            if (isAvailable)
            {
                currentUser = u;
                checkOutTime = DateTime.Now;
                checkInTime = DateTime.MinValue;
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

        public void CheckIn()
        {
            if (!isAvailable)
            {
                checkInTime = DateTime.Now;
                Console.WriteLine(title + " is returned by " + currentUser.UserName + " at " + checkInTime);
                currentUser = null;
                isAvailable = true;
                isOnHold = false;
            }
            else
            {
                Console.WriteLine("This item is not checked-out yet");
            }
        }

        public void holdIt(User u)
        {
            if (isAvailable && !isOnHold)
            {
                currentUser = u;
                isAvailable = true;
                isOnHold = false;
                checkOutTime = DateTime.Now;
                Console.WriteLine(title + " is on hold for " + currentUser.UserName + " at " + checkOutTime);
            }
            else
            {
                Console.WriteLine("This item can not be put on hold");
            }
        }

        public void removeHolds()
        {
            if (!isAvailable && isOnHold)
            {
                currentUser = null;
                isAvailable = true;
                isOnHold = false;
                checkOutTime = DateTime.MaxValue;
                Console.WriteLine("Hold is removed");
            }
            else
            {
                Console.WriteLine("This item is not on hold");
            }
        }

        #endregion
    }
}
