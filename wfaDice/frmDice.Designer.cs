namespace wfaDice
{
    partial class FrmDice
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblFonteOriginalGDI = new System.Windows.Forms.Label();
            this.CmdRollDice = new System.Windows.Forms.Button();
            this.Cmd0 = new System.Windows.Forms.Button();
            this.Cmd1 = new System.Windows.Forms.Button();
            this.Cmd2 = new System.Windows.Forms.Button();
            this.Cmd3 = new System.Windows.Forms.Button();
            this.Cmd4 = new System.Windows.Forms.Button();
            this.Cmd7 = new System.Windows.Forms.Button();
            this.Cmd6 = new System.Windows.Forms.Button();
            this.Cmd5 = new System.Windows.Forms.Button();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblActiveXControlGDI = new System.Windows.Forms.Label();
            this.LblFonteOriginalSkiasharp = new System.Windows.Forms.Label();
            this.LblNumeroSkia = new System.Windows.Forms.Label();
            this.Cmd7Skia = new System.Windows.Forms.Button();
            this.Cmd6Skia = new System.Windows.Forms.Button();
            this.Cmd5Skia = new System.Windows.Forms.Button();
            this.Cmd4Skia = new System.Windows.Forms.Button();
            this.Cmd3Skia = new System.Windows.Forms.Button();
            this.Cmd2Skia = new System.Windows.Forms.Button();
            this.Cmd1Skia = new System.Windows.Forms.Button();
            this.Cmd0Skia = new System.Windows.Forms.Button();
            this.CmdRollDiceSkiasharp = new System.Windows.Forms.Button();
            this.pcbDiceSkiasharp = new System.Windows.Forms.PictureBox();
            this.LblActiveXControlSkiasharp = new System.Windows.Forms.Label();
            this.ucDiceSkia1 = new clsDiceSkiasharp.UcDiceSkia();
            this.ucDiceGDI1 = new clsDiceGDI.UcDiceGDI();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDiceSkiasharp)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFonteOriginalGDI
            // 
            this.LblFonteOriginalGDI.AutoSize = true;
            this.LblFonteOriginalGDI.Location = new System.Drawing.Point(158, 9);
            this.LblFonteOriginalGDI.Name = "LblFonteOriginalGDI";
            this.LblFonteOriginalGDI.Size = new System.Drawing.Size(97, 13);
            this.LblFonteOriginalGDI.TabIndex = 0;
            this.LblFonteOriginalGDI.Text = "Fonte Original GDI:";
            // 
            // CmdRollDice
            // 
            this.CmdRollDice.Location = new System.Drawing.Point(161, 194);
            this.CmdRollDice.Name = "CmdRollDice";
            this.CmdRollDice.Size = new System.Drawing.Size(134, 19);
            this.CmdRollDice.TabIndex = 1;
            this.CmdRollDice.Text = "&Roll Dice GDI";
            this.CmdRollDice.UseVisualStyleBackColor = true;
            this.CmdRollDice.Click += new System.EventHandler(this.CmdRollDice_Click);
            // 
            // Cmd0
            // 
            this.Cmd0.Location = new System.Drawing.Point(161, 219);
            this.Cmd0.Name = "Cmd0";
            this.Cmd0.Size = new System.Drawing.Size(22, 23);
            this.Cmd0.TabIndex = 3;
            this.Cmd0.Text = "&0";
            this.Cmd0.UseVisualStyleBackColor = true;
            this.Cmd0.Click += new System.EventHandler(this.Cmd0_Click);
            // 
            // Cmd1
            // 
            this.Cmd1.Location = new System.Drawing.Point(189, 219);
            this.Cmd1.Name = "Cmd1";
            this.Cmd1.Size = new System.Drawing.Size(22, 23);
            this.Cmd1.TabIndex = 4;
            this.Cmd1.Text = "&1";
            this.Cmd1.UseVisualStyleBackColor = true;
            this.Cmd1.Click += new System.EventHandler(this.Cmd1_Click);
            // 
            // Cmd2
            // 
            this.Cmd2.Location = new System.Drawing.Point(217, 219);
            this.Cmd2.Name = "Cmd2";
            this.Cmd2.Size = new System.Drawing.Size(22, 23);
            this.Cmd2.TabIndex = 5;
            this.Cmd2.Text = "&2";
            this.Cmd2.UseVisualStyleBackColor = true;
            this.Cmd2.Click += new System.EventHandler(this.Cmd2_Click);
            // 
            // Cmd3
            // 
            this.Cmd3.Location = new System.Drawing.Point(245, 219);
            this.Cmd3.Name = "Cmd3";
            this.Cmd3.Size = new System.Drawing.Size(22, 23);
            this.Cmd3.TabIndex = 6;
            this.Cmd3.Text = "&3";
            this.Cmd3.UseVisualStyleBackColor = true;
            this.Cmd3.Click += new System.EventHandler(this.Cmd3_Click);
            // 
            // Cmd4
            // 
            this.Cmd4.Location = new System.Drawing.Point(273, 219);
            this.Cmd4.Name = "Cmd4";
            this.Cmd4.Size = new System.Drawing.Size(22, 23);
            this.Cmd4.TabIndex = 7;
            this.Cmd4.Text = "&4";
            this.Cmd4.UseVisualStyleBackColor = true;
            this.Cmd4.Click += new System.EventHandler(this.Cmd4_Click);
            // 
            // Cmd7
            // 
            this.Cmd7.Location = new System.Drawing.Point(217, 248);
            this.Cmd7.Name = "Cmd7";
            this.Cmd7.Size = new System.Drawing.Size(22, 23);
            this.Cmd7.TabIndex = 10;
            this.Cmd7.Text = "&7";
            this.Cmd7.UseVisualStyleBackColor = true;
            this.Cmd7.Click += new System.EventHandler(this.Cmd7_Click);
            // 
            // Cmd6
            // 
            this.Cmd6.Location = new System.Drawing.Point(189, 248);
            this.Cmd6.Name = "Cmd6";
            this.Cmd6.Size = new System.Drawing.Size(22, 23);
            this.Cmd6.TabIndex = 9;
            this.Cmd6.Text = "&6";
            this.Cmd6.UseVisualStyleBackColor = true;
            this.Cmd6.Click += new System.EventHandler(this.Cmd6_Click);
            // 
            // Cmd5
            // 
            this.Cmd5.Location = new System.Drawing.Point(161, 248);
            this.Cmd5.Name = "Cmd5";
            this.Cmd5.Size = new System.Drawing.Size(22, 23);
            this.Cmd5.TabIndex = 8;
            this.Cmd5.Text = "&5";
            this.Cmd5.UseVisualStyleBackColor = true;
            this.Cmd5.Click += new System.EventHandler(this.Cmd5_Click);
            // 
            // LblNumero
            // 
            this.LblNumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNumero.Location = new System.Drawing.Point(245, 248);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(50, 23);
            this.LblNumero.TabIndex = 11;
            this.LblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblActiveXControlGDI
            // 
            this.LblActiveXControlGDI.AutoSize = true;
            this.LblActiveXControlGDI.Location = new System.Drawing.Point(12, 9);
            this.LblActiveXControlGDI.Name = "LblActiveXControlGDI";
            this.LblActiveXControlGDI.Size = new System.Drawing.Size(105, 13);
            this.LblActiveXControlGDI.TabIndex = 12;
            this.LblActiveXControlGDI.Text = "ActiveX Control GDI:";
            // 
            // LblFonteOriginalSkiasharp
            // 
            this.LblFonteOriginalSkiasharp.AutoSize = true;
            this.LblFonteOriginalSkiasharp.Location = new System.Drawing.Point(460, 9);
            this.LblFonteOriginalSkiasharp.Name = "LblFonteOriginalSkiasharp";
            this.LblFonteOriginalSkiasharp.Size = new System.Drawing.Size(125, 13);
            this.LblFonteOriginalSkiasharp.TabIndex = 14;
            this.LblFonteOriginalSkiasharp.Text = "Fonte Original Skiasharp:";
            // 
            // LblNumeroSkia
            // 
            this.LblNumeroSkia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNumeroSkia.Location = new System.Drawing.Point(549, 246);
            this.LblNumeroSkia.Name = "LblNumeroSkia";
            this.LblNumeroSkia.Size = new System.Drawing.Size(50, 23);
            this.LblNumeroSkia.TabIndex = 24;
            this.LblNumeroSkia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmd7Skia
            // 
            this.Cmd7Skia.Location = new System.Drawing.Point(521, 246);
            this.Cmd7Skia.Name = "Cmd7Skia";
            this.Cmd7Skia.Size = new System.Drawing.Size(22, 23);
            this.Cmd7Skia.TabIndex = 23;
            this.Cmd7Skia.Text = "&7";
            this.Cmd7Skia.UseVisualStyleBackColor = true;
            this.Cmd7Skia.Click += new System.EventHandler(this.Cmd7Skia_Click);
            // 
            // Cmd6Skia
            // 
            this.Cmd6Skia.Location = new System.Drawing.Point(493, 246);
            this.Cmd6Skia.Name = "Cmd6Skia";
            this.Cmd6Skia.Size = new System.Drawing.Size(22, 23);
            this.Cmd6Skia.TabIndex = 22;
            this.Cmd6Skia.Text = "&6";
            this.Cmd6Skia.UseVisualStyleBackColor = true;
            this.Cmd6Skia.Click += new System.EventHandler(this.Cmd6Skia_Click);
            // 
            // Cmd5Skia
            // 
            this.Cmd5Skia.Location = new System.Drawing.Point(465, 246);
            this.Cmd5Skia.Name = "Cmd5Skia";
            this.Cmd5Skia.Size = new System.Drawing.Size(22, 23);
            this.Cmd5Skia.TabIndex = 21;
            this.Cmd5Skia.Text = "&5";
            this.Cmd5Skia.UseVisualStyleBackColor = true;
            this.Cmd5Skia.Click += new System.EventHandler(this.Cmd5Skia_Click);
            // 
            // Cmd4Skia
            // 
            this.Cmd4Skia.Location = new System.Drawing.Point(577, 217);
            this.Cmd4Skia.Name = "Cmd4Skia";
            this.Cmd4Skia.Size = new System.Drawing.Size(22, 23);
            this.Cmd4Skia.TabIndex = 20;
            this.Cmd4Skia.Text = "&4";
            this.Cmd4Skia.UseVisualStyleBackColor = true;
            this.Cmd4Skia.Click += new System.EventHandler(this.Cmd4Skia_Click);
            // 
            // Cmd3Skia
            // 
            this.Cmd3Skia.Location = new System.Drawing.Point(549, 217);
            this.Cmd3Skia.Name = "Cmd3Skia";
            this.Cmd3Skia.Size = new System.Drawing.Size(22, 23);
            this.Cmd3Skia.TabIndex = 19;
            this.Cmd3Skia.Text = "&3";
            this.Cmd3Skia.UseVisualStyleBackColor = true;
            this.Cmd3Skia.Click += new System.EventHandler(this.Cmd3Skia_Click);
            // 
            // Cmd2Skia
            // 
            this.Cmd2Skia.Location = new System.Drawing.Point(521, 217);
            this.Cmd2Skia.Name = "Cmd2Skia";
            this.Cmd2Skia.Size = new System.Drawing.Size(22, 23);
            this.Cmd2Skia.TabIndex = 18;
            this.Cmd2Skia.Text = "&2";
            this.Cmd2Skia.UseVisualStyleBackColor = true;
            this.Cmd2Skia.Click += new System.EventHandler(this.Cmd2Skia_Click);
            // 
            // Cmd1Skia
            // 
            this.Cmd1Skia.Location = new System.Drawing.Point(493, 217);
            this.Cmd1Skia.Name = "Cmd1Skia";
            this.Cmd1Skia.Size = new System.Drawing.Size(22, 23);
            this.Cmd1Skia.TabIndex = 17;
            this.Cmd1Skia.Text = "&1";
            this.Cmd1Skia.UseVisualStyleBackColor = true;
            this.Cmd1Skia.Click += new System.EventHandler(this.Cmd1Skia_Click);
            // 
            // Cmd0Skia
            // 
            this.Cmd0Skia.Location = new System.Drawing.Point(465, 217);
            this.Cmd0Skia.Name = "Cmd0Skia";
            this.Cmd0Skia.Size = new System.Drawing.Size(22, 23);
            this.Cmd0Skia.TabIndex = 16;
            this.Cmd0Skia.Text = "&0";
            this.Cmd0Skia.UseVisualStyleBackColor = true;
            this.Cmd0Skia.Click += new System.EventHandler(this.Cmd0Skia_Click);
            // 
            // CmdRollDiceSkiasharp
            // 
            this.CmdRollDiceSkiasharp.Location = new System.Drawing.Point(465, 192);
            this.CmdRollDiceSkiasharp.Name = "CmdRollDiceSkiasharp";
            this.CmdRollDiceSkiasharp.Size = new System.Drawing.Size(134, 19);
            this.CmdRollDiceSkiasharp.TabIndex = 15;
            this.CmdRollDiceSkiasharp.Text = "&Roll Dice";
            this.CmdRollDiceSkiasharp.UseVisualStyleBackColor = true;
            this.CmdRollDiceSkiasharp.Click += new System.EventHandler(this.CmdRollDiceSkiasharp_Click);
            // 
            // pcbDiceSkiasharp
            // 
            this.pcbDiceSkiasharp.BackColor = System.Drawing.SystemColors.Control;
            this.pcbDiceSkiasharp.Location = new System.Drawing.Point(456, 37);
            this.pcbDiceSkiasharp.Name = "pcbDiceSkiasharp";
            this.pcbDiceSkiasharp.Size = new System.Drawing.Size(150, 150);
            this.pcbDiceSkiasharp.TabIndex = 25;
            this.pcbDiceSkiasharp.TabStop = false;
            // 
            // LblActiveXControlSkiasharp
            // 
            this.LblActiveXControlSkiasharp.AutoSize = true;
            this.LblActiveXControlSkiasharp.Location = new System.Drawing.Point(308, 9);
            this.LblActiveXControlSkiasharp.Name = "LblActiveXControlSkiasharp";
            this.LblActiveXControlSkiasharp.Size = new System.Drawing.Size(133, 13);
            this.LblActiveXControlSkiasharp.TabIndex = 27;
            this.LblActiveXControlSkiasharp.Text = "ActiveX Control Skiasharp:";
            // 
            // ucDiceSkia1
            // 
            this.ucDiceSkia1.Location = new System.Drawing.Point(299, 35);
            this.ucDiceSkia1.Name = "ucDiceSkia1";
            this.ucDiceSkia1.Size = new System.Drawing.Size(156, 238);
            this.ucDiceSkia1.TabIndex = 26;
            // 
            // ucDiceGDI1
            // 
            this.ucDiceGDI1.Location = new System.Drawing.Point(12, 46);
            this.ucDiceGDI1.Name = "ucDiceGDI1";
            this.ucDiceGDI1.Size = new System.Drawing.Size(141, 228);
            this.ucDiceGDI1.TabIndex = 13;
            // 
            // FrmDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 282);
            this.Controls.Add(this.LblActiveXControlSkiasharp);
            this.Controls.Add(this.ucDiceSkia1);
            this.Controls.Add(this.pcbDiceSkiasharp);
            this.Controls.Add(this.LblNumeroSkia);
            this.Controls.Add(this.Cmd7Skia);
            this.Controls.Add(this.Cmd6Skia);
            this.Controls.Add(this.Cmd5Skia);
            this.Controls.Add(this.Cmd4Skia);
            this.Controls.Add(this.Cmd3Skia);
            this.Controls.Add(this.Cmd2Skia);
            this.Controls.Add(this.Cmd1Skia);
            this.Controls.Add(this.Cmd0Skia);
            this.Controls.Add(this.CmdRollDiceSkiasharp);
            this.Controls.Add(this.LblFonteOriginalSkiasharp);
            this.Controls.Add(this.ucDiceGDI1);
            this.Controls.Add(this.LblActiveXControlGDI);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.Cmd7);
            this.Controls.Add(this.Cmd6);
            this.Controls.Add(this.Cmd5);
            this.Controls.Add(this.Cmd4);
            this.Controls.Add(this.Cmd3);
            this.Controls.Add(this.Cmd2);
            this.Controls.Add(this.Cmd1);
            this.Controls.Add(this.Cmd0);
            this.Controls.Add(this.CmdRollDice);
            this.Controls.Add(this.LblFonteOriginalGDI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDice";
            this.ShowIcon = false;
            this.Text = "DICE";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmDice_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDiceSkiasharp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFonteOriginalGDI;
        private System.Windows.Forms.Button CmdRollDice;
        private System.Windows.Forms.Button Cmd0;
        private System.Windows.Forms.Button Cmd1;
        private System.Windows.Forms.Button Cmd2;
        private System.Windows.Forms.Button Cmd3;
        private System.Windows.Forms.Button Cmd4;
        private System.Windows.Forms.Button Cmd7;
        private System.Windows.Forms.Button Cmd6;
        private System.Windows.Forms.Button Cmd5;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblActiveXControlGDI;
        private clsDiceGDI.UcDiceGDI ucDiceGDI1;
        private System.Windows.Forms.Label LblFonteOriginalSkiasharp;
        private System.Windows.Forms.Label LblNumeroSkia;
        private System.Windows.Forms.Button Cmd7Skia;
        private System.Windows.Forms.Button Cmd6Skia;
        private System.Windows.Forms.Button Cmd5Skia;
        private System.Windows.Forms.Button Cmd4Skia;
        private System.Windows.Forms.Button Cmd3Skia;
        private System.Windows.Forms.Button Cmd2Skia;
        private System.Windows.Forms.Button Cmd1Skia;
        private System.Windows.Forms.Button Cmd0Skia;
        private System.Windows.Forms.Button CmdRollDiceSkiasharp;
        private System.Windows.Forms.PictureBox pcbDiceSkiasharp;
        private clsDiceSkiasharp.UcDiceSkia ucDiceSkia1;
        private System.Windows.Forms.Label LblActiveXControlSkiasharp;
    }
}

