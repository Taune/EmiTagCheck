using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MTRSerial.ValueObjects
{
    public class MTRDataCheckPoint
    {
        //The following fields are repeated 50 times:
        //CodeN         1 ControlCode; unused positions have 0
        //TimeN         2 Time binary seconds.Least sign. first, Most sign. last; unused: 0
        //ASCII string  56 Various info depending on ECard - type; 20h when retr.from "history"(See ASCIIstring)
        //Checksum      1 Binary SUM(MOD 256) of all bytes including Preamble
        //NULL - Filler 1 Binary 0(to avoid potential 5 FF's. Making it easier to haunt PREAMBLE

        public int CodeN { get; set; }
        public int TimeN { get; set; }
        public int InfoField { get; set; }

        public MTRDataCheckPoint(int codeN, int timeN, int info)
        {
            CodeN = codeN;
            TimeN = timeN;
            InfoField = info;
        }
    }
}