using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_ALFRED_W
{
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }
        Button[] tickets;
        PictureBox[] posters;
        int movieCount, x, y;
        public static string filmNo;
        public static List<string> titles;
        public static List<string> moviePosters;
        
        Form2 order;
        private void Movies_Load(object sender, EventArgs e)
        {
            x = 25;
            y = 15;

            titles = Form1.titles;
            moviePosters = Form1.moviePosters;
            this.BackColor = Color.Beige;
            
            movieCount = 8;
            tickets = new Button[movieCount];
            posters = new PictureBox[movieCount];
            for (int i = 0; i < movieCount; i++)
            {
                posters[i] = new PictureBox();
                posters[i].Size = new Size(130, 180);
                posters[i].Location = new Point(x, y);
                posters[i].Tag = i.ToString();
                posters[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(posters[i]);

                tickets[i] = new Button();
                tickets[i].Size = new Size(130, 30);
                tickets[i].Location = new Point(x, y + 190);
                tickets[i].Text = "Book Tickets";
                tickets[i].Font = new Font("Arial", 8, FontStyle.Bold);
                tickets[i].Tag = i.ToString();
                tickets[i].BackColor = Color.Cyan;
                tickets[i].MouseHover += tickets_Hover;
                tickets[i].MouseLeave += tickets_Leave;
                tickets[i].Click += ticket_Order;
                this.Controls.Add(tickets[i]);
                x += 180;

                List<Time> times = new List<Time>();
                Time time1 = new Time("12:00");
                times.Add(time1);
                Time time2 = new Time("14:30");
                times.Add(time2);
                Time time3 = new Time("17:00");
                times.Add(time3);
                Form1.timePlaying.Add(times);


                switch (i)
                {
                    case 0:
                        posters[i].ImageLocation = @moviePosters[0];
                        break;
                    case 1:
                        posters[i].ImageLocation = @moviePosters[1];
                        break;
                    case 2:
                        posters[i].ImageLocation = @moviePosters[2];
                        break;
                    case 3:
                        posters[i].ImageLocation = @moviePosters[3];
                        x = 25;
                        y += 230;
                        break;
                    case 4:
                        posters[i].ImageLocation = @moviePosters[4];
                        break;
                    case 5:
                        posters[i].ImageLocation = @moviePosters[5];
                        break;
                    case 6:
                        posters[i].ImageLocation = @moviePosters[6];
                        break;
                    case 7:
                        posters[i].ImageLocation = @moviePosters[7];
                        break;
                }
            }
        }

        private void ticket_Order(object sender, EventArgs e)
        {
            var send = sender as Button;
            filmNo = send.Tag.ToString();
            this.Controls.Clear();

            order = new Form2();
            order.TopLevel = false;
            order.Dock = DockStyle.Fill;
            this.Controls.Add(order);
            order.Show();
        }

        private void tickets_Hover(object sender, EventArgs e)
        {
            var send = sender as Button;
            send.BackColor = Color.Aquamarine;
        }

        private void tickets_Leave(object sender, EventArgs e)
        {
            var send = sender as Button;
            send.BackColor = Color.Cyan;
        }

    }
}


