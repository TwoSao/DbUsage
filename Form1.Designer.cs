namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toode_pb = new PictureBox();
            toodeLbl = new Label();
            kogusLbl = new Label();
            hindLbl = new Label();
            kategorLbl = new Label();
            kogusTextB = new TextBox();
            hindTextB = new TextBox();
            toodeTextB = new TextBox();
            lisakategorBtn = new Button();
            kustutakategorBtn = new Button();
            lisaBtn = new Button();
            uuendaBtn = new Button();
            KustutaBtn = new Button();
            puhastaBtn = new Button();
            otsifailBtn = new Button();
            makstaBtn = new Button();
            valinBtn = new Button();
            ostanBtn = new Button();
            saadaarvBtn = new Button();
            poodBtn = new Button();
            textBox1 = new TextBox();
            kat_box = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toode_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toode_pb
            // 
            toode_pb.BackColor = SystemColors.ControlDark;
            toode_pb.Location = new Point(513, 9);
            toode_pb.Name = "toode_pb";
            toode_pb.Size = new Size(557, 335);
            toode_pb.TabIndex = 0;
            toode_pb.TabStop = false;
            // 
            // toodeLbl
            // 
            toodeLbl.AutoSize = true;
            toodeLbl.Location = new Point(12, 12);
            toodeLbl.Name = "toodeLbl";
            toodeLbl.Size = new Size(43, 15);
            toodeLbl.TabIndex = 1;
            toodeLbl.Text = "Toode:";
            // 
            // kogusLbl
            // 
            kogusLbl.AutoSize = true;
            kogusLbl.Location = new Point(9, 41);
            kogusLbl.Name = "kogusLbl";
            kogusLbl.Size = new Size(43, 15);
            kogusLbl.TabIndex = 2;
            kogusLbl.Text = "Kogus:";
            // 
            // hindLbl
            // 
            hindLbl.AutoSize = true;
            hindLbl.Location = new Point(12, 70);
            hindLbl.Name = "hindLbl";
            hindLbl.Size = new Size(36, 15);
            hindLbl.TabIndex = 3;
            hindLbl.Text = "Hind:";
            // 
            // kategorLbl
            // 
            kategorLbl.AutoSize = true;
            kategorLbl.Location = new Point(9, 99);
            kategorLbl.Name = "kategorLbl";
            kategorLbl.Size = new Size(74, 15);
            kategorLbl.TabIndex = 4;
            kategorLbl.Text = "Kategooriad:";
            // 
            // kogusTextB
            // 
            kogusTextB.Location = new Point(89, 38);
            kogusTextB.Name = "kogusTextB";
            kogusTextB.Size = new Size(139, 23);
            kogusTextB.TabIndex = 5;
            // 
            // hindTextB
            // 
            hindTextB.Location = new Point(89, 67);
            hindTextB.Name = "hindTextB";
            hindTextB.Size = new Size(139, 23);
            hindTextB.TabIndex = 6;
            // 
            // toodeTextB
            // 
            toodeTextB.Location = new Point(89, 9);
            toodeTextB.Name = "toodeTextB";
            toodeTextB.Size = new Size(139, 23);
            toodeTextB.TabIndex = 8;
            // 
            // lisakategorBtn
            // 
            lisakategorBtn.Location = new Point(11, 152);
            lisakategorBtn.Name = "lisakategorBtn";
            lisakategorBtn.Size = new Size(88, 62);
            lisakategorBtn.TabIndex = 9;
            lisakategorBtn.Text = "Lisa kategooriat";
            lisakategorBtn.UseVisualStyleBackColor = true;
            lisakategorBtn.Click += lisaBtn_Click;
            // 
            // kustutakategorBtn
            // 
            kustutakategorBtn.Location = new Point(105, 152);
            kustutakategorBtn.Name = "kustutakategorBtn";
            kustutakategorBtn.Size = new Size(88, 62);
            kustutakategorBtn.TabIndex = 10;
            kustutakategorBtn.Text = "Kustuta kategooriat";
            kustutakategorBtn.UseVisualStyleBackColor = true;
            kustutakategorBtn.Click += kustutakategorBtn_Click;
            // 
            // lisaBtn
            // 
            lisaBtn.Location = new Point(9, 392);
            lisaBtn.Name = "lisaBtn";
            lisaBtn.Size = new Size(88, 33);
            lisaBtn.TabIndex = 11;
            lisaBtn.Text = "Lisa";
            lisaBtn.UseVisualStyleBackColor = true;
            lisaBtn.Click += lisaBtn_Click_1;
            // 
            // uuendaBtn
            // 
            uuendaBtn.Location = new Point(105, 392);
            uuendaBtn.Name = "uuendaBtn";
            uuendaBtn.Size = new Size(88, 33);
            uuendaBtn.TabIndex = 12;
            uuendaBtn.Text = "Uuenda";
            uuendaBtn.UseVisualStyleBackColor = true;
            // 
            // KustutaBtn
            // 
            KustutaBtn.Location = new Point(200, 392);
            KustutaBtn.Name = "KustutaBtn";
            KustutaBtn.Size = new Size(88, 33);
            KustutaBtn.TabIndex = 13;
            KustutaBtn.Text = "Kustuta";
            KustutaBtn.UseVisualStyleBackColor = true;
            // 
            // puhastaBtn
            // 
            puhastaBtn.Location = new Point(294, 392);
            puhastaBtn.Name = "puhastaBtn";
            puhastaBtn.Size = new Size(88, 33);
            puhastaBtn.TabIndex = 14;
            puhastaBtn.Text = "Puhasta";
            puhastaBtn.UseVisualStyleBackColor = true;
            // 
            // otsifailBtn
            // 
            otsifailBtn.Location = new Point(513, 353);
            otsifailBtn.Name = "otsifailBtn";
            otsifailBtn.Size = new Size(88, 33);
            otsifailBtn.TabIndex = 15;
            otsifailBtn.Text = "Otsi fail";
            otsifailBtn.UseVisualStyleBackColor = true;
            otsifailBtn.Click += otsifailBtn_Click;
            // 
            // makstaBtn
            // 
            makstaBtn.Location = new Point(513, 392);
            makstaBtn.Name = "makstaBtn";
            makstaBtn.Size = new Size(88, 33);
            makstaBtn.TabIndex = 16;
            makstaBtn.Text = "Maksta";
            makstaBtn.UseVisualStyleBackColor = true;
            // 
            // valinBtn
            // 
            valinBtn.Location = new Point(780, 353);
            valinBtn.Name = "valinBtn";
            valinBtn.Size = new Size(88, 33);
            valinBtn.TabIndex = 17;
            valinBtn.Text = "Valin";
            valinBtn.UseVisualStyleBackColor = true;
            // 
            // ostanBtn
            // 
            ostanBtn.Location = new Point(874, 353);
            ostanBtn.Name = "ostanBtn";
            ostanBtn.Size = new Size(88, 33);
            ostanBtn.TabIndex = 18;
            ostanBtn.Text = "Ostan";
            ostanBtn.UseVisualStyleBackColor = true;
            // 
            // saadaarvBtn
            // 
            saadaarvBtn.Location = new Point(982, 353);
            saadaarvBtn.Name = "saadaarvBtn";
            saadaarvBtn.Size = new Size(88, 33);
            saadaarvBtn.TabIndex = 19;
            saadaarvBtn.Text = "Saada arve";
            saadaarvBtn.UseVisualStyleBackColor = true;
            // 
            // poodBtn
            // 
            poodBtn.Location = new Point(780, 392);
            poodBtn.Name = "poodBtn";
            poodBtn.Size = new Size(88, 33);
            poodBtn.TabIndex = 20;
            poodBtn.Text = "Pood";
            poodBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(874, 392);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 21;
            // 
            // kat_box
            // 
            kat_box.FormattingEnabled = true;
            kat_box.Location = new Point(89, 99);
            kat_box.Name = "kat_box";
            kat_box.Size = new Size(139, 23);
            kat_box.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 459);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1047, 156);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 627);
            Controls.Add(dataGridView1);
            Controls.Add(kat_box);
            Controls.Add(textBox1);
            Controls.Add(poodBtn);
            Controls.Add(saadaarvBtn);
            Controls.Add(ostanBtn);
            Controls.Add(valinBtn);
            Controls.Add(makstaBtn);
            Controls.Add(otsifailBtn);
            Controls.Add(puhastaBtn);
            Controls.Add(KustutaBtn);
            Controls.Add(uuendaBtn);
            Controls.Add(lisaBtn);
            Controls.Add(kustutakategorBtn);
            Controls.Add(lisakategorBtn);
            Controls.Add(toodeTextB);
            Controls.Add(hindTextB);
            Controls.Add(kogusTextB);
            Controls.Add(kategorLbl);
            Controls.Add(hindLbl);
            Controls.Add(kogusLbl);
            Controls.Add(toodeLbl);
            Controls.Add(toode_pb);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)toode_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox toode_pb;
        private Label toodeLbl;
        private Label kogusLbl;
        private Label hindLbl;
        private Label kategorLbl;
        private TextBox kogusTextB;
        private TextBox hindTextB;
        private TextBox toodeTextB;
        private Button lisakategorBtn;
        private Button kustutakategorBtn;
        private Button lisaBtn;
        private Button uuendaBtn;
        private Button KustutaBtn;
        private Button puhastaBtn;
        private Button otsifailBtn;
        private Button makstaBtn;
        private Button valinBtn;
        private Button ostanBtn;
        private Button saadaarvBtn;
        private Button poodBtn;
        private TextBox textBox1;
        private ComboBox kat_box;
        private DataGridView dataGridView1;
    }
}
