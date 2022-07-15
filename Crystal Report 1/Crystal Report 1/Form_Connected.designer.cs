
namespace swproject
{
    partial class Form_Connected
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Connected));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_TT = new System.Windows.Forms.ComboBox();
            this.TXT_TC = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ST = new System.Windows.Forms.ComboBox();
            this.TXT_SC = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InsertSeries = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SortByCategory = new System.Windows.Forms.Button();
            this.txt_MID = new System.Windows.Forms.TextBox();
            this.Date_M = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_MT = new System.Windows.Forms.ComboBox();
            this.TXT_MC = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Date_S = new System.Windows.Forms.TextBox();
            this.Date_T = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_SID = new System.Windows.Forms.TextBox();
            this.txt_TID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Category";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 64;
            this.label8.Text = "TvShowID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(76, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 63;
            this.label9.Text = "TvShow Title";
            // 
            // cmb_TT
            // 
            this.cmb_TT.FormattingEnabled = true;
            this.cmb_TT.Location = new System.Drawing.Point(222, 500);
            this.cmb_TT.Name = "cmb_TT";
            this.cmb_TT.Size = new System.Drawing.Size(121, 24);
            this.cmb_TT.TabIndex = 62;
            this.cmb_TT.SelectedIndexChanged += new System.EventHandler(this.cmb_TT_SelectedIndexChanged);
            // 
            // TXT_TC
            // 
            this.TXT_TC.Location = new System.Drawing.Point(222, 588);
            this.TXT_TC.Name = "TXT_TC";
            this.TXT_TC.Size = new System.Drawing.Size(121, 22);
            this.TXT_TC.TabIndex = 61;
            this.TXT_TC.TextChanged += new System.EventHandler(this.TXT_TC_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(508, 622);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 31);
            this.button7.TabIndex = 59;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(508, 566);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 31);
            this.button8.TabIndex = 58;
            this.button8.Text = "Update";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(508, 511);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 31);
            this.button9.TabIndex = 57;
            this.button9.Text = "Insert";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "SeiresID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Series Title";
            // 
            // cmb_ST
            // 
            this.cmb_ST.FormattingEnabled = true;
            this.cmb_ST.Location = new System.Drawing.Point(223, 91);
            this.cmb_ST.Name = "cmb_ST";
            this.cmb_ST.Size = new System.Drawing.Size(121, 24);
            this.cmb_ST.TabIndex = 44;
            this.cmb_ST.SelectedIndexChanged += new System.EventHandler(this.cmb_ST_SelectedIndexChanged);
            // 
            // TXT_SC
            // 
            this.TXT_SC.Location = new System.Drawing.Point(223, 175);
            this.TXT_SC.Name = "TXT_SC";
            this.TXT_SC.Size = new System.Drawing.Size(121, 22);
            this.TXT_SC.TabIndex = 43;
            this.TXT_SC.TextChanged += new System.EventHandler(this.TXT_SC_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(508, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 31);
            this.button3.TabIndex = 41;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 31);
            this.button2.TabIndex = 40;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InsertSeries
            // 
            this.InsertSeries.Location = new System.Drawing.Point(508, 100);
            this.InsertSeries.Name = "InsertSeries";
            this.InsertSeries.Size = new System.Drawing.Size(108, 31);
            this.InsertSeries.TabIndex = 39;
            this.InsertSeries.Text = "Insert";
            this.InsertSeries.UseVisualStyleBackColor = true;
            this.InsertSeries.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 713);
            this.splitter1.TabIndex = 66;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SortByCategory);
            this.panel1.Controls.Add(this.txt_MID);
            this.panel1.Controls.Add(this.Date_M);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmb_MT);
            this.panel1.Controls.Add(this.TXT_MC);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(1, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 216);
            this.panel1.TabIndex = 67;
            // 
            // SortByCategory
            // 
            this.SortByCategory.Location = new System.Drawing.Point(639, 98);
            this.SortByCategory.Name = "SortByCategory";
            this.SortByCategory.Size = new System.Drawing.Size(130, 40);
            this.SortByCategory.TabIndex = 76;
            this.SortByCategory.Text = "Sort By Category";
            this.SortByCategory.UseVisualStyleBackColor = true;
            this.SortByCategory.Click += new System.EventHandler(this.SortByCategory_Click);
            // 
            // txt_MID
            // 
            this.txt_MID.Location = new System.Drawing.Point(221, 84);
            this.txt_MID.Name = "txt_MID";
            this.txt_MID.Size = new System.Drawing.Size(121, 22);
            this.txt_MID.TabIndex = 75;
            // 
            // Date_M
            // 
            this.Date_M.Location = new System.Drawing.Point(220, 169);
            this.Date_M.Name = "Date_M";
            this.Date_M.Size = new System.Drawing.Size(121, 22);
            this.Date_M.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(74, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 24);
            this.label12.TabIndex = 72;
            this.label12.Text = "Release Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 65;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 64;
            this.label5.Text = "MovieID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 63;
            this.label6.Text = "Movie Title";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmb_MT
            // 
            this.cmb_MT.FormattingEnabled = true;
            this.cmb_MT.Location = new System.Drawing.Point(221, 39);
            this.cmb_MT.Name = "cmb_MT";
            this.cmb_MT.Size = new System.Drawing.Size(121, 24);
            this.cmb_MT.TabIndex = 62;
            this.cmb_MT.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // TXT_MC
            // 
            this.TXT_MC.Location = new System.Drawing.Point(220, 127);
            this.TXT_MC.Name = "TXT_MC";
            this.TXT_MC.Size = new System.Drawing.Size(121, 22);
            this.TXT_MC.TabIndex = 61;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 31);
            this.button4.TabIndex = 59;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(507, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 31);
            this.button5.TabIndex = 58;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(507, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 31);
            this.button6.TabIndex = 57;
            this.button6.Text = "Insert";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(247, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 35);
            this.label10.TabIndex = 68;
            this.label10.Text = "Manage DataBase";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(640, 662);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(130, 43);
            this.Back.TabIndex = 69;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(77, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 24);
            this.label11.TabIndex = 70;
            this.label11.Text = "Release Date";
            // 
            // Date_S
            // 
            this.Date_S.Location = new System.Drawing.Point(223, 215);
            this.Date_S.Name = "Date_S";
            this.Date_S.Size = new System.Drawing.Size(121, 22);
            this.Date_S.TabIndex = 71;
            this.Date_S.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Date_T
            // 
            this.Date_T.Location = new System.Drawing.Point(221, 630);
            this.Date_T.Name = "Date_T";
            this.Date_T.Size = new System.Drawing.Size(121, 22);
            this.Date_T.TabIndex = 73;
            this.Date_T.TextChanged += new System.EventHandler(this.Date_T_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(75, 628);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 24);
            this.label13.TabIndex = 72;
            this.label13.Text = "Release Date";
            // 
            // txt_SID
            // 
            this.txt_SID.Location = new System.Drawing.Point(223, 131);
            this.txt_SID.Name = "txt_SID";
            this.txt_SID.Size = new System.Drawing.Size(121, 22);
            this.txt_SID.TabIndex = 74;
            this.txt_SID.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txt_TID
            // 
            this.txt_TID.Location = new System.Drawing.Point(221, 543);
            this.txt_TID.Name = "txt_TID";
            this.txt_TID.Size = new System.Drawing.Size(121, 22);
            this.txt_TID.TabIndex = 75;
            this.txt_TID.TextChanged += new System.EventHandler(this.txt_TID_TextChanged);
            // 
            // Form_Connected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 713);
            this.Controls.Add(this.txt_TID);
            this.Controls.Add(this.txt_SID);
            this.Controls.Add(this.Date_T);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Date_S);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_TT);
            this.Controls.Add(this.TXT_TC);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ST);
            this.Controls.Add(this.TXT_SC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InsertSeries);
            this.Name = "Form_Connected";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_TT;
        private System.Windows.Forms.TextBox TXT_TC;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ST;
        private System.Windows.Forms.TextBox TXT_SC;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button InsertSeries;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_MT;
        private System.Windows.Forms.TextBox TXT_MC;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Date_S;
        private System.Windows.Forms.TextBox Date_M;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Date_T;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_MID;
        private System.Windows.Forms.TextBox txt_SID;
        private System.Windows.Forms.TextBox txt_TID;
        private System.Windows.Forms.Button SortByCategory;
    }
}

