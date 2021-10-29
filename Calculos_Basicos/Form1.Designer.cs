
namespace Calculos_Basicos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(206, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁLCULOS BÁSICOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(107, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIGITE O 1º NÚMERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(107, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIGITE O 2º NÚMERO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(98, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "RESULTADO";
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.Lime;
            this.btnSomar.FlatAppearance.BorderSize = 0;
            this.btnSomar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSomar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomar.Location = new System.Drawing.Point(173, 203);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(42, 43);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.Lime;
            this.btnSubtrair.FlatAppearance.BorderSize = 0;
            this.btnSubtrair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSubtrair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrair.Location = new System.Drawing.Point(225, 203);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(40, 43);
            this.btnSubtrair.TabIndex = 5;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.Lime;
            this.btnMultiplicar.FlatAppearance.BorderSize = 0;
            this.btnMultiplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnMultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Location = new System.Drawing.Point(273, 203);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(42, 43);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Lime;
            this.btnDividir.FlatAppearance.BorderSize = 0;
            this.btnDividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Location = new System.Drawing.Point(323, 203);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(4);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(45, 43);
            this.btnDividir.TabIndex = 7;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.ForeColor = System.Drawing.Color.Red;
            this.txtResultado.Location = new System.Drawing.Point(243, 284);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(275, 26);
            this.txtResultado.TabIndex = 8;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum2.ForeColor = System.Drawing.Color.Red;
            this.txtNum2.Location = new System.Drawing.Point(307, 158);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(211, 26);
            this.txtNum2.TabIndex = 9;
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum1.ForeColor = System.Drawing.Color.Red;
            this.txtNum1.Location = new System.Drawing.Point(307, 117);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(211, 26);
            this.txtNum1.TabIndex = 10;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Lime;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(151, 343);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 44);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Lime;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(352, 343);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 44);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 429);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

