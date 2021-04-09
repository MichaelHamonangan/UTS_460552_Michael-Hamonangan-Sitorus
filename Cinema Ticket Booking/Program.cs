using System;
using System.Collections;

namespace UTS_460552
{
    class Program
    {
        public static void Main(string[] args)
        {
            Movie movie1 = new Movie("The Gundala", 100, 8.5, 25000);
            movie1.MovieDetail = "Film tentang Gundala, sosok yang ingin melakukan sesuatu tentang ketidakadilan yang mengelilinginya.";
            Movie movie2 = new Movie("Coco", 140, 10.5, 40000);
            movie2.MovieDetail = "Film yang mengisahkan anak berusia 12 tahun yang optimis mengejar mimpinya sebagai musisi.";
            Movie movie3 = new Movie("Despicable Me 3", 120, 12.5, 30000);
            movie3.MovieDetail = "Film tentang Gru dan Dru Membasmi Kejahatan bersama makhluk-makhluk kuning nan imut.";

            string execute = "";
            while (execute != "END PROGRAM")
            {
                Console.WriteLine("Input Username : ");
                string name = Console.ReadLine();

                Console.WriteLine("Input Email : ");
                string email = Console.ReadLine();

                custommer Subject = new custommer(name, email);
                Subject.Welcome();

                int indicator = 0, n = 0;
                while (indicator != 1)
                {
                    n++;
                    string letak = "";
                    Console.WriteLine("\nPilih Film :\n1. Gundala\n2. Coco\n3. Despicable Me");
                    int index = Convert.ToInt32(Console.ReadLine());

                    switch (index)
                    {
                        case 1:
                            movie1.ShowMovieDetail();
                            Console.WriteLine("1.Beli\n0.Kembali");
                            indicator = Convert.ToInt32(Console.ReadLine());
                            if (indicator == 1)
                            {
                                letak = movie1.ShowForm();
                                if (letak != "")
                                {
                                    Subject.Payment(movie1);
                                    MovieTicket tiket = new MovieTicket(movie1.movieName, movie1.duration, movie1.timeStart, movie1.moviePrice, Subject);
                                    tiket.printTicket(letak);
                                }
                            }
                            break;
                        case 2:
                            movie2.ShowMovieDetail();
                            Console.WriteLine("1.Beli\n0.Kembali");
                            indicator = Convert.ToInt32(Console.ReadLine());
                            if (indicator == 1)
                            {
                                letak = movie2.ShowForm();
                                if (letak != "")
                                {
                                    Subject.Payment(movie2);
                                    MovieTicket tiket = new MovieTicket(movie2.movieName, movie2.duration, movie2.timeStart, movie2.moviePrice, Subject);
                                    tiket.printTicket(letak);
                                }
                            }
                            break;
                        case 3:
                            movie3.ShowMovieDetail();
                            Console.WriteLine("1.Beli\n0.Kembali");
                            indicator = Convert.ToInt32(Console.ReadLine());
                            if (indicator == 1)
                            {
                                letak = movie3.ShowForm();
                                if (letak != "")
                                {
                                    Subject.Payment(movie3);
                                    MovieTicket tiket = new MovieTicket(movie3.movieName, movie3.duration, movie3.timeStart, movie3.moviePrice, Subject);
                                    tiket.printTicket(letak);
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Input tidak sesuai");
                            break;
                    }
                }
                execute = Subject.Exit();
            }
        }
    }
}