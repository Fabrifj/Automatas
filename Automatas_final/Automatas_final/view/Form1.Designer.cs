namespace Automatas_final
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
            this.btnExpresiones = new System.Windows.Forms.Button();
            this.btnConversion = new System.Windows.Forms.Button();
            this.btnGramatica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExpresiones
            // 
            this.btnExpresiones.Location = new System.Drawing.Point(329, 88);
            this.btnExpresiones.Name = "btnExpresiones";
            this.btnExpresiones.Size = new System.Drawing.Size(114, 41);
            this.btnExpresiones.TabIndex = 0;
            this.btnExpresiones.Text = "Expresiones";
            this.btnExpresiones.UseVisualStyleBackColor = true;
            this.btnExpresiones.Click += new System.EventHandler(this.btnExpresiones_Click);
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(329, 183);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(114, 41);
            this.btnConversion.TabIndex = 1;
            this.btnConversion.Text = "Conversion";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // btnGramatica
            // 
            this.btnGramatica.Location = new System.Drawing.Point(329, 281);
            this.btnGramatica.Name = "btnGramatica";
            this.btnGramatica.Size = new System.Drawing.Size(114, 41);
            this.btnGramatica.TabIndex = 2;
            this.btnGramatica.Text = "Gramatica";
            this.btnGramatica.UseVisualStyleBackColor = true;
            this.btnGramatica.Click += new System.EventHandler(this.btnGramatica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGramatica);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.btnExpresiones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExpresiones;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.Button btnGramatica;
    }
}

