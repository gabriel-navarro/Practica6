namespace Practica6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.factura = new System.Windows.Forms.Button();
            this.Producto1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.Producto2 = new System.Windows.Forms.Label();
            this.Producto3 = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.IVA = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // factura
            // 
            this.factura.Location = new System.Drawing.Point(28, 219);
            this.factura.Name = "factura";
            this.factura.Size = new System.Drawing.Size(75, 23);
            this.factura.TabIndex = 0;
            this.factura.Text = "Facturar";
            this.factura.UseVisualStyleBackColor = true;
            this.factura.Click += new System.EventHandler(this.button1_Click);
            // 
            // Producto1
            // 
            this.Producto1.AutoSize = true;
            this.Producto1.Location = new System.Drawing.Point(25, 15);
            this.Producto1.Name = "Producto1";
            this.Producto1.Size = new System.Drawing.Size(62, 13);
            this.Producto1.TabIndex = 1;
            this.Producto1.Text = "Producto 1:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(127, 219);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 3;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Producto2
            // 
            this.Producto2.AutoSize = true;
            this.Producto2.Location = new System.Drawing.Point(25, 44);
            this.Producto2.Name = "Producto2";
            this.Producto2.Size = new System.Drawing.Size(62, 13);
            this.Producto2.TabIndex = 4;
            this.Producto2.Text = "Producto 2:";
            // 
            // Producto3
            // 
            this.Producto3.AutoSize = true;
            this.Producto3.Location = new System.Drawing.Point(25, 72);
            this.Producto3.Name = "Producto3";
            this.Producto3.Size = new System.Drawing.Size(62, 13);
            this.Producto3.TabIndex = 5;
            this.Producto3.Text = "Producto 3:";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Location = new System.Drawing.Point(25, 127);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(53, 13);
            this.subtotal.TabIndex = 6;
            this.subtotal.Text = "SubTotal:";
            // 
            // IVA
            // 
            this.IVA.AutoSize = true;
            this.IVA.Location = new System.Drawing.Point(25, 157);
            this.IVA.Name = "IVA";
            this.IVA.Size = new System.Drawing.Size(27, 13);
            this.IVA.TabIndex = 7;
            this.IVA.Text = "IVA:";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Location = new System.Drawing.Point(25, 186);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(34, 13);
            this.TOTAL.TabIndex = 8;
            this.TOTAL.Text = "Total:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(102, 157);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(102, 183);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 262);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.IVA);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.Producto3);
            this.Controls.Add(this.Producto2);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Producto1);
            this.Controls.Add(this.factura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button factura;
        private System.Windows.Forms.Label Producto1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label Producto2;
        private System.Windows.Forms.Label Producto3;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label IVA;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

