
namespace wisielec
{
    partial class frmHangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangman));
            this.button1 = new System.Windows.Forms.Button();
            this.hangImage = new System.Windows.Forms.PictureBox();
            this.cmdA = new System.Windows.Forms.Button();
            this.cmdB = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblShowWord = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wyjście";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hangImage
            // 
            this.hangImage.Image = global::wisielec.Properties.Resources.Hang1;
            this.hangImage.Location = new System.Drawing.Point(173, 50);
            this.hangImage.Name = "hangImage";
            this.hangImage.Size = new System.Drawing.Size(448, 267);
            this.hangImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangImage.TabIndex = 1;
            this.hangImage.TabStop = false;
            // 
            // cmdA
            // 
            this.cmdA.Location = new System.Drawing.Point(146, 372);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(36, 30);
            this.cmdA.TabIndex = 2;
            this.cmdA.Text = "a";
            this.cmdA.UseVisualStyleBackColor = true;
            this.cmdA.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // cmdB
            // 
            this.cmdB.Location = new System.Drawing.Point(188, 372);
            this.cmdB.Name = "cmdB";
            this.cmdB.Size = new System.Drawing.Size(36, 30);
            this.cmdB.TabIndex = 3;
            this.cmdB.Text = "ą";
            this.cmdB.UseVisualStyleBackColor = true;
            this.cmdB.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Red;
            this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(173, 152);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 57);
            this.lblResult.TabIndex = 4;
            // 
            // lblShowWord
            // 
            this.lblShowWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowWord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowWord.Location = new System.Drawing.Point(176, 324);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.Size = new System.Drawing.Size(448, 45);
            this.lblShowWord.TabIndex = 5;
            this.lblShowWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "b";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "c";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(314, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "ć";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(356, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 30);
            this.button5.TabIndex = 7;
            this.button5.Text = "d";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(398, 372);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 30);
            this.button6.TabIndex = 12;
            this.button6.Text = "e";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(440, 372);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 30);
            this.button7.TabIndex = 11;
            this.button7.Text = "ę";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(481, 372);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 30);
            this.button8.TabIndex = 10;
            this.button8.Text = "f";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(523, 372);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 30);
            this.button9.TabIndex = 15;
            this.button9.Text = "g";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(565, 372);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 30);
            this.button10.TabIndex = 14;
            this.button10.Text = "h";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(610, 372);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 30);
            this.button11.TabIndex = 13;
            this.button11.Text = "i";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(146, 406);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 30);
            this.button12.TabIndex = 18;
            this.button12.Text = "j";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(188, 406);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(36, 30);
            this.button13.TabIndex = 17;
            this.button13.Text = "k";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(230, 406);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 30);
            this.button14.TabIndex = 16;
            this.button14.Text = "l";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(272, 406);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(36, 30);
            this.button15.TabIndex = 33;
            this.button15.Text = "ł";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(314, 406);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(36, 30);
            this.button16.TabIndex = 32;
            this.button16.Text = "m";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(356, 406);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(36, 30);
            this.button17.TabIndex = 31;
            this.button17.Text = "n";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(398, 406);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(36, 30);
            this.button18.TabIndex = 30;
            this.button18.Text = "ń";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(440, 406);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(36, 30);
            this.button19.TabIndex = 29;
            this.button19.Text = "o";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(481, 406);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(36, 30);
            this.button20.TabIndex = 28;
            this.button20.Text = "ó";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(523, 406);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(36, 30);
            this.button21.TabIndex = 27;
            this.button21.Text = "p";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(565, 406);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(36, 30);
            this.button22.TabIndex = 26;
            this.button22.Text = "q";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(610, 406);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(36, 30);
            this.button23.TabIndex = 25;
            this.button23.Text = "r";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(146, 442);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(36, 30);
            this.button24.TabIndex = 24;
            this.button24.Text = "s";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(188, 442);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(36, 30);
            this.button25.TabIndex = 23;
            this.button25.Text = "ś";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(230, 442);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(36, 30);
            this.button26.TabIndex = 22;
            this.button26.Text = "t";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(272, 442);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(36, 30);
            this.button27.TabIndex = 21;
            this.button27.Text = "u";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(314, 442);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(36, 30);
            this.button28.TabIndex = 20;
            this.button28.Text = "v";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(356, 442);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(36, 30);
            this.button29.TabIndex = 19;
            this.button29.Text = "w";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(398, 442);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(36, 30);
            this.button30.TabIndex = 38;
            this.button30.Text = "x";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(440, 442);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(36, 30);
            this.button31.TabIndex = 37;
            this.button31.Text = "y";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(481, 442);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(36, 30);
            this.button32.TabIndex = 36;
            this.button32.Text = "z";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(523, 442);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(36, 30);
            this.button33.TabIndex = 35;
            this.button33.Text = "ź";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(565, 442);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(36, 30);
            this.button34.TabIndex = 34;
            this.button34.Text = "ż";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Kategoria: Męskie imiona";
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmdB);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.hangImage);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHangman";
            this.Text = "Easy";
            this.Load += new System.EventHandler(this.frmHangman_Load);
            this.Click += new System.EventHandler(this.cmdA_Click);
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox hangImage;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button cmdB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblShowWord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Label label1;
    }
}