
namespace Rocchi_client_123_stella
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
            this.btn_connetti = new System.Windows.Forms.Button();
            this.btn_invia = new System.Windows.Forms.Button();
            this.lbl_nick = new System.Windows.Forms.Label();
            this.txt_nick = new System.Windows.Forms.TextBox();
            this.tmr_durataMovimento = new System.Windows.Forms.Timer(this.components);
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_nickname = new System.Windows.Forms.Label();
            this.pnl_pulsantiera = new System.Windows.Forms.Panel();
            this.btn_9t = new System.Windows.Forms.Button();
            this.btn_10t = new System.Windows.Forms.Button();
            this.btn_8s = new System.Windows.Forms.Button();
            this.btn_7s = new System.Windows.Forms.Button();
            this.btn_6t = new System.Windows.Forms.Button();
            this.btn_5t = new System.Windows.Forms.Button();
            this.btn_4t = new System.Windows.Forms.Button();
            this.btn_3t = new System.Windows.Forms.Button();
            this.btn_2t = new System.Windows.Forms.Button();
            this.btn_1t = new System.Windows.Forms.Button();
            this.btn_conferma = new System.Windows.Forms.Button();
            this.list_errori = new System.Windows.Forms.ListBox();
            this.pnl_pulsantiera.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connetti
            // 
            this.btn_connetti.BackColor = System.Drawing.Color.Yellow;
            this.btn_connetti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connetti.Location = new System.Drawing.Point(14, 37);
            this.btn_connetti.Margin = new System.Windows.Forms.Padding(2);
            this.btn_connetti.Name = "btn_connetti";
            this.btn_connetti.Size = new System.Drawing.Size(148, 57);
            this.btn_connetti.TabIndex = 0;
            this.btn_connetti.Text = "CONNETTI";
            this.btn_connetti.UseVisualStyleBackColor = false;
            this.btn_connetti.Click += new System.EventHandler(this.btn_connetti_Click);
            // 
            // btn_invia
            // 
            this.btn_invia.BackColor = System.Drawing.Color.Yellow;
            this.btn_invia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invia.Location = new System.Drawing.Point(137, 292);
            this.btn_invia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_invia.Name = "btn_invia";
            this.btn_invia.Size = new System.Drawing.Size(148, 57);
            this.btn_invia.TabIndex = 1;
            this.btn_invia.Text = "INVIA";
            this.btn_invia.UseVisualStyleBackColor = false;
            this.btn_invia.Click += new System.EventHandler(this.btn_invia_Click);
            // 
            // lbl_nick
            // 
            this.lbl_nick.AutoSize = true;
            this.lbl_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nick.Location = new System.Drawing.Point(11, 122);
            this.lbl_nick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nick.Name = "lbl_nick";
            this.lbl_nick.Size = new System.Drawing.Size(156, 20);
            this.lbl_nick.TabIndex = 2;
            this.lbl_nick.Text = "Inserire nickname:";
            // 
            // txt_nick
            // 
            this.txt_nick.Location = new System.Drawing.Point(176, 124);
            this.txt_nick.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Size = new System.Drawing.Size(143, 20);
            this.txt_nick.TabIndex = 3;
            // 
            // tmr_durataMovimento
            // 
            this.tmr_durataMovimento.Interval = 300;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(9, 9);
            this.lbl_tipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(95, 26);
            this.lbl_tipo.TabIndex = 4;
            this.lbl_tipo.Text = "CLIENT";
            // 
            // lbl_nickname
            // 
            this.lbl_nickname.AutoSize = true;
            this.lbl_nickname.Location = new System.Drawing.Point(110, 13);
            this.lbl_nickname.Name = "lbl_nickname";
            this.lbl_nickname.Size = new System.Drawing.Size(0, 13);
            this.lbl_nickname.TabIndex = 5;
            // 
            // pnl_pulsantiera
            // 
            this.pnl_pulsantiera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnl_pulsantiera.Controls.Add(this.btn_9t);
            this.pnl_pulsantiera.Controls.Add(this.btn_10t);
            this.pnl_pulsantiera.Controls.Add(this.btn_8s);
            this.pnl_pulsantiera.Controls.Add(this.btn_7s);
            this.pnl_pulsantiera.Controls.Add(this.btn_6t);
            this.pnl_pulsantiera.Controls.Add(this.btn_5t);
            this.pnl_pulsantiera.Controls.Add(this.btn_4t);
            this.pnl_pulsantiera.Controls.Add(this.btn_3t);
            this.pnl_pulsantiera.Controls.Add(this.btn_2t);
            this.pnl_pulsantiera.Controls.Add(this.btn_1t);
            this.pnl_pulsantiera.Location = new System.Drawing.Point(15, 162);
            this.pnl_pulsantiera.Name = "pnl_pulsantiera";
            this.pnl_pulsantiera.Size = new System.Drawing.Size(397, 125);
            this.pnl_pulsantiera.TabIndex = 16;
            // 
            // btn_9t
            // 
            this.btn_9t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(118)))));
            this.btn_9t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9t.Location = new System.Drawing.Point(251, 65);
            this.btn_9t.Name = "btn_9t";
            this.btn_9t.Size = new System.Drawing.Size(48, 44);
            this.btn_9t.TabIndex = 25;
            this.btn_9t.Text = "9s";
            this.btn_9t.UseVisualStyleBackColor = false;
            this.btn_9t.Click += new System.EventHandler(this.btn_9t_Click);
            // 
            // btn_10t
            // 
            this.btn_10t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(118)))));
            this.btn_10t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10t.Location = new System.Drawing.Point(327, 65);
            this.btn_10t.Name = "btn_10t";
            this.btn_10t.Size = new System.Drawing.Size(48, 44);
            this.btn_10t.TabIndex = 24;
            this.btn_10t.Text = "10s";
            this.btn_10t.UseVisualStyleBackColor = false;
            this.btn_10t.Click += new System.EventHandler(this.btn_10t_Click);
            // 
            // btn_8s
            // 
            this.btn_8s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(118)))));
            this.btn_8s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8s.Location = new System.Drawing.Point(175, 65);
            this.btn_8s.Name = "btn_8s";
            this.btn_8s.Size = new System.Drawing.Size(48, 44);
            this.btn_8s.TabIndex = 23;
            this.btn_8s.Text = "8s";
            this.btn_8s.UseVisualStyleBackColor = false;
            this.btn_8s.Click += new System.EventHandler(this.btn_8s_Click);
            // 
            // btn_7s
            // 
            this.btn_7s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(118)))));
            this.btn_7s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7s.Location = new System.Drawing.Point(99, 65);
            this.btn_7s.Name = "btn_7s";
            this.btn_7s.Size = new System.Drawing.Size(48, 44);
            this.btn_7s.TabIndex = 22;
            this.btn_7s.Text = "7s";
            this.btn_7s.UseVisualStyleBackColor = false;
            this.btn_7s.Click += new System.EventHandler(this.btn_7s_Click);
            // 
            // btn_6t
            // 
            this.btn_6t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(118)))));
            this.btn_6t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6t.Location = new System.Drawing.Point(23, 65);
            this.btn_6t.Name = "btn_6t";
            this.btn_6t.Size = new System.Drawing.Size(48, 44);
            this.btn_6t.TabIndex = 21;
            this.btn_6t.Text = "6s";
            this.btn_6t.UseVisualStyleBackColor = false;
            this.btn_6t.Click += new System.EventHandler(this.btn_6t_Click);
            // 
            // btn_5t
            // 
            this.btn_5t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(118)))));
            this.btn_5t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5t.Location = new System.Drawing.Point(327, 15);
            this.btn_5t.Name = "btn_5t";
            this.btn_5t.Size = new System.Drawing.Size(48, 44);
            this.btn_5t.TabIndex = 20;
            this.btn_5t.Text = "5s";
            this.btn_5t.UseVisualStyleBackColor = false;
            this.btn_5t.Click += new System.EventHandler(this.btn_5t_Click);
            // 
            // btn_4t
            // 
            this.btn_4t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(118)))));
            this.btn_4t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4t.Location = new System.Drawing.Point(251, 15);
            this.btn_4t.Name = "btn_4t";
            this.btn_4t.Size = new System.Drawing.Size(48, 44);
            this.btn_4t.TabIndex = 19;
            this.btn_4t.Text = "4s";
            this.btn_4t.UseVisualStyleBackColor = false;
            this.btn_4t.Click += new System.EventHandler(this.btn_4t_Click);
            // 
            // btn_3t
            // 
            this.btn_3t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(118)))));
            this.btn_3t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3t.Location = new System.Drawing.Point(175, 15);
            this.btn_3t.Name = "btn_3t";
            this.btn_3t.Size = new System.Drawing.Size(48, 44);
            this.btn_3t.TabIndex = 18;
            this.btn_3t.Text = "3s";
            this.btn_3t.UseVisualStyleBackColor = false;
            this.btn_3t.Click += new System.EventHandler(this.btn_3t_Click);
            // 
            // btn_2t
            // 
            this.btn_2t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(118)))));
            this.btn_2t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2t.Location = new System.Drawing.Point(99, 15);
            this.btn_2t.Name = "btn_2t";
            this.btn_2t.Size = new System.Drawing.Size(48, 44);
            this.btn_2t.TabIndex = 17;
            this.btn_2t.Text = "2s";
            this.btn_2t.UseVisualStyleBackColor = false;
            this.btn_2t.Click += new System.EventHandler(this.btn_2t_Click);
            // 
            // btn_1t
            // 
            this.btn_1t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(118)))));
            this.btn_1t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1t.Location = new System.Drawing.Point(23, 15);
            this.btn_1t.Name = "btn_1t";
            this.btn_1t.Size = new System.Drawing.Size(48, 44);
            this.btn_1t.TabIndex = 16;
            this.btn_1t.Text = "1s";
            this.btn_1t.UseVisualStyleBackColor = false;
            this.btn_1t.Click += new System.EventHandler(this.btn_1t_Click);
            // 
            // btn_conferma
            // 
            this.btn_conferma.BackColor = System.Drawing.Color.Yellow;
            this.btn_conferma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conferma.Location = new System.Drawing.Point(325, 124);
            this.btn_conferma.Name = "btn_conferma";
            this.btn_conferma.Size = new System.Drawing.Size(87, 23);
            this.btn_conferma.TabIndex = 17;
            this.btn_conferma.Text = "Conferma";
            this.btn_conferma.UseVisualStyleBackColor = false;
            this.btn_conferma.Click += new System.EventHandler(this.btn_conferma_Click);
            // 
            // list_errori
            // 
            this.list_errori.FormattingEnabled = true;
            this.list_errori.Location = new System.Drawing.Point(194, 25);
            this.list_errori.Name = "list_errori";
            this.list_errori.Size = new System.Drawing.Size(196, 69);
            this.list_errori.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(430, 433);
            this.Controls.Add(this.list_errori);
            this.Controls.Add(this.btn_conferma);
            this.Controls.Add(this.pnl_pulsantiera);
            this.Controls.Add(this.lbl_nickname);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.txt_nick);
            this.Controls.Add(this.lbl_nick);
            this.Controls.Add(this.btn_invia);
            this.Controls.Add(this.btn_connetti);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "1,2,3 Stella client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_pulsantiera.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connetti;
        private System.Windows.Forms.Button btn_invia;
        private System.Windows.Forms.Label lbl_nick;
        private System.Windows.Forms.TextBox txt_nick;
        private System.Windows.Forms.Timer tmr_durataMovimento;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_nickname;
        private System.Windows.Forms.Panel pnl_pulsantiera;
        private System.Windows.Forms.Button btn_9t;
        private System.Windows.Forms.Button btn_10t;
        private System.Windows.Forms.Button btn_8s;
        private System.Windows.Forms.Button btn_7s;
        private System.Windows.Forms.Button btn_6t;
        private System.Windows.Forms.Button btn_5t;
        private System.Windows.Forms.Button btn_4t;
        private System.Windows.Forms.Button btn_3t;
        private System.Windows.Forms.Button btn_2t;
        private System.Windows.Forms.Button btn_1t;
        private System.Windows.Forms.Button btn_conferma;
        private System.Windows.Forms.ListBox list_errori;
    }
}

