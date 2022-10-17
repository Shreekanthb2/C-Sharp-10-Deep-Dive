using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_10_Deep_Dive.Source;

internal class RecordStructs
{
    // Record Structs
    readonly record struct Coordinates(double Latitude, double Longitude);

    public void Sample()
    {
        Coordinates vegas = new(36.1749700, -115.137200);
        Coordinates desert = vegas with { Longitude = -100 };
    }
}
