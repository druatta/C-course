using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question2
{
    interface Iloanable
    {
        User currentUser { get; set; }
        DateTime checkOutTime { get; set; }
        DateTime checkInTime { get; set; }
        bool isAvailable { get; set; }
        bool isOnHold { get; set; }

        void CheckOut(User u);
        void CheckIn();
        void holdIt(User u);
        void removeHolds();

    }
}
