namespace Lab_12
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NombreTextbox = new System.Windows.Forms.TextBox();
            this.ProteinasTextbox = new System.Windows.Forms.TextBox();
            this.GrasasTextbox = new System.Windows.Forms.TextBox();
            this.CarbsTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ComidasListbox = new System.Windows.Forms.ListBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AgregarButton);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.CarbsTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.GrasasTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.ProteinasTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.NombreTextbox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.EliminarButton);
            this.splitContainer1.Panel2.Controls.Add(this.ComidasListbox);
            this.splitContainer1.Size = new System.Drawing.Size(735, 403);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 0;
            // 
            // NombreTextbox
            // 
            this.NombreTextbox.Location = new System.Drawing.Point(119, 52);
            this.NombreTextbox.Name = "NombreTextbox";
            this.NombreTextbox.Size = new System.Drawing.Size(182, 20);
            this.NombreTextbox.TabIndex = 0;
            // 
            // ProteinasTextbox
            // 
            this.ProteinasTextbox.Location = new System.Drawing.Point(119, 111);
            this.ProteinasTextbox.Name = "ProteinasTextbox";
            this.ProteinasTextbox.Size = new System.Drawing.Size(182, 20);
            this.ProteinasTextbox.TabIndex = 1;
            // 
            // GrasasTextbox
            // 
            this.GrasasTextbox.Location = new System.Drawing.Point(119, 178);
            this.GrasasTextbox.Name = "GrasasTextbox";
            this.GrasasTextbox.Size = new System.Drawing.Size(182, 20);
            this.GrasasTextbox.TabIndex = 2;
            // 
            // CarbsTextbox
            // 
            this.CarbsTextbox.Location = new System.Drawing.Point(119, 237);
            this.CarbsTextbox.Name = "CarbsTextbox";
            this.CarbsTextbox.Size = new System.Drawing.Size(182, 20);
            this.CarbsTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proteinas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grasas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carbohidratos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(119, 308);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(104, 37);
            this.AgregarButton.TabIndex = 8;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ComidasListbox
            // 
            this.ComidasListbox.FormattingEnabled = true;
            this.ComidasListbox.Location = new System.Drawing.Point(3, 52);
            this.ComidasListbox.Name = "ComidasListbox";
            this.ComidasListbox.Size = new System.Drawing.Size(376, 251);
            this.ComidasListbox.TabIndex = 0;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(147, 315);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(104, 37);
            this.EliminarButton.TabIndex = 1;
            this.EliminarButton.Text = "Eliminar Seleccion";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 403);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CarbsTextbox;
        private System.Windows.Forms.TextBox GrasasTextbox;
        private System.Windows.Forms.TextBox ProteinasTextbox;
        private System.Windows.Forms.TextBox NombreTextbox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ListBox ComidasListbox;
    }
}

