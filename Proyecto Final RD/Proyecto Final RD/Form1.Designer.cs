namespace Proyecto_Final_RD
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
            this.bttAbrir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lablgasto1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttAbrir
            // 
            this.bttAbrir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttAbrir.Location = new System.Drawing.Point(508, 30);
            this.bttAbrir.Name = "bttAbrir";
            this.bttAbrir.Size = new System.Drawing.Size(85, 23);
            this.bttAbrir.TabIndex = 0;
            this.bttAbrir.Text = "Abrir Archivo";
            this.bttAbrir.UseVisualStyleBackColor = false;
            this.bttAbrir.Click += new System.EventHandler(this.bttAbrir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 239);
            this.dataGridView1.TabIndex = 1;
            // 
            // lablgasto1
            // 
            this.lablgasto1.AutoSize = true;
            this.lablgasto1.Location = new System.Drawing.Point(521, 149);
            this.lablgasto1.Name = "lablgasto1";
            this.lablgasto1.Size = new System.Drawing.Size(40, 13);
            this.lablgasto1.TabIndex = 2;
            this.lablgasto1.Text = "Gastos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 289);
            this.Controls.Add(this.lablgasto1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttAbrir);
            this.Name = "Form1";
            this.Text = "Proyecto Final Programacion III";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttAbrir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lablgasto1;
    }
}

