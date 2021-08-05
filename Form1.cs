using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_Procesos
{
    
    public partial class Form1 : Form
    {
        bool hay_ganador = false;
        int jugador_ganador=0;
        public Form1()
        {
            
            InitializeComponent();
            Img1.Image = Image.FromFile("carro1.png");
            Img2.Image = Image.FromFile("carro2.jpg");
            Img3.Image = Image.FromFile("carro3.jpg");
            Img4.Image = Image.FromFile("carro4.png");

            Img1.SizeMode = PictureBoxSizeMode.StretchImage;
            Img2.SizeMode = PictureBoxSizeMode.StretchImage;
            Img3.SizeMode = PictureBoxSizeMode.StretchImage;
            Img4.SizeMode = PictureBoxSizeMode.StretchImage;

            Img1.Location = new Point(20, 20);
            Img2.Location = new Point(20, 120);
            Img3.Location = new Point(20, 220);
            Img4.Location = new Point(20, 320);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            Img1.Location = new Point(20, 20);
            Img2.Location = new Point(20, 120);
            Img3.Location = new Point(20, 220);
            Img4.Location = new Point(20, 320);
            lblGanador.Text = "";
            tmrCarrera.Start();
        }

        private void tmrCarrera_Tick(object sender, EventArgs e)
        {

            int Img_x = 0;
            int Img_y = 0;
            Random rnd = new Random();

            bool JugadoresEnMeta = false;
            bool llego_jugador1 = false;
            bool llego_jugador2 = false;
            bool llego_jugador3 = false;
            bool llego_jugador4 = false;
            bool ya_hay_ganador = false;

            if (Img1.Location.X > 525) { llego_jugador1 = true; JugadoresEnMeta = true; ya_hay_ganador = true; } 
            else { JugadoresEnMeta = false; }

            if (Img2.Location.X > 525) { llego_jugador2 = true; JugadoresEnMeta = true; ya_hay_ganador = true; } 
            else { JugadoresEnMeta = false; }

            if (Img3.Location.X > 525) { llego_jugador3 = true; JugadoresEnMeta = true; ya_hay_ganador = true; } 
            else { JugadoresEnMeta = false; }

            if (Img4.Location.X > 525) { llego_jugador4 = true; JugadoresEnMeta = true; ya_hay_ganador = true; }
            else { JugadoresEnMeta = false; }

            if (!hay_ganador && ya_hay_ganador)
            {
                hay_ganador = true;
                if (llego_jugador1) jugador_ganador = 1;
                if (llego_jugador2) jugador_ganador = 2;
                if (llego_jugador3) jugador_ganador = 3;
                if (llego_jugador4) jugador_ganador = 4;
            }

            if (JugadoresEnMeta)
            {
                switch (jugador_ganador) 
                {
                    case 1:
                        lblGanador.Text = "¡GANO JUGADOR 1!";
                        break;
                    case 2:
                        lblGanador.Text = "¡GANO JUGADOR 2!";
                        break;
                    case 3:
                        lblGanador.Text = "¡GANO JUGADOR 3!";
                        break;
                    case 4:
                        lblGanador.Text = "¡GANO JUGADOR 4!";
                        break;
                }

                tmrCarrera.Stop();
                hay_ganador = false;
                jugador_ganador = 0;
                

            }
            else
            {
                if (!llego_jugador1) 
                {
                    Img_x = Img1.Location.X;
                    Img_y = Img1.Location.Y;
                    Img1.Location = new Point(Img_x + rnd.Next(1, 10), Img_y);
                    
                }
                
                if (!llego_jugador2)
                {
                    Img_x = Img2.Location.X;
                    Img_y = Img2.Location.Y;
                    Img2.Location = new Point(Img_x + rnd.Next(1, 10), Img_y);
                }
                
                if (!llego_jugador3)
                {
                    Img_x = Img3.Location.X;
                    Img_y = Img3.Location.Y;
                    Img3.Location = new Point(Img_x + rnd.Next(1, 10), Img_y);
                }
                
                if (!llego_jugador4)
                {
                    Img_x = Img4.Location.X;
                    Img_y = Img4.Location.Y;
                    Img4.Location = new Point(Img_x + rnd.Next(1, 10), Img_y);
                }

            }

            

        }
    }
}
