
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
            this.SuspendLayout();
            // 
            // btn_connetti
            // 
            this.btn_connetti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connetti.Location = new System.Drawing.Point(18, 61);
            this.btn_connetti.Name = "btn_connetti";
            this.btn_connetti.Size = new System.Drawing.Size(198, 70);
            this.btn_connetti.TabIndex = 0;
            this.btn_connetti.Text = "CONNETTI";
            this.btn_connetti.UseVisualStyleBackColor = true;
            this.btn_connetti.Click += new System.EventHandler(this.btn_connetti_Click);
            // 
            // btn_invia
            // 
            this.btn_invia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invia.Location = new System.Drawing.Point(32, 249);
            this.btn_invia.Name = "btn_invia";
            this.btn_invia.Size = new System.Drawing.Size(198, 70);
            this.btn_invia.TabIndex = 1;
            this.btn_invia.Text = "INVIA";
            this.btn_invia.UseVisualStyleBackColor = true;
            // 
            // lbl_nick
            // 
            this.lbl_nick.AutoSize = true;
            this.lbl_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nick.Location = new System.Drawing.Point(27, 172);
            this.lbl_nick.Name = "lbl_nick";
            this.lbl_nick.Size = new System.Drawing.Size(189, 25);
            this.lbl_nick.TabIndex = 2;
            this.lbl_nick.Text = "Inserire nickname:";
            // 
            // txt_nick
            // 
            this.txt_nick.Location = new System.Drawing.Point(222, 176);
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Size = new System.Drawing.Size(189, 22);
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
            this.lbl_tipo.Location = new System.Drawing.Point(12, 13);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(120, 32);
            this.lbl_tipo.TabIndex = 4;
            this.lbl_tipo.Text = "CLIENT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 381);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.txt_nick);
            this.Controls.Add(this.lbl_nick);
            this.Controls.Add(this.btn_invia);
            this.Controls.Add(this.btn_connetti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

