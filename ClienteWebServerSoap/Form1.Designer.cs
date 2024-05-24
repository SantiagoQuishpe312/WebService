namespace ClienteWebServerSoap
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
            this.btnConsult = new System.Windows.Forms.Button();
            this.lblGet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(334, 109);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(75, 23);
            this.btnConsult.TabIndex = 0;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.UseVisualStyleBackColor = true;
            // 
            // lblGet
            // 
            this.lblGet.AutoSize = true;
            this.lblGet.Location = new System.Drawing.Point(331, 234);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(35, 13);
            this.lblGet.TabIndex = 1;
            this.lblGet.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGet);
            this.Controls.Add(this.btnConsult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Label lblGet;
    }
}

