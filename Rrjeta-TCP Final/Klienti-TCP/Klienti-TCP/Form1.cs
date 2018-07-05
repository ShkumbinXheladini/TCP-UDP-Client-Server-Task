using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Media;
using System.Security.Cryptography;
namespace Klienti_TCP
{
    public partial class Form1 : Form
    {
        //Socket sKlienti;
        IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7000);  
        public static string Kerkesa;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDergo_Click(object sender, EventArgs e)
        {
            Socket sKlienti = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sKlienti.Connect(ip);
                 lblRezultati.Text = "Lidhja me server u realizua!!";

                if (cmbFIEK.SelectedIndex == 0)
                {

                    Kerkesa = "0";
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 1)
                {
                    Kerkesa = "1";
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 2)
                {
                    Kerkesa = "2" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 3)
                {
                    Kerkesa = "3" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 4)
                {
                    Kerkesa = "4";
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 5)
                {
                    Kerkesa = "5";
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 6)
                {
                    Kerkesa = "6";
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 7)
                {
                    Kerkesa = "7" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 8)
                {
                    Kerkesa = "8" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 9)
                {
                    Kerkesa = "9" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 10)
                {
                    Kerkesa = "10" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));
                }
                else if (cmbFIEK.SelectedIndex == 11)
                {
                    Kerkesa = "11" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 12)
                {
                    Kerkesa = "12" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 13)
                {
                    Kerkesa = "13" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 14)
                {
                    Kerkesa = "14" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 15)
                {
                    Kerkesa = "15" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));
                }
                else if (cmbFIEK.SelectedIndex == 16)
                {
                    Kerkesa = "16" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));

                }
                else if (cmbFIEK.SelectedIndex == 17)
                {
                    Kerkesa = "17" + txtFunksioni.Text;
                    sKlienti.Send(Encoding.ASCII.GetBytes(Kerkesa));
                }

                byte[] Edhena = new byte[128];
                int gjatesia = sKlienti.Receive(Edhena);
                string sEdhena = Encoding.ASCII.GetString(Edhena, 0, gjatesia);
                lblRezultati.Text += "\nServeri:  " + sEdhena;

                sKlienti.Close();
            }
            catch (Exception se)
            {
                MessageBox.Show("Lidhja me server deshtoi.\n\n" + se.Message); 
                return;
            }
        }
    }
}
