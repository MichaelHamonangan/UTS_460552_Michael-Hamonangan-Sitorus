using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTS_460552
{
    class Movie
    {
        internal string movieName;
        internal int duration;
        internal double timeStart;
        internal double hourStart, minuteStart, hourEnd, minuteEnd;
        internal int moviePrice;

        protected string movieDetail;
        public string MovieDetail { get => movieDetail; set => movieDetail = value; }

        protected Seats movieSeat;
        internal MoviePrice harga;

        public Movie(string name, int duration, double time, int price)
        {
            movieName = name;
            this.duration = duration;
            movieSeat = new Seats();
            moviePrice = price;

            timeStart = time % 24;

            harga = new MoviePrice(price);
        }

        public void ShowMovieDetail()
        {
            int hour = 0, minutes = 0;
            if (duration >= 60)
            {
                hour = duration / 60;
                minutes = duration % 60;
            }

            ConvertTime(hour, minutes);

            Console.WriteLine("\nFilm {0} berdurasi {1} Jam {2} Menit\nDetail : {3} waktu mulai pukul {4}.{5}\nHarga : {6} rupiah", movieName, hour, minutes, movieDetail, hourStart, minuteStart, moviePrice);
        }

        public void ConvertTime(double hour, double minutes)
        {
            minuteStart = (timeStart % 1) * 60;
            hourStart = timeStart - (minuteStart / 60);

            minuteEnd = minuteStart + minutes;
            hourEnd = hourStart + hour;
        }

        public string ShowForm()
        {
            Console.Write("\nBerapa banyak tiket yang ingin dipesan?\nJumlah Tiket : ");
            int NOticket = Convert.ToInt32(Console.ReadLine());
            string letak = "";
            bool isValid = true;
            if (NOticket < 1)
            {
                Console.WriteLine("Error! Input tidak boleh kurang dari 1");
                isValid = false;
            }

            movieSeat.printAvailableSeats();

            if (NOticket == 1)
            {
                Console.Write("Pilih posisi tempat duduk \nPosisi : ");
                letak = Console.ReadLine();

                isValid = movieSeat.Reserve(letak);
            }
            else if (NOticket > 1)
            {
                Console.Write("Pilih posisi tempat duduk (pisahkan satu sama lain dengan spasi (ex: 11 23 34)\nPosisi : ");
                letak = Console.ReadLine();

                isValid = movieSeat.Reserve(letak, NOticket);
            }

            harga.totalPrices(NOticket);
            if (isValid == true)
            {
                return letak;
            }
            else
            {
                return "";
            }
        }
    }
}
