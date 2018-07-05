using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Security.Cryptography;

namespace Serveri_TCP
{
    class Program
    {
        public static string sDhena;
        public static string sDhena1;
        static Socket socketServeri;
        static IPEndPoint Ips;
        static void Main(string[] args)
        {
            Console.WriteLine("Serveri FIEK-TCP");
            Ips = new IPEndPoint(IPAddress.Any, 7000);
            Socket sFillimi = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sFillimi.Bind(Ips);
            sFillimi.Listen(100);
            Console.WriteLine("Serveri startoi dhe po pret per t'u lidhur me ndonje klient.");
            while (true)
            {


                socketServeri = sFillimi.Accept();
                Thread Threadi = new Thread(Lidhja);
                Threadi.Start();
            }
        }
        public static void Lidhja()

        {
            Socket sockets = socketServeri;

            IPEndPoint klientiIP = (IPEndPoint)sockets.RemoteEndPoint;
            Console.WriteLine("Serveri u lidh me Klientin");

            byte[] Dhena = new byte[128];
            int gjatesia = sockets.Receive(Dhena);
            sDhena = Encoding.ASCII.GetString(Dhena, 0, gjatesia);


            if (sDhena == "0")
            {
                sDhena1 = "Ip adresa e klientit eshte: " + IP();

            }
            else if (sDhena == "1")
            {
                int sDhena1;
                sDhena1 = klientiIP.Port;
                byte[] Pergjigjja = new byte[128];
                Pergjigjja = Encoding.ASCII.GetBytes(sDhena1.ToString());
                socketServeri.Send(Pergjigjja, Pergjigjja.Length, SocketFlags.None);

            }
            else if (sDhena.IndexOf("2") == 0)
            {
                if (sDhena.Substring(1) != "")
                {
                    sDhena1 = sDhena.Substring(1);
                    sDhena1 = ZANORE();
                }
                else
                    sDhena1 = "Shkruani tekstin per te numeruar zanoret!";

            }
            else if (sDhena.IndexOf("3") == 0)
            {
                if (sDhena.Substring(1) != "")
                {
                    sDhena1 = sDhena.Substring(1);
                    sDhena1 = PRINTO();
                }
                else
                    sDhena1 = "Shkruani nje tekst per te printuar tekstin";
            }
            else if (sDhena == "4")
            {
                sDhena1 = "Hosti name i klientit: " + Dns.GetHostName();
            }
            else if (sDhena == "5")
            {
                sDhena1 = DateTime.Now.ToString();
            }
            else if (sDhena == "6")
            {
                sDhena1 = KENO();
            }
            else if (sDhena.IndexOf("7") == 0)
            {
                if (sDhena.Substring(1) != "")
                {
                    sDhena1 = sDhena.Substring(1);
                    sDhena1 = FAKTORIEL();
                }
                else
                    sDhena1 = "Shkruani numrin per te llogaritur faktorielin!";
            }
            else if (sDhena.IndexOf("8") == 0)
            {
                if (sDhena.Substring(2) != "")
                {
                    sDhena1 = CelsiusToKelvin();
                }
                else
                    sDhena1 = "Shkruani shkallen Celsius qe doni ta konvertoni ne Kelvin!";
            }
            else if (sDhena.IndexOf("9") == 0)
            {
                if (sDhena.Substring(2) != "")
                {
                    sDhena1 = CelsiusToFahrenheit();
                }
                else
                    sDhena1 = "Shkruani shkallen Celsius qe doni ta konvertoni ne Fahrenheit!";
            }
            else if (sDhena.IndexOf("10") == 0)
            {
                if (sDhena.Substring(2) != "")
                {
                    sDhena1 = KelvinToFahrenheit();
                }
                else
                    sDhena1 = "Shkruani shkallen Kelvin qe doni ta konvertoni ne Fahrenheit!";
            }
            else if (sDhena.IndexOf("11") == 0)
            {
                if (sDhena.Substring(2) != "")
                {
                    sDhena1 = KelvinToCelsius();
                }
                else
                    sDhena1 = "Shkruani shkallen Kelvin qe doni ta konvertoni ne Celsius!";
            }
            else if (sDhena.IndexOf("12") == 0)
            {
                if (sDhena.Substring(2) != "")
                {
                    sDhena1 = FahrenheitToCelsius();
                }
                else
                    sDhena1 = "Shkruani shkallen Fahrenheit qe doni ta konvertoni ne Celsius!";
            }
            else if (sDhena.IndexOf("13") == 0)
            {
                if (sDhena.Substring(2) != "")
                {
                    sDhena1 = FahrenheitToKelvin();
                }
                else
                    sDhena1 = "Shkruani shkallen Fahrenheit qe doni ta konvertoni ne Kelvin!";
            }
            else if (sDhena.IndexOf("14") == 0)
            {
                if (sDhena.Substring(2) != "")
                {
                    sDhena1 = PoundToKg();
                }
                else
                    sDhena1 = "Shkruani sasine e mases ne Pound qe doni ta konvertoni ne Kilogram!";
            }
            else if (sDhena.IndexOf("15") == 0)
            {
                if (sDhena.Substring(2) != "")
                {
                    sDhena1 = KgToPound();
                }
                else
                    sDhena1 = "Shkruani sasine e mases ne Kilogram qe doni ta konvertoni ne Pound!";
            }
            else if (sDhena.IndexOf("16") == 0)
            {
                if (sDhena.Substring(1) != "")
                {
                    sDhena1 = sDhena.Substring(1);
                    sDhena1 = HashSHA256();
                }
            }
            else if (sDhena.IndexOf("17") == 0)
            {
                if (sDhena.Substring(1) != "")
                {
                    sDhena1 = sDhena.Substring(1);
                    sDhena1 = KAPITALIZMI();
                }
                else
                    sDhena1 = "Shkruani tekstin qe deshironi te kapitalizoni!";
            }
            byte[] Edhena = new byte[128];
            Edhena = Encoding.ASCII.GetBytes(sDhena1);
            sockets.Send(Edhena, Edhena.Length, SocketFlags.None);
            sockets.Close();
        }
        public static string IP()
        {
            string HostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(HostName);

            foreach (IPAddress IpAdd in ipEntry.AddressList)
            {
                if (IpAdd.AddressFamily.ToString() == "InterNetwork")
                {
                    return IpAdd.ToString();
                }
            }

            return "ERROR";
        }
        public static string ZANORE()
        {
            int total = 0;
            sDhena1 = sDhena.Substring(1);
            var zanoret = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y' };
            string fjalia = sDhena1.ToLower();
            for (int i = 0; i < fjalia.Length; i++)
            {
                if (zanoret.Contains(fjalia[i]))
                {
                    total++;
                }
            }
            return "Teksti i pranuar permban " + total.ToString() + " zanore";
        }
        public static string PRINTO()
        {
            return sDhena1.Trim();

        }
        public static string KENO()
        {
            int[] numri = new int[20];
            Random rnd = new Random();
            int i;
            for (i = 0; i <= 19; i++)
            {
                numri[i] = rnd.Next(1, 80);
            }
            for (int a = 0; a <= 19; a++)
            {
                if (a == 0)
                    sDhena1 = numri[a].ToString();
                else
                    sDhena1 += ", " + numri[a].ToString();
            }
            return sDhena1;

        }
        private static string FAKTORIEL()
        {
            int n = int.Parse(sDhena1);
            int f = 1;
            for (int i = 1; i <= n; i++)
                f = f * i;
            return "Faktorieli i numrit te dhene eshte " + f.ToString();
        }
        public static string CelsiusToKelvin()
        {
            double KONVERTO = double.Parse(sDhena.Substring(2));
            KONVERTO = KONVERTO + 273.15;
            return KONVERTO.ToString() + " K";
        }
        public static string CelsiusToFahrenheit()
        {
            double KONVERTO = double.Parse(sDhena.Substring(2));
            KONVERTO = ((KONVERTO / 5) * 9) + 32;
            return KONVERTO.ToString() + " F";
        }
        public static string KelvinToFahrenheit()
        {
            double KONVERTO = double.Parse(sDhena.Substring(2));
            KONVERTO = (KONVERTO * (9 / 5)) - 459.67;
            return KONVERTO.ToString() + " F";

        }
        public static string KelvinToCelsius()
        {
            double KONVERTO = double.Parse(sDhena.Substring(2));
            KONVERTO = KONVERTO - 273.15;
            return KONVERTO.ToString() + " C";
        }
        public static string FahrenheitToCelsius()
        {
            double KONVERTO = double.Parse(sDhena.Substring(2));
            KONVERTO = (KONVERTO - 32) / (9 / 5);
            return KONVERTO.ToString() + " C";
        }
        public static string FahrenheitToKelvin()
        {
            double KONVERTO = double.Parse(sDhena.Substring(2));
            KONVERTO = (KONVERTO + 459.67) * 5 / 9;
            return KONVERTO.ToString() + " K";
        }
        public static string PoundToKg()
        {
            double KONVERTO = double.Parse(sDhena.Substring(2));
            KONVERTO = KONVERTO * 0.45;
            return KONVERTO.ToString() + " kg";
        }
        public static string KgToPound()
        {
            double KONVERTO = double.Parse(sDhena.Substring(2));
            KONVERTO = KONVERTO / 0.45;
            return KONVERTO.ToString() + " lb";
        }
        public static string KAPITALIZMI()
        {

            if (sDhena1 == sDhena1.ToLower())
            {
                sDhena1 = sDhena1.ToUpper();
            }
            else
                sDhena1 = sDhena1.ToLower();
            return sDhena1;
        }
        public static string HashSHA256()
        {

            sDhena1 = sDhena.Substring(1);
            var sha = new SHA256Managed();

            byte[] textData = System.Text.Encoding.UTF8.GetBytes(sDhena1);
            byte[] hash = sha.ComputeHash(textData);
            return BitConverter.ToString(hash);
        }
    }
}
