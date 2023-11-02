namespace CalcSharp
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
            this.lblHolamundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHolamundo
            // 
            this.lblHolamundo.Font = new System.Drawing.Font("FiraCode Nerd Font Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHolamundo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblHolamundo.Location = new System.Drawing.Point(170, 161);
            this.lblHolamundo.Name = "lblHolamundo";
            this.lblHolamundo.Size = new System.Drawing.Size(202, 92);
            this.lblHolamundo.TabIndex = 0;
            this.lblHolamundo.Text = "Hola Mundo!";
            this.lblHolamundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 512);
            this.Controls.Add(this.lblHolamundo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHolamundo;
    }
}

