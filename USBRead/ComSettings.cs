using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace MTRSerial.ValueObjects
{
    public static class ComSettingsMTR
    {
        public static int BaudRate { get; set; } = 9600;
        public static Parity Parity { get; set; } = Parity.None;
        public static int DataBits { get; set; } = 8;
        public static StopBits StopBits { get; set; } = StopBits.Two;
        public static Handshake hShake { get; set; } = Handshake.None;
    }

    public static class ComSettingsECU
    {
        public static int BaudRate { get; set; } = 115200;
        public static Parity Parity { get; set; } = Parity.None;
        public static int DataBits { get; set; } = 8;
        public static StopBits StopBits { get; set; } = StopBits.One;
        public static Handshake hShake { get; set; } = Handshake.None;
            //mySerialPort.ReadTimeout = 5000;
            //mySerialPort.WriteTimeout = 200;
    }


}
