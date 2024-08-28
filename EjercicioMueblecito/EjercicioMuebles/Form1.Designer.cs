namespace EjercicioMuebles
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
            this.tbxLista = new System.Windows.Forms.TextBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxLista
            // 
            this.tbxLista.BackColor = System.Drawing.SystemColors.Info;
            this.tbxLista.Location = new System.Drawing.Point(12, 24);
            this.tbxLista.Multiline = true;
            this.tbxLista.Name = "tbxLista";
            this.tbxLista.ReadOnly = true;
            this.tbxLista.Size = new System.Drawing.Size(366, 251);
            this.tbxLista.TabIndex = 0;
            // 
            // btnPrueba
            // 
            this.btnPrueba.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnPrueba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrueba.Location = new System.Drawing.Point(397, 122);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(82, 43);
            this.btnPrueba.TabIndex = 1;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = false;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EjercicioMuebles.Properties.Resources._4de24ec62e11e8edbb48530e31456493;
            this.ClientSize = new System.Drawing.Size(510, 287);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.tbxLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLista;
        private System.Windows.Forms.Button btnPrueba;
    }
}

