
namespace ScapeRoom
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxClicCod = new System.Windows.Forms.PictureBox();
            this.pbxCodGran = new System.Windows.Forms.PictureBox();
            this.pbxFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClicCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCodGran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxClicCod
            // 
            this.pbxClicCod.BackColor = System.Drawing.Color.Transparent;
            this.pbxClicCod.Location = new System.Drawing.Point(1191, 387);
            this.pbxClicCod.Name = "pbxClicCod";
            this.pbxClicCod.Size = new System.Drawing.Size(44, 100);
            this.pbxClicCod.TabIndex = 0;
            this.pbxClicCod.TabStop = false;
            this.pbxClicCod.Click += new System.EventHandler(this.pbxClicCod_Click);
            // 
            // pbxCodGran
            // 
            this.pbxCodGran.BackColor = System.Drawing.Color.Transparent;
            this.pbxCodGran.Image = ((System.Drawing.Image)(resources.GetObject("pbxCodGran.Image")));
            this.pbxCodGran.Location = new System.Drawing.Point(801, 154);
            this.pbxCodGran.Name = "pbxCodGran";
            this.pbxCodGran.Size = new System.Drawing.Size(356, 653);
            this.pbxCodGran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCodGran.TabIndex = 1;
            this.pbxCodGran.TabStop = false;
            this.pbxCodGran.Visible = false;
            // 
            // pbxFondo
            // 
            this.pbxFondo.BackColor = System.Drawing.Color.Transparent;
            this.pbxFondo.Location = new System.Drawing.Point(-3, -1);
            this.pbxFondo.Name = "pbxFondo";
            this.pbxFondo.Size = new System.Drawing.Size(1911, 1043);
            this.pbxFondo.TabIndex = 2;
            this.pbxFondo.TabStop = false;
            this.pbxFondo.Click += new System.EventHandler(this.pbxFondo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ScapeRoom.Properties.Resources.fondo_claro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pbxClicCod);
            this.Controls.Add(this.pbxCodGran);
            this.Controls.Add(this.pbxFondo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxClicCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCodGran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxClicCod;
        private System.Windows.Forms.PictureBox pbxCodGran;
        private System.Windows.Forms.PictureBox pbxFondo;
    }
}

