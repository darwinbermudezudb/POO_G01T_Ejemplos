namespace Ejercicio1
{
    partial class Principal
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
            this.tabPestañas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTv = new System.Windows.Forms.Label();
            this.picTv = new System.Windows.Forms.PictureBox();
            this.lstTvShows = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblLibros = new System.Windows.Forms.Label();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbLenguajes = new System.Windows.Forms.ComboBox();
            this.lblLenguajes = new System.Windows.Forms.Label();
            this.lblTotalLibros = new System.Windows.Forms.Label();
            this.lblPromedioPaginas = new System.Windows.Forms.Label();
            this.lblTotalProgramasTV = new System.Windows.Forms.Label();
            this.lblTotalEpisodios = new System.Windows.Forms.Label();
            this.lblTotalLenguajes = new System.Windows.Forms.Label();
            this.tabPestañas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPestañas
            // 
            this.tabPestañas.Controls.Add(this.tabPage1);
            this.tabPestañas.Controls.Add(this.tabPage2);
            this.tabPestañas.Controls.Add(this.tabPage3);
            this.tabPestañas.Controls.Add(this.tabPage4);
            this.tabPestañas.Location = new System.Drawing.Point(12, 12);
            this.tabPestañas.Name = "tabPestañas";
            this.tabPestañas.SelectedIndex = 0;
            this.tabPestañas.Size = new System.Drawing.Size(776, 426);
            this.tabPestañas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTv);
            this.tabPage1.Controls.Add(this.picTv);
            this.tabPage1.Controls.Add(this.lstTvShows);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "T.V Shows";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTv
            // 
            this.lblTv.Location = new System.Drawing.Point(180, 173);
            this.lblTv.Name = "lblTv";
            this.lblTv.Size = new System.Drawing.Size(574, 207);
            this.lblTv.TabIndex = 2;
            // 
            // picTv
            // 
            this.picTv.Location = new System.Drawing.Point(23, 173);
            this.picTv.Name = "picTv";
            this.picTv.Size = new System.Drawing.Size(126, 153);
            this.picTv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTv.TabIndex = 1;
            this.picTv.TabStop = false;
            // 
            // lstTvShows
            // 
            this.lstTvShows.FormattingEnabled = true;
            this.lstTvShows.ItemHeight = 20;
            this.lstTvShows.Location = new System.Drawing.Point(139, 44);
            this.lstTvShows.Name = "lstTvShows";
            this.lstTvShows.Size = new System.Drawing.Size(196, 84);
            this.lstTvShows.TabIndex = 0;
            this.lstTvShows.SelectedIndexChanged += new System.EventHandler(this.lstTvShows_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblLibros);
            this.tabPage2.Controls.Add(this.cmbLibros);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Libros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblLibros
            // 
            this.lblLibros.Location = new System.Drawing.Point(194, 138);
            this.lblLibros.Name = "lblLibros";
            this.lblLibros.Size = new System.Drawing.Size(557, 252);
            this.lblLibros.TabIndex = 1;
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(194, 70);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(169, 28);
            this.cmbLibros.TabIndex = 0;
            this.cmbLibros.SelectedIndexChanged += new System.EventHandler(this.cmbLibros_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblLenguajes);
            this.tabPage3.Controls.Add(this.cmbLenguajes);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lenguajes Programación";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblTotalLenguajes);
            this.tabPage4.Controls.Add(this.lblTotalEpisodios);
            this.tabPage4.Controls.Add(this.lblTotalProgramasTV);
            this.tabPage4.Controls.Add(this.lblPromedioPaginas);
            this.tabPage4.Controls.Add(this.lblTotalLibros);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Estadisticas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbLenguajes
            // 
            this.cmbLenguajes.FormattingEnabled = true;
            this.cmbLenguajes.Location = new System.Drawing.Point(176, 56);
            this.cmbLenguajes.Name = "cmbLenguajes";
            this.cmbLenguajes.Size = new System.Drawing.Size(200, 28);
            this.cmbLenguajes.TabIndex = 0;
            this.cmbLenguajes.SelectedIndexChanged += new System.EventHandler(this.cmbLenguajes_SelectedIndexChanged);
            // 
            // lblLenguajes
            // 
            this.lblLenguajes.Location = new System.Drawing.Point(139, 129);
            this.lblLenguajes.Name = "lblLenguajes";
            this.lblLenguajes.Size = new System.Drawing.Size(605, 246);
            this.lblLenguajes.TabIndex = 1;
            // 
            // lblTotalLibros
            // 
            this.lblTotalLibros.AutoSize = true;
            this.lblTotalLibros.Location = new System.Drawing.Point(76, 95);
            this.lblTotalLibros.Name = "lblTotalLibros";
            this.lblTotalLibros.Size = new System.Drawing.Size(89, 20);
            this.lblTotalLibros.TabIndex = 0;
            this.lblTotalLibros.Text = "Total libros:";
            // 
            // lblPromedioPaginas
            // 
            this.lblPromedioPaginas.AutoSize = true;
            this.lblPromedioPaginas.Location = new System.Drawing.Point(78, 145);
            this.lblPromedioPaginas.Name = "lblPromedioPaginas";
            this.lblPromedioPaginas.Size = new System.Drawing.Size(141, 20);
            this.lblPromedioPaginas.TabIndex = 1;
            this.lblPromedioPaginas.Text = "Promedio Paginas:";
            // 
            // lblTotalProgramasTV
            // 
            this.lblTotalProgramasTV.AutoSize = true;
            this.lblTotalProgramasTV.Location = new System.Drawing.Point(80, 199);
            this.lblTotalProgramasTV.Name = "lblTotalProgramasTV";
            this.lblTotalProgramasTV.Size = new System.Drawing.Size(81, 20);
            this.lblTotalProgramasTV.TabIndex = 2;
            this.lblTotalProgramasTV.Text = "Tv Shows:";
            // 
            // lblTotalEpisodios
            // 
            this.lblTotalEpisodios.AutoSize = true;
            this.lblTotalEpisodios.Location = new System.Drawing.Point(80, 247);
            this.lblTotalEpisodios.Name = "lblTotalEpisodios";
            this.lblTotalEpisodios.Size = new System.Drawing.Size(82, 20);
            this.lblTotalEpisodios.TabIndex = 3;
            this.lblTotalEpisodios.Text = "Episodios:";
            // 
            // lblTotalLenguajes
            // 
            this.lblTotalLenguajes.AutoSize = true;
            this.lblTotalLenguajes.Location = new System.Drawing.Point(80, 305);
            this.lblTotalLenguajes.Name = "lblTotalLenguajes";
            this.lblTotalLenguajes.Size = new System.Drawing.Size(243, 20);
            this.lblTotalLenguajes.TabIndex = 4;
            this.lblTotalLenguajes.Text = "Total de lenguajes programacion:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.tabPestañas);
            this.Name = "Principal";
            this.Text = "Principal";
            this.tabPestañas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPestañas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lstTvShows;
        private System.Windows.Forms.Label lblTv;
        private System.Windows.Forms.PictureBox picTv;
        private System.Windows.Forms.Label lblLibros;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Label lblLenguajes;
        private System.Windows.Forms.ComboBox cmbLenguajes;
        private System.Windows.Forms.Label lblTotalLenguajes;
        private System.Windows.Forms.Label lblTotalEpisodios;
        private System.Windows.Forms.Label lblTotalProgramasTV;
        private System.Windows.Forms.Label lblPromedioPaginas;
        private System.Windows.Forms.Label lblTotalLibros;
    }
}