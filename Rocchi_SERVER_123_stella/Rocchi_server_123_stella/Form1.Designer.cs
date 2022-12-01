
namespace Rocchi_server_123_stella
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_titolo = new System.Windows.Forms.Panel();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.btn_fermi = new System.Windows.Forms.Button();
            this.panel_campo = new System.Windows.Forms.Panel();
            this.lbl_mov_G2 = new System.Windows.Forms.Label();
            this.lbl_mov_G1 = new System.Windows.Forms.Label();
            this.lbl_g2 = new System.Windows.Forms.Label();
            this.lbl_g1 = new System.Windows.Forms.Label();
            this.lbl_capo = new System.Windows.Forms.Label();
            this.pic_g2 = new System.Windows.Forms.PictureBox();
            this.pic_g1 = new System.Windows.Forms.PictureBox();
            this.pic_arbitro = new System.Windows.Forms.PictureBox();
            this.tmr_controllo = new System.Windows.Forms.Timer(this.components);
            this.btn_attiva = new System.Windows.Forms.Button();
            this.tmr_durataMovimento = new System.Windows.Forms.Timer(this.components);
            this.list_errori = new System.Windows.Forms.ListBox();
            this.panel_titolo.SuspendLayout();
            this.panel_campo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_g2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_g1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_arbitro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titolo
            // 
            this.panel_titolo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_titolo.BackColor = System.Drawing.SystemColors.Info;
            this.panel_titolo.Controls.Add(this.lbl_titolo);
            this.panel_titolo.Controls.Add(this.lbl_tipo);
            this.panel_titolo.Location = new System.Drawing.Point(9, 16);
            this.panel_titolo.Margin = new System.Windows.Forms.Padding(4);
            this.panel_titolo.Name = "panel_titolo";
            this.panel_titolo.Size = new System.Drawing.Size(1835, 69);
            this.panel_titolo.TabIndex = 0;
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(712, 16);
            this.lbl_titolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(384, 42);
            this.lbl_titolo.TabIndex = 1;
            this.lbl_titolo.Text = "        1, 2, 3 STELLA!";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(4, 0);
            this.lbl_tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(83, 20);
            this.lbl_tipo.TabIndex = 0;
            this.lbl_tipo.Text = "SERVER";
            // 
            // btn_fermi
            // 
            this.btn_fermi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(118)))));
            this.btn_fermi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermi.Location = new System.Drawing.Point(1647, 92);
            this.btn_fermi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fermi.Name = "btn_fermi";
            this.btn_fermi.Size = new System.Drawing.Size(197, 90);
            this.btn_fermi.TabIndex = 1;
            this.btn_fermi.Text = "Ferma giocatori!";
            this.btn_fermi.UseVisualStyleBackColor = false;
            this.btn_fermi.Click += new System.EventHandler(this.btn_fermi_Click);
            // 
            // panel_campo
            // 
            this.panel_campo.BackColor = System.Drawing.Color.Cornsilk;
            this.panel_campo.Controls.Add(this.lbl_mov_G2);
            this.panel_campo.Controls.Add(this.lbl_mov_G1);
            this.panel_campo.Controls.Add(this.lbl_g2);
            this.panel_campo.Controls.Add(this.lbl_g1);
            this.panel_campo.Controls.Add(this.lbl_capo);
            this.panel_campo.Controls.Add(this.pic_g2);
            this.panel_campo.Controls.Add(this.pic_g1);
            this.panel_campo.Controls.Add(this.pic_arbitro);
            this.panel_campo.Location = new System.Drawing.Point(9, 190);
            this.panel_campo.Margin = new System.Windows.Forms.Padding(4);
            this.panel_campo.Name = "panel_campo";
            this.panel_campo.Size = new System.Drawing.Size(1835, 615);
            this.panel_campo.TabIndex = 2;
            // 
            // lbl_mov_G2
            // 
            this.lbl_mov_G2.AutoSize = true;
            this.lbl_mov_G2.Location = new System.Drawing.Point(102, 512);
            this.lbl_mov_G2.Name = "lbl_mov_G2";
            this.lbl_mov_G2.Size = new System.Drawing.Size(0, 17);
            this.lbl_mov_G2.TabIndex = 7;
            // 
            // lbl_mov_G1
            // 
            this.lbl_mov_G1.AutoSize = true;
            this.lbl_mov_G1.Location = new System.Drawing.Point(102, 168);
            this.lbl_mov_G1.Name = "lbl_mov_G1";
            this.lbl_mov_G1.Size = new System.Drawing.Size(0, 17);
            this.lbl_mov_G1.TabIndex = 6;
            // 
            // lbl_g2
            // 
            this.lbl_g2.AutoSize = true;
            this.lbl_g2.Location = new System.Drawing.Point(45, 506);
            this.lbl_g2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_g2.Name = "lbl_g2";
            this.lbl_g2.Size = new System.Drawing.Size(27, 17);
            this.lbl_g2.TabIndex = 5;
            this.lbl_g2.Text = "G2";
            // 
            // lbl_g1
            // 
            this.lbl_g1.AutoSize = true;
            this.lbl_g1.Location = new System.Drawing.Point(45, 168);
            this.lbl_g1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_g1.Name = "lbl_g1";
            this.lbl_g1.Size = new System.Drawing.Size(27, 17);
            this.lbl_g1.TabIndex = 4;
            this.lbl_g1.Text = "G1";
            // 
            // lbl_capo
            // 
            this.lbl_capo.AutoSize = true;
            this.lbl_capo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_capo.Location = new System.Drawing.Point(1507, 80);
            this.lbl_capo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_capo.Name = "lbl_capo";
            this.lbl_capo.Size = new System.Drawing.Size(72, 24);
            this.lbl_capo.TabIndex = 3;
            this.lbl_capo.Text = "Arbitro";
            // 
            // pic_g2
            // 
            this.pic_g2.Location = new System.Drawing.Point(45, 386);
            this.pic_g2.Margin = new System.Windows.Forms.Padding(4);
            this.pic_g2.Name = "pic_g2";
            this.pic_g2.Size = new System.Drawing.Size(123, 111);
            this.pic_g2.TabIndex = 2;
            this.pic_g2.TabStop = false;
            // 
            // pic_g1
            // 
            this.pic_g1.Location = new System.Drawing.Point(45, 53);
            this.pic_g1.Margin = new System.Windows.Forms.Padding(4);
            this.pic_g1.Name = "pic_g1";
            this.pic_g1.Size = new System.Drawing.Size(123, 111);
            this.pic_g1.TabIndex = 1;
            this.pic_g1.TabStop = false;
            // 
            // pic_arbitro
            // 
            this.pic_arbitro.ErrorImage = null;
            this.pic_arbitro.Image = ((System.Drawing.Image)(resources.GetObject("pic_arbitro.Image")));
            this.pic_arbitro.Location = new System.Drawing.Point(1511, 106);
            this.pic_arbitro.Margin = new System.Windows.Forms.Padding(4);
            this.pic_arbitro.Name = "pic_arbitro";
            this.pic_arbitro.Size = new System.Drawing.Size(269, 327);
            this.pic_arbitro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_arbitro.TabIndex = 0;
            this.pic_arbitro.TabStop = false;
            // 
            // tmr_controllo
            // 
            this.tmr_controllo.Enabled = true;
            this.tmr_controllo.Interval = 2000;
            this.tmr_controllo.Tick += new System.EventHandler(this.tmr_controllo_Tick);
            // 
            // btn_attiva
            // 
            this.btn_attiva.BackColor = System.Drawing.Color.Yellow;
            this.btn_attiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attiva.Location = new System.Drawing.Point(9, 92);
            this.btn_attiva.Margin = new System.Windows.Forms.Padding(4);
            this.btn_attiva.Name = "btn_attiva";
            this.btn_attiva.Size = new System.Drawing.Size(197, 90);
            this.btn_attiva.TabIndex = 3;
            this.btn_attiva.Text = "ATTIVA";
            this.btn_attiva.UseVisualStyleBackColor = false;
            this.btn_attiva.Click += new System.EventHandler(this.btn_attiva_Click);
            // 
            // list_errori
            // 
            this.list_errori.FormattingEnabled = true;
            this.list_errori.ItemHeight = 16;
            this.list_errori.Location = new System.Drawing.Point(235, 92);
            this.list_errori.Margin = new System.Windows.Forms.Padding(4);
            this.list_errori.Name = "list_errori";
            this.list_errori.Size = new System.Drawing.Size(1380, 84);
            this.list_errori.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1868, 855);
            this.Controls.Add(this.list_errori);
            this.Controls.Add(this.btn_attiva);
            this.Controls.Add(this.panel_campo);
            this.Controls.Add(this.btn_fermi);
            this.Controls.Add(this.panel_titolo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "1,2,3 Stella server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_titolo.ResumeLayout(false);
            this.panel_titolo.PerformLayout();
            this.panel_campo.ResumeLayout(false);
            this.panel_campo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_g2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_g1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_arbitro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_titolo;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Button btn_fermi;
        private System.Windows.Forms.Panel panel_campo;
        private System.Windows.Forms.PictureBox pic_arbitro;
        private System.Windows.Forms.Timer tmr_controllo;
        private System.Windows.Forms.Button btn_attiva;
        private System.Windows.Forms.Timer tmr_durataMovimento;
        private System.Windows.Forms.Label lbl_capo;
        private System.Windows.Forms.ListBox list_errori;
        public System.Windows.Forms.PictureBox pic_g2;
        public System.Windows.Forms.PictureBox pic_g1;
        public System.Windows.Forms.Label lbl_g2;
        public System.Windows.Forms.Label lbl_g1;
        public System.Windows.Forms.Label lbl_mov_G2;
        public System.Windows.Forms.Label lbl_mov_G1;
    }
}

