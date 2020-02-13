using System;
using System.Collections.Generic;
using System.Text;

namespace MTRSerial.Enumerations
{
    public class CommandsToMTR
    {
        public enum CommandName
        {
            //Will make the MTR to send a Status-message
            Status,
            //Spool all data in MTR2. No Polling will be done!
            Spool,
            // Spool Binary. Spool all data from package# xxxx (LSB) and to on
            SpoolBinary,
            //New session
            NewSession,
            //Get message binary.
            //Will send a single data-message from history. The MTR will continue "polling" for ECards during
            //data sending, with short dealy for receipt.Least significant byte first.
            GetMessageBinary,
            //Set Clock
            SetClock,
            //Clear Ringbuffer. Will clear all history (and reset package counters!)
            ClearRingbuffer
        }
    }
}
