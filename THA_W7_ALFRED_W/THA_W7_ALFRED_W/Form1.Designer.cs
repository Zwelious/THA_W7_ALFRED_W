namespace THA_W7_ALFRED_W
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_arrow1 = new System.Windows.Forms.PictureBox();
            this.pic_arrow2 = new System.Windows.Forms.PictureBox();
            this.lbl_book = new System.Windows.Forms.Label();
            this.lbl_since = new System.Windows.Forms.Label();
            this.cinema = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Film = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_arrow2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_arrow1);
            this.panel1.Controls.Add(this.pic_arrow2);
            this.panel1.Controls.Add(this.lbl_book);
            this.panel1.Controls.Add(this.lbl_since);
            this.panel1.Controls.Add(this.cinema);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 67);
            this.panel1.TabIndex = 0;
            // 
            // pic_arrow1
            // 
            this.pic_arrow1.BackColor = System.Drawing.Color.Red;
            this.pic_arrow1.Image = ((System.Drawing.Image)(resources.GetObject("pic_arrow1.Image")));
            this.pic_arrow1.Location = new System.Drawing.Point(11, 25);
            this.pic_arrow1.Name = "pic_arrow1";
            this.pic_arrow1.Size = new System.Drawing.Size(42, 37);
            this.pic_arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_arrow1.TabIndex = 5;
            this.pic_arrow1.TabStop = false;
            // 
            // pic_arrow2
            // 
            this.pic_arrow2.BackColor = System.Drawing.Color.Red;
            this.pic_arrow2.Image = ((System.Drawing.Image)(resources.GetObject("pic_arrow2.Image")));
            this.pic_arrow2.Location = new System.Drawing.Point(207, 25);
            this.pic_arrow2.Name = "pic_arrow2";
            this.pic_arrow2.Size = new System.Drawing.Size(42, 37);
            this.pic_arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_arrow2.TabIndex = 4;
            this.pic_arrow2.TabStop = false;
            // 
            // lbl_book
            // 
            this.lbl_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book.Location = new System.Drawing.Point(57, 31);
            this.lbl_book.Name = "lbl_book";
            this.lbl_book.Size = new System.Drawing.Size(162, 31);
            this.lbl_book.TabIndex = 2;
            this.lbl_book.Text = "BOOK NOW!!";
            // 
            // lbl_since
            // 
            this.lbl_since.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_since.Location = new System.Drawing.Point(835, 35);
            this.lbl_since.Name = "lbl_since";
            this.lbl_since.Size = new System.Drawing.Size(129, 27);
            this.lbl_since.TabIndex = 1;
            this.lbl_since.Text = "Since 1992.";
            this.lbl_since.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cinema
            // 
            this.cinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinema.Location = new System.Drawing.Point(322, 25);
            this.cinema.Name = "cinema";
            this.cinema.Size = new System.Drawing.Size(382, 37);
            this.cinema.TabIndex = 0;
            this.cinema.Text = "CINEMA MUZZIIKKSS";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_Film
            // 
            this.panel_Film.Location = new System.Drawing.Point(1, 67);
            this.panel_Film.Name = "panel_Film";
            this.panel_Film.Size = new System.Drawing.Size(984, 587);
            this.panel_Film.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel_Film);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_arrow2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_since;
        private System.Windows.Forms.Label cinema;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_Film;
        private System.Windows.Forms.Label lbl_book;
        private System.Windows.Forms.PictureBox pic_arrow1;
        private System.Windows.Forms.PictureBox pic_arrow2;
    }
}

