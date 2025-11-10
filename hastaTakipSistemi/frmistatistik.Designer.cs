namespace hastaTakipSistemi
{
    partial class frmistatistik
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.hastasayısı = new System.Windows.Forms.Label();
            this.yasSayısı = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.erkekhasta = new System.Windows.Forms.Label();
            this.kadınhasta = new System.Windows.Forms.Label();
            this.exhasta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.exhasta, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.kadınhasta, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.erkekhasta, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.hastasayısı, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.yasSayısı, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1018, 63);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1012, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA TAKİP SİSTEMİ V01-İSTATİSTİKLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hastasayısı
            // 
            this.hastasayısı.AutoSize = true;
            this.hastasayısı.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hastasayısı.Location = new System.Drawing.Point(3, 0);
            this.hastasayısı.Name = "hastasayısı";
            this.hastasayısı.Size = new System.Drawing.Size(503, 76);
            this.hastasayısı.TabIndex = 0;
            this.hastasayısı.Text = "TOPLAM KAYITLI HASTA SAYISI";
            this.hastasayısı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yasSayısı
            // 
            this.yasSayısı.AutoSize = true;
            this.yasSayısı.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yasSayısı.Location = new System.Drawing.Point(3, 76);
            this.yasSayısı.Name = "yasSayısı";
            this.yasSayısı.Size = new System.Drawing.Size(503, 76);
            this.yasSayısı.TabIndex = 1;
            this.yasSayısı.Text = "YAŞ ORTALAMASI";
            this.yasSayısı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(512, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(503, 76);
            this.label4.TabIndex = 2;
            this.label4.Text = "00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(512, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(503, 76);
            this.label5.TabIndex = 3;
            this.label5.Text = "00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // erkekhasta
            // 
            this.erkekhasta.AutoSize = true;
            this.erkekhasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.erkekhasta.Location = new System.Drawing.Point(3, 152);
            this.erkekhasta.Name = "erkekhasta";
            this.erkekhasta.Size = new System.Drawing.Size(503, 76);
            this.erkekhasta.TabIndex = 4;
            this.erkekhasta.Text = "ERKEK HASTA SAYISI";
            this.erkekhasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kadınhasta
            // 
            this.kadınhasta.AutoSize = true;
            this.kadınhasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kadınhasta.Location = new System.Drawing.Point(3, 228);
            this.kadınhasta.Name = "kadınhasta";
            this.kadınhasta.Size = new System.Drawing.Size(503, 76);
            this.kadınhasta.TabIndex = 6;
            this.kadınhasta.Text = "KADIN HASTA SAYISI";
            this.kadınhasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exhasta
            // 
            this.exhasta.AutoSize = true;
            this.exhasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exhasta.Location = new System.Drawing.Point(3, 304);
            this.exhasta.Name = "exhasta";
            this.exhasta.Size = new System.Drawing.Size(503, 80);
            this.exhasta.TabIndex = 8;
            this.exhasta.Text = "EX HASTA SAYISI";
            this.exhasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(512, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(503, 76);
            this.label7.TabIndex = 9;
            this.label7.Text = "00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(512, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(503, 76);
            this.label9.TabIndex = 10;
            this.label9.Text = "00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(512, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(503, 80);
            this.label11.TabIndex = 11;
            this.label11.Text = "00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmistatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmistatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmistatistik";
            this.Load += new System.EventHandler(this.frmistatistik_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hastasayısı;
        private System.Windows.Forms.Label yasSayısı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label exhasta;
        private System.Windows.Forms.Label kadınhasta;
        private System.Windows.Forms.Label erkekhasta;
    }
}