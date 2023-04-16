using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_ALFRED_W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i, j;
        string since;
        List<string> perantara;
        public static List<string> titles;
        public static List<string> moviePosters;
        public static Movies movies;
        public static Form2 order;
        public static List<List<Time>> timePlaying = new List<List<Time>>();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor = Color.Beige;
            panel1.BackColor = Color.Pink;
            since = "Since 1992.       ";

            string file = "cinema textfile.txt";
            string[] lines = File.ReadAllLines(file);
            perantara = new List<string>();
            foreach (string line in lines)
            {
                perantara.AddRange(line.Split(','));
            }
            titles = new List<string>();
            moviePosters = new List<string>();
            foreach (string baris in perantara)
            {
                if (baris[0] == 'C')
                {
                    moviePosters.Add(baris);
                }
                else
                {
                    titles.Add(baris);
                }
            }
            movies = new Movies();
            movies.TopLevel = false;
            movies.Dock = DockStyle.Fill;
            this.panel_Film.Controls.Add(movies);
            movies.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i % 10 == 0)
            {
                pic_arrow1.Visible = true;
                pic_arrow2.Visible = true;
            }
            else if(i % 5 == 0)
            {
                cinema.ForeColor = Color.Red;
                pic_arrow1.Visible = false;
                pic_arrow2.Visible = false;

            }
            else if(i % 3 == 0)
            {
                cinema.ForeColor = Color.Yellow;

            }
            else if(i % 2 == 0)
            {
                cinema.ForeColor = Color.Cyan;
            }
            i++;
            
            if(j != since.Length - 1)
            {
                lbl_since.Text += since[j];
                j++;
            }
            else
            {
                j = 0;
                lbl_since.Text = "";
            }
        }
    }
}
