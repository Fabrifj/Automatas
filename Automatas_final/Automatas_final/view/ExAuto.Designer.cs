namespace Automatas_final.view
{
    partial class ExAuto
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
            this.dgvAutomata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutomata
            // 
            this.dgvAutomata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomata.Location = new System.Drawing.Point(0, 69);
            this.dgvAutomata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAutomata.Name = "dgvAutomata";
            this.dgvAutomata.RowHeadersWidth = 51;
            this.dgvAutomata.RowTemplate.Height = 24;
            this.dgvAutomata.Size = new System.Drawing.Size(801, 312);
            this.dgvAutomata.TabIndex = 2;
            // 
            // ExAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAutomata);
            this.Name = "ExAuto";
            this.Text = "ExAuto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomata;
    }
}