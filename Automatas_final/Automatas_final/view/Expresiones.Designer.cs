namespace Automatas_final
{
    partial class Expresiones
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
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.txtAlfabeto = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblAlfabeto = new System.Windows.Forms.Label();
            this.lblExpresiones = new System.Windows.Forms.Label();
            this.btnSimbolo = new System.Windows.Forms.Button();
            this.btnKleen = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.cbxAlfebeto = new System.Windows.Forms.ComboBox();
            this.btnPareB = new System.Windows.Forms.Button();
            this.btnParenA = new System.Windows.Forms.Button();
            this.btnTransformar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(12, 122);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(552, 26);
            this.txtExpresion.TabIndex = 0;
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(610, 64);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(178, 26);
            this.txtAlfabeto.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(610, 117);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(178, 31);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblAlfabeto
            // 
            this.lblAlfabeto.AutoSize = true;
            this.lblAlfabeto.Location = new System.Drawing.Point(606, 26);
            this.lblAlfabeto.Name = "lblAlfabeto";
            this.lblAlfabeto.Size = new System.Drawing.Size(127, 20);
            this.lblAlfabeto.TabIndex = 3;
            this.lblAlfabeto.Text = "Ingrese Alfabeto";
            // 
            // lblExpresiones
            // 
            this.lblExpresiones.AutoSize = true;
            this.lblExpresiones.Location = new System.Drawing.Point(93, 64);
            this.lblExpresiones.Name = "lblExpresiones";
            this.lblExpresiones.Size = new System.Drawing.Size(137, 20);
            this.lblExpresiones.TabIndex = 4;
            this.lblExpresiones.Text = "Ingrese Expresion";
            // 
            // btnSimbolo
            // 
            this.btnSimbolo.Location = new System.Drawing.Point(12, 288);
            this.btnSimbolo.Name = "btnSimbolo";
            this.btnSimbolo.Size = new System.Drawing.Size(178, 31);
            this.btnSimbolo.TabIndex = 5;
            this.btnSimbolo.Text = "Simbolo";
            this.btnSimbolo.UseVisualStyleBackColor = true;
            this.btnSimbolo.Click += new System.EventHandler(this.btnSimbolo_Click);
            // 
            // btnKleen
            // 
            this.btnKleen.Location = new System.Drawing.Point(220, 288);
            this.btnKleen.Name = "btnKleen";
            this.btnKleen.Size = new System.Drawing.Size(178, 31);
            this.btnKleen.TabIndex = 6;
            this.btnKleen.Text = "*";
            this.btnKleen.UseVisualStyleBackColor = true;
            this.btnKleen.Click += new System.EventHandler(this.btnKleen_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(413, 288);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(178, 31);
            this.btnUnion.TabIndex = 7;
            this.btnUnion.Text = "U";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // cbxAlfebeto
            // 
            this.cbxAlfebeto.FormattingEnabled = true;
            this.cbxAlfebeto.Location = new System.Drawing.Point(12, 238);
            this.cbxAlfebeto.Name = "cbxAlfebeto";
            this.cbxAlfebeto.Size = new System.Drawing.Size(178, 28);
            this.cbxAlfebeto.TabIndex = 8;
            // 
            // btnPareB
            // 
            this.btnPareB.Location = new System.Drawing.Point(320, 352);
            this.btnPareB.Name = "btnPareB";
            this.btnPareB.Size = new System.Drawing.Size(178, 31);
            this.btnPareB.TabIndex = 9;
            this.btnPareB.Text = ")";
            this.btnPareB.UseVisualStyleBackColor = true;
            this.btnPareB.Click += new System.EventHandler(this.btnPareB_Click);
            // 
            // btnParenA
            // 
            this.btnParenA.Location = new System.Drawing.Point(126, 352);
            this.btnParenA.Name = "btnParenA";
            this.btnParenA.Size = new System.Drawing.Size(178, 31);
            this.btnParenA.TabIndex = 10;
            this.btnParenA.Text = "(";
            this.btnParenA.UseVisualStyleBackColor = true;
            this.btnParenA.Click += new System.EventHandler(this.btnParenA_Click);
            // 
            // btnTransformar
            // 
            this.btnTransformar.Location = new System.Drawing.Point(610, 390);
            this.btnTransformar.Name = "btnTransformar";
            this.btnTransformar.Size = new System.Drawing.Size(178, 31);
            this.btnTransformar.TabIndex = 11;
            this.btnTransformar.Text = "Transformar";
            this.btnTransformar.UseVisualStyleBackColor = true;
            this.btnTransformar.Click += new System.EventHandler(this.btnTransformar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(233, 407);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Expresiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTransformar);
            this.Controls.Add(this.btnParenA);
            this.Controls.Add(this.btnPareB);
            this.Controls.Add(this.cbxAlfebeto);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.btnKleen);
            this.Controls.Add(this.btnSimbolo);
            this.Controls.Add(this.lblExpresiones);
            this.Controls.Add(this.lblAlfabeto);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtAlfabeto);
            this.Controls.Add(this.txtExpresion);
            this.Name = "Expresiones";
            this.Text = "Expresiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.TextBox txtAlfabeto;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblAlfabeto;
        private System.Windows.Forms.Label lblExpresiones;
        private System.Windows.Forms.Button btnSimbolo;
        private System.Windows.Forms.Button btnKleen;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.ComboBox cbxAlfebeto;
        private System.Windows.Forms.Button btnPareB;
        private System.Windows.Forms.Button btnParenA;
        private System.Windows.Forms.Button btnTransformar;
        private System.Windows.Forms.Button btnDelete;
    }
}