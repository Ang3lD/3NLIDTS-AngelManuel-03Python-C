namespace Conversor_C_F
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCelcius = new System.Windows.Forms.TextBox();
            this.TxtFarenheit = new System.Windows.Forms.TextBox();
            this.BtnCelcius = new System.Windows.Forms.Button();
            this.BtnFarenheit = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(238, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados Celcius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grados Farenheit";
            // 
            // TxtCelcius
            // 
            this.TxtCelcius.Location = new System.Drawing.Point(126, 112);
            this.TxtCelcius.Name = "TxtCelcius";
            this.TxtCelcius.Size = new System.Drawing.Size(148, 20);
            this.TxtCelcius.TabIndex = 3;
            // 
            // TxtFarenheit
            // 
            this.TxtFarenheit.Location = new System.Drawing.Point(467, 112);
            this.TxtFarenheit.Name = "TxtFarenheit";
            this.TxtFarenheit.Size = new System.Drawing.Size(168, 20);
            this.TxtFarenheit.TabIndex = 4;
            // 
            // BtnCelcius
            // 
            this.BtnCelcius.Location = new System.Drawing.Point(126, 184);
            this.BtnCelcius.Name = "BtnCelcius";
            this.BtnCelcius.Size = new System.Drawing.Size(148, 23);
            this.BtnCelcius.TabIndex = 5;
            this.BtnCelcius.Text = "Celcius a Farenheit";
            this.BtnCelcius.UseVisualStyleBackColor = true;
            this.BtnCelcius.Click += new System.EventHandler(this.BtnCelcius_Click);
            // 
            // BtnFarenheit
            // 
            this.BtnFarenheit.Location = new System.Drawing.Point(467, 184);
            this.BtnFarenheit.Name = "BtnFarenheit";
            this.BtnFarenheit.Size = new System.Drawing.Size(168, 23);
            this.BtnFarenheit.TabIndex = 6;
            this.BtnFarenheit.Text = "Farenheit a Celcius";
            this.BtnFarenheit.UseVisualStyleBackColor = true;
            this.BtnFarenheit.Click += new System.EventHandler(this.BtnFarenheit_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnLimpiar.Location = new System.Drawing.Point(329, 235);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 291);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnFarenheit);
            this.Controls.Add(this.BtnCelcius);
            this.Controls.Add(this.TxtFarenheit);
            this.Controls.Add(this.TxtCelcius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCelcius;
        private System.Windows.Forms.TextBox TxtFarenheit;
        private System.Windows.Forms.Button BtnCelcius;
        private System.Windows.Forms.Button BtnFarenheit;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}

