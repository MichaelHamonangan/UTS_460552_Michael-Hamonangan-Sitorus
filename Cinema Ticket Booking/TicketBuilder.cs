using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace UTS_460552
{
    interface TicketBuilder
    {
        void TicketHeader(string path);
        void TicketBody(string path, string posisi);
        void TicketFooter(string path);

        void TicketBarcode(string path);
    }
}
