using System;
using System.Collections.Generic;
using System.Text;

namespace UTS_460552
{
    class custommer : User
    {
        public string email;
        public custommer(string username, string email)
        {
            this.username = username;
            this.email = email;
        }
        public override void Welcome()
        {
            Console.WriteLine("\n-------- Welcome to E-Cinema Booking, {0}. (Email = {1}) ---------", username, email);
        }

        public override string Exit()
        {
            Console.WriteLine("\n--------------------------- Thankyou ----------------------------");
            Console.WriteLine("Press 'Enter' to Continue, type 'END PROGRAM' to end the program");
            return Console.ReadLine();
        }

        public void Payment(Movie film)
        {
            Console.WriteLine("\nFilm {0} dengan jumlah pembelian ticket {1} seharga {2} rupiah\nSilahkan bayar ke loket yang tersedia! (Enter untuk melanjutkan)", film.movieName, film.harga.total / film.moviePrice, film.harga.total);
            Console.ReadLine();
        }
    }
}
