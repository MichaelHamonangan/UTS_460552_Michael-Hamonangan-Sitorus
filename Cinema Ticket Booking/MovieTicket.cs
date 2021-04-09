using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;


namespace UTS_460552
{
    class MovieTicket : Movie, TicketBuilder
    {
        protected custommer Subjek;
        public MovieTicket(string name, int duration, double time, int price, custommer subjek) : base(name, duration, time, price)
        {
            movieName = name;
            this.duration = duration;

            int hour = 0, minutes = 0;
            if (duration >= 60)
            {
                hour = duration / 60;
                minutes = duration % 60;
            }
            ConvertTime(hour, minutes);
            Subjek = subjek;
        }

        public void printTicket(string letak)
        {
            char[] separator = { ' ' };
            string[] temporary = letak.Split(separator);

            for (int i = 0; i < temporary.Length; i++)
            {
                string posisi = temporary[i];

                string Path = @"D:/Tiket " + movieName + " seat-" + Convert.ToString(posisi) + ".txt";
                TicketHeader(Path);
                TicketBody(Path, posisi);
                TicketFooter(Path);

                Console.Write("\nTiket telah dibuat dengan direktori {0}", Path);
            }
        }

        public void TicketHeader(string path)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("---------------CINEMA BOOKING E-Ticket--------------\n");
                }
            }
        }

        public void TicketFooter(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("------------------Enjoy your joy!!------------------");
            }
        }

        public void TicketBody(string path, string posisi)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("FILM : {0}", movieName);
                sw.WriteLine("\nStart : {0}.{1}          Seat : {2}", hourStart, minuteStart, posisi);
                sw.WriteLine("End   : {0}.{1}", hourEnd, minuteEnd);
                sw.WriteLine("\nReserved by : {0}\nemail       : {1} \n", Subjek.username, Subjek.email);
            }
        }

        public void TicketBarcode(string path) { }
    }
}
