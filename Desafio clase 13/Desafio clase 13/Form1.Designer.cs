
namespace Desafio_clase_13
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
            this.radioButtonPiso = new System.Windows.Forms.RadioButton();
            this.radioButtonLocal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtDirecion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPrecioFinal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMostrarAños = new System.Windows.Forms.Label();
            this.labelMostrarNumeroPiso = new System.Windows.Forms.Label();
            this.labelMostrarVentanas = new System.Windows.Forms.Label();
            this.labelMostrarsuperficie = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonPiso
            // 
            this.radioButtonPiso.AutoSize = true;
            this.radioButtonPiso.Location = new System.Drawing.Point(42, 21);
            this.radioButtonPiso.Name = "radioButtonPiso";
            this.radioButtonPiso.Size = new System.Drawing.Size(56, 21);
            this.radioButtonPiso.TabIndex = 1;
            this.radioButtonPiso.TabStop = true;
            this.radioButtonPiso.Text = "Piso";
            this.radioButtonPiso.UseVisualStyleBackColor = true;
            this.radioButtonPiso.CheckedChanged += new System.EventHandler(this.radioButtonPiso_CheckedChanged);
            // 
            // radioButtonLocal
            // 
            this.radioButtonLocal.AutoSize = true;
            this.radioButtonLocal.Location = new System.Drawing.Point(200, 21);
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.Size = new System.Drawing.Size(63, 21);
            this.radioButtonLocal.TabIndex = 2;
            this.radioButtonLocal.TabStop = true;
            this.radioButtonLocal.Text = "Local";
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            this.radioButtonLocal.CheckedChanged += new System.EventHandler(this.radioButtonLocal_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piso Nro*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nro de ventanas*";
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(43, 65);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(44, 22);
            this.txtPiso.TabIndex = 5;
            this.txtPiso.Text = "0";
            this.txtPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(200, 65);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(44, 22);
            this.txtLocal.TabIndex = 6;
            this.txtLocal.Text = "0";
            this.txtLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDirecion
            // 
            this.txtDirecion.Location = new System.Drawing.Point(42, 135);
            this.txtDirecion.Name = "txtDirecion";
            this.txtDirecion.Size = new System.Drawing.Size(296, 22);
            this.txtDirecion.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(242, 182);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(96, 22);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(135, 182);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(44, 22);
            this.txtAntiguedad.TabIndex = 9;
            this.txtAntiguedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(42, 180);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(44, 22);
            this.txtSuperficie.TabIndex = 10;
            this.txtSuperficie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Superficie*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Antiguedad*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio Base*";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(42, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 57);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calcular Precio Final";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.bottonCalcular);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "(años)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "(m2)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(85, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "El Precio Final es:  $";
            // 
            // labelPrecioFinal
            // 
            this.labelPrecioFinal.AutoSize = true;
            this.labelPrecioFinal.Location = new System.Drawing.Point(223, 375);
            this.labelPrecioFinal.Name = "labelPrecioFinal";
            this.labelPrecioFinal.Size = new System.Drawing.Size(0, 17);
            this.labelPrecioFinal.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLocal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLocal);
            this.groupBox1.Controls.Add(this.radioButtonPiso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPiso);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Inmueble";
            // 
            // labelMostrarAños
            // 
            this.labelMostrarAños.AutoSize = true;
            this.labelMostrarAños.Location = new System.Drawing.Point(27, 297);
            this.labelMostrarAños.Name = "labelMostrarAños";
            this.labelMostrarAños.Size = new System.Drawing.Size(0, 17);
            this.labelMostrarAños.TabIndex = 21;
            // 
            // labelMostrarNumeroPiso
            // 
            this.labelMostrarNumeroPiso.AutoSize = true;
            this.labelMostrarNumeroPiso.Location = new System.Drawing.Point(27, 270);
            this.labelMostrarNumeroPiso.Name = "labelMostrarNumeroPiso";
            this.labelMostrarNumeroPiso.Size = new System.Drawing.Size(0, 17);
            this.labelMostrarNumeroPiso.TabIndex = 22;
            // 
            // labelMostrarVentanas
            // 
            this.labelMostrarVentanas.AutoSize = true;
            this.labelMostrarVentanas.Location = new System.Drawing.Point(27, 325);
            this.labelMostrarVentanas.Name = "labelMostrarVentanas";
            this.labelMostrarVentanas.Size = new System.Drawing.Size(0, 17);
            this.labelMostrarVentanas.TabIndex = 23;
            // 
            // labelMostrarsuperficie
            // 
            this.labelMostrarsuperficie.AutoSize = true;
            this.labelMostrarsuperficie.Location = new System.Drawing.Point(27, 352);
            this.labelMostrarsuperficie.Name = "labelMostrarsuperficie";
            this.labelMostrarsuperficie.Size = new System.Drawing.Size(0, 17);
            this.labelMostrarsuperficie.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 426);
            this.Controls.Add(this.labelMostrarsuperficie);
            this.Controls.Add(this.labelMostrarVentanas);
            this.Controls.Add(this.labelMostrarNumeroPiso);
            this.Controls.Add(this.labelMostrarAños);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPrecioFinal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDirecion);
            this.Name = "Form1";
            this.Text = "Inmoviliaria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonPiso;
        private System.Windows.Forms.RadioButton radioButtonLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtDirecion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPrecioFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMostrarAños;
        private System.Windows.Forms.Label labelMostrarNumeroPiso;
        private System.Windows.Forms.Label labelMostrarVentanas;
        private System.Windows.Forms.Label labelMostrarsuperficie;
    }
}

