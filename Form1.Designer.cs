
namespace PrimerInterfazGrafica
{
    partial class frmMiCalculadora
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.tbxCalculo = new System.Windows.Forms.TextBox();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorarr = new System.Windows.Forms.Button();
            this.btnMasMenos = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.btnBorrarCaracter = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnAlCuadrado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(17, 220);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 35);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.cargarNumero);
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadora.Location = new System.Drawing.Point(12, 9);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(117, 25);
            this.lblCalculadora.TabIndex = 1;
            this.lblCalculadora.Text = "Calculadora";
            // 
            // tbxCalculo
            // 
            this.tbxCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCalculo.Location = new System.Drawing.Point(17, 46);
            this.tbxCalculo.MaxLength = 12;
            this.tbxCalculo.Multiline = true;
            this.tbxCalculo.Name = "tbxCalculo";
            this.tbxCalculo.ReadOnly = true;
            this.tbxCalculo.Size = new System.Drawing.Size(199, 46);
            this.tbxCalculo.TabIndex = 2;
            this.tbxCalculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(316, 294);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 13);
            this.lblSaludo.TabIndex = 3;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(99, 138);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(35, 35);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.cargarNumero);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(58, 138);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(35, 35);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.cargarNumero);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(17, 138);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 35);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.cargarNumero);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(99, 179);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(35, 35);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.cargarNumero);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(58, 179);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 35);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.cargarNumero);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(17, 179);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 35);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.cargarNumero);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(99, 220);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 35);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.cargarNumero);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(58, 220);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 35);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.cargarNumero);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(140, 179);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(35, 36);
            this.btnSuma.TabIndex = 12;
            this.btnSuma.Tag = "+";
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.cargarOperador);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(58, 261);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(35, 35);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.cargarNumero);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(181, 179);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(35, 35);
            this.btnResta.TabIndex = 14;
            this.btnResta.Tag = "-";
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.cargarOperador);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(140, 138);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(35, 35);
            this.btnMultiplicacion.TabIndex = 15;
            this.btnMultiplicacion.Tag = "x";
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.cargarOperador);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(181, 138);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(35, 35);
            this.btnDivision.TabIndex = 16;
            this.btnDivision.Tag = "/";
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.cargarOperador);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIgual.Location = new System.Drawing.Point(140, 220);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(76, 35);
            this.btnIgual.TabIndex = 17;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrarTodo.Location = new System.Drawing.Point(17, 98);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(35, 35);
            this.btnBorrarTodo.TabIndex = 19;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorarr
            // 
            this.btnBorarr.Location = new System.Drawing.Point(58, 98);
            this.btnBorarr.Name = "btnBorarr";
            this.btnBorarr.Size = new System.Drawing.Size(35, 35);
            this.btnBorarr.TabIndex = 20;
            this.btnBorarr.Text = "CE";
            this.btnBorarr.UseVisualStyleBackColor = true;
            this.btnBorarr.Click += new System.EventHandler(this.btnBorarr_Click);
            // 
            // btnMasMenos
            // 
            this.btnMasMenos.Location = new System.Drawing.Point(17, 261);
            this.btnMasMenos.Name = "btnMasMenos";
            this.btnMasMenos.Size = new System.Drawing.Size(35, 35);
            this.btnMasMenos.TabIndex = 21;
            this.btnMasMenos.Text = "+/-";
            this.btnMasMenos.UseVisualStyleBackColor = true;
            this.btnMasMenos.Click += new System.EventHandler(this.btnMasMenos_Click);
            // 
            // btnComa
            // 
            this.btnComa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComa.Location = new System.Drawing.Point(99, 261);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(35, 35);
            this.btnComa.TabIndex = 22;
            this.btnComa.Text = ",";
            this.btnComa.UseVisualStyleBackColor = true;
            this.btnComa.Click += new System.EventHandler(this.btnComa_Click);
            // 
            // btnBorrarCaracter
            // 
            this.btnBorrarCaracter.Location = new System.Drawing.Point(99, 98);
            this.btnBorrarCaracter.Name = "btnBorrarCaracter";
            this.btnBorrarCaracter.Size = new System.Drawing.Size(35, 35);
            this.btnBorrarCaracter.TabIndex = 23;
            this.btnBorrarCaracter.Text = "<<";
            this.btnBorrarCaracter.UseVisualStyleBackColor = true;
            this.btnBorrarCaracter.Click += new System.EventHandler(this.btnBorrarCaracter_Click);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.Location = new System.Drawing.Point(140, 98);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(35, 35);
            this.btnRaizCuadrada.TabIndex = 24;
            this.btnRaizCuadrada.Tag = "√";
            this.btnRaizCuadrada.Text = "√";
            this.btnRaizCuadrada.UseVisualStyleBackColor = true;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.cargarOperador);
            // 
            // btnAlCuadrado
            // 
            this.btnAlCuadrado.Location = new System.Drawing.Point(181, 98);
            this.btnAlCuadrado.Name = "btnAlCuadrado";
            this.btnAlCuadrado.Size = new System.Drawing.Size(35, 35);
            this.btnAlCuadrado.TabIndex = 25;
            this.btnAlCuadrado.Tag = "²";
            this.btnAlCuadrado.Text = "X²";
            this.btnAlCuadrado.UseVisualStyleBackColor = true;
            this.btnAlCuadrado.Click += new System.EventHandler(this.cargarOperador);
            // 
            // frmMiCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.btnAlCuadrado);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnBorrarCaracter);
            this.Controls.Add(this.btnComa);
            this.Controls.Add(this.btnMasMenos);
            this.Controls.Add(this.btnBorarr);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.tbxCalculo);
            this.Controls.Add(this.lblCalculadora);
            this.Controls.Add(this.btn1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 350);
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "frmMiCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi calculadora";
            this.Load += new System.EventHandler(this.frmMiCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.TextBox tbxCalculo;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorarr;
        private System.Windows.Forms.Button btnMasMenos;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.Button btnBorrarCaracter;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnAlCuadrado;
    }
}

