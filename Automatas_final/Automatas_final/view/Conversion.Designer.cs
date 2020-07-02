namespace Automatas_final
{
    partial class Conversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnAfnAAfd = new System.Windows.Forms.Button();
            this.btnER = new System.Windows.Forms.Button();
            this.btnCadena = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgDatosEntrada = new System.Windows.Forms.DataGridView();
            this.btnAgregarColumna = new System.Windows.Forms.Button();
            this.btn_Lambda = new System.Windows.Forms.Button();
            this.btn_Vacio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar los datos";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerificar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerificar.Location = new System.Drawing.Point(40, 291);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(117, 50);
            this.btnVerificar.TabIndex = 9;
            this.btnVerificar.Text = "¿Es AFD o AFN?";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnAfnAAfd
            // 
            this.btnAfnAAfd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAfnAAfd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfnAAfd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAfnAAfd.Location = new System.Drawing.Point(40, 356);
            this.btnAfnAAfd.Name = "btnAfnAAfd";
            this.btnAfnAAfd.Size = new System.Drawing.Size(117, 36);
            this.btnAfnAAfd.TabIndex = 10;
            this.btnAfnAAfd.Text = "Convertir a AFD";
            this.btnAfnAAfd.UseVisualStyleBackColor = false;
            this.btnAfnAAfd.Visible = false;
            // 
            // btnER
            // 
            this.btnER.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnER.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnER.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnER.Location = new System.Drawing.Point(187, 291);
            this.btnER.Name = "btnER";
            this.btnER.Size = new System.Drawing.Size(117, 50);
            this.btnER.TabIndex = 11;
            this.btnER.Text = "Generar la expresión regular";
            this.btnER.UseVisualStyleBackColor = false;
            // 
            // btnCadena
            // 
            this.btnCadena.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadena.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadena.Location = new System.Drawing.Point(359, 349);
            this.btnCadena.Name = "btnCadena";
            this.btnCadena.Size = new System.Drawing.Size(117, 50);
            this.btnCadena.TabIndex = 12;
            this.btnCadena.Text = "Camino de la cadena";
            this.btnCadena.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(359, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.WindowText;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(355, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ingresar una cadena";
            // 
            // dgDatosEntrada
            // 
            this.dgDatosEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatosEntrada.Location = new System.Drawing.Point(12, 31);
            this.dgDatosEntrada.Name = "dgDatosEntrada";
            this.dgDatosEntrada.Size = new System.Drawing.Size(399, 233);
            this.dgDatosEntrada.TabIndex = 15;
            // 
            // btnAgregarColumna
            // 
            this.btnAgregarColumna.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarColumna.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarColumna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarColumna.Location = new System.Drawing.Point(426, 71);
            this.btnAgregarColumna.Name = "btnAgregarColumna";
            this.btnAgregarColumna.Size = new System.Drawing.Size(79, 49);
            this.btnAgregarColumna.TabIndex = 16;
            this.btnAgregarColumna.Text = "Entrada";
            this.btnAgregarColumna.UseVisualStyleBackColor = false;
            this.btnAgregarColumna.Click += new System.EventHandler(this.btnAgregarColumna_Click);
            // 
            // btn_Lambda
            // 
            this.btn_Lambda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Lambda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Lambda.Location = new System.Drawing.Point(426, 137);
            this.btn_Lambda.Name = "btn_Lambda";
            this.btn_Lambda.Size = new System.Drawing.Size(75, 32);
            this.btn_Lambda.TabIndex = 17;
            this.btn_Lambda.Text = "λ";
            this.btn_Lambda.UseVisualStyleBackColor = false;
            this.btn_Lambda.Click += new System.EventHandler(this.btn_Lambda_Click);
            // 
            // btn_Vacio
            // 
            this.btn_Vacio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Vacio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Vacio.Location = new System.Drawing.Point(426, 188);
            this.btn_Vacio.Name = "btn_Vacio";
            this.btn_Vacio.Size = new System.Drawing.Size(75, 32);
            this.btn_Vacio.TabIndex = 18;
            this.btn_Vacio.Text = "Φ";
            this.btn_Vacio.UseVisualStyleBackColor = false;
            this.btn_Vacio.Click += new System.EventHandler(this.btn_Vacio_Click);
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Automatas_final.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 421);
            this.Controls.Add(this.btn_Vacio);
            this.Controls.Add(this.btn_Lambda);
            this.Controls.Add(this.btnAgregarColumna);
            this.Controls.Add(this.dgDatosEntrada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCadena);
            this.Controls.Add(this.btnER);
            this.Controls.Add(this.btnAfnAAfd);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label1);
            this.Name = "Conversion";
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.Conversion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnAfnAAfd;
        private System.Windows.Forms.Button btnER;
        private System.Windows.Forms.Button btnCadena;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgDatosEntrada;
        private System.Windows.Forms.Button btnAgregarColumna;
        private System.Windows.Forms.Button btn_Lambda;
        private System.Windows.Forms.Button btn_Vacio;
    }
}