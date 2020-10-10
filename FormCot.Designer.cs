namespace CotizadorDeCambios
{
    partial class FormCot
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
            this.tbxLocal = new System.Windows.Forms.TextBox();
            this.tbxExtranjera = new System.Windows.Forms.TextBox();
            this.Local = new System.Windows.Forms.Label();
            this.Extranjera = new System.Windows.Forms.Label();
            this.rbMXNtoUSD = new System.Windows.Forms.RadioButton();
            this.rbUSDtoMXN = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbRBtns = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.gbRBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxLocal
            // 
            this.tbxLocal.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLocal.Location = new System.Drawing.Point(31, 83);
            this.tbxLocal.Name = "tbxLocal";
            this.tbxLocal.Size = new System.Drawing.Size(224, 37);
            this.tbxLocal.TabIndex = 0;
            this.tbxLocal.TextChanged += new System.EventHandler(this.tbxLocal_TextChanged);
            // 
            // tbxExtranjera
            // 
            this.tbxExtranjera.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExtranjera.Location = new System.Drawing.Point(31, 187);
            this.tbxExtranjera.Name = "tbxExtranjera";
            this.tbxExtranjera.Size = new System.Drawing.Size(224, 37);
            this.tbxExtranjera.TabIndex = 1;
            // 
            // Local
            // 
            this.Local.AutoSize = true;
            this.Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Local.Location = new System.Drawing.Point(27, 46);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(129, 24);
            this.Local.TabIndex = 2;
            this.Local.Text = "Moneda local:";
            // 
            // Extranjera
            // 
            this.Extranjera.AutoSize = true;
            this.Extranjera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Extranjera.Location = new System.Drawing.Point(27, 150);
            this.Extranjera.Name = "Extranjera";
            this.Extranjera.Size = new System.Drawing.Size(173, 24);
            this.Extranjera.TabIndex = 3;
            this.Extranjera.Text = "Moneda extranjera:";
            // 
            // rbMXNtoUSD
            // 
            this.rbMXNtoUSD.AutoSize = true;
            this.rbMXNtoUSD.Checked = true;
            this.rbMXNtoUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMXNtoUSD.Location = new System.Drawing.Point(15, 28);
            this.rbMXNtoUSD.Name = "rbMXNtoUSD";
            this.rbMXNtoUSD.Size = new System.Drawing.Size(185, 28);
            this.rbMXNtoUSD.TabIndex = 4;
            this.rbMXNtoUSD.TabStop = true;
            this.rbMXNtoUSD.Text = "Convertir a dólares";
            this.rbMXNtoUSD.UseVisualStyleBackColor = true;
            // 
            // rbUSDtoMXN
            // 
            this.rbUSDtoMXN.AutoSize = true;
            this.rbUSDtoMXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbUSDtoMXN.Location = new System.Drawing.Point(15, 62);
            this.rbUSDtoMXN.Name = "rbUSDtoMXN";
            this.rbUSDtoMXN.Size = new System.Drawing.Size(271, 28);
            this.rbUSDtoMXN.TabIndex = 5;
            this.rbUSDtoMXN.TabStop = true;
            this.rbUSDtoMXN.Text = "Convertir a pesos mexicanos";
            this.rbUSDtoMXN.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConvert.Location = new System.Drawing.Point(378, 187);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(129, 37);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // gbRBtns
            // 
            this.gbRBtns.Controls.Add(this.rbUSDtoMXN);
            this.gbRBtns.Controls.Add(this.rbMXNtoUSD);
            this.gbRBtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRBtns.Location = new System.Drawing.Point(288, 46);
            this.gbRBtns.Name = "gbRBtns";
            this.gbRBtns.Size = new System.Drawing.Size(304, 108);
            this.gbRBtns.TabIndex = 8;
            this.gbRBtns.TabStop = false;
            this.gbRBtns.Text = "Escoge el conversor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 273);
            this.Controls.Add(this.gbRBtns);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.Extranjera);
            this.Controls.Add(this.Local);
            this.Controls.Add(this.tbxExtranjera);
            this.Controls.Add(this.tbxLocal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cotizador de cambios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbRBtns.ResumeLayout(false);
            this.gbRBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLocal;
        private System.Windows.Forms.TextBox tbxExtranjera;
        private System.Windows.Forms.Label Local;
        private System.Windows.Forms.Label Extranjera;
        private System.Windows.Forms.RadioButton rbMXNtoUSD;
        private System.Windows.Forms.RadioButton rbUSDtoMXN;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbRBtns;
    }
}

