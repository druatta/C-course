using System;

namespace Question2
{
    interface IDigital
    {
        uint LengthInSeconds { get; set; }
        DigitalDisc.DiscType MediaType { get; set; }

        string getHMS();
    }
}
