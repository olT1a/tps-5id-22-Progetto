
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_titolo = new System.Windows.Forms.Panel();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.btn_fermi = new System.Windows.Forms.Button();
            this.panel_campo = new System.Windows.Forms.Panel();
            this.pic_arbitro = new System.Windows.Forms.PictureBox();
            this.panel_titolo.SuspendLayout();
            this.panel_campo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_arbitro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titolo
            // 
            this.panel_titolo.BackColor = System.Drawing.SystemColors.Info;
            this.panel_titolo.Controls.Add(this.lbl_titolo);
            this.panel_titolo.Controls.Add(this.lbl_tipo);
            this.panel_titolo.Location = new System.Drawing.Point(13, 13);
            this.panel_titolo.Name = "panel_titolo";
            this.panel_titolo.Size = new System.Drawing.Size(1376, 56);
            this.panel_titolo.TabIndex = 0;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(3, 0);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(70, 16);
            this.lbl_tipo.TabIndex = 0;
            this.lbl_tipo.Text = "SERVER";
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(534, 13);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(233, 33);
            this.lbl_titolo.TabIndex = 1;
            this.lbl_titolo.Text = "1, 2, 3 STELLA!";
            // 
            // btn_fermi
            // 
            this.btn_fermi.BackColor = System.Drawing.Color.LightCoral;
            this.btn_fermi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermi.Location = new System.Drawing.Point(1241, 75);
            this.btn_fermi.Name = "btn_fermi";
            this.btn_fermi.Size = new System.Drawing.Size(148, 73);
            this.btn_fermi.TabIndex = 1;
            this.btn_fermi.Text = "Ferma giocatori!";
            this.btn_fermi.UseVisualStyleBackColor = false;
            this.btn_fermi.Click += new System.EventHandler(this.btn_fermi_Click);
            // 
            // panel_campo
            // 
            this.panel_campo.Controls.Add(this.pic_arbitro);
            this.panel_campo.Location = new System.Drawing.Point(12, 167);
            this.panel_campo.Name = "panel_campo";
            this.panel_campo.Size = new System.Drawing.Size(1370, 500);
            this.panel_campo.TabIndex = 2;
            // 
            // pic_arbitro
            // 
            this.pic_arbitro.Image = ((System.Drawing.Image)(resources.GetObject("pic_arbitro.Image")));
            this.pic_arbitro.Location = new System.Drawing.Point(1052, 85);
            this.pic_arbitro.Name = "pic_arbitro";
            this.pic_arbitro.Size = new System.Drawing.Size(293, 361);
            this.pic_arbitro.TabIndex = 0;
            this.pic_arbitro.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 695);
            this.Controls.Add(this.panel_campo);
            this.Controls.Add(this.btn_fermi);
            this.Controls.Add(this.panel_titolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_titolo.ResumeLayout(false);
            this.panel_titolo.PerformLayout();
            this.panel_campo.ResumeLayout(false);
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
    }
}

