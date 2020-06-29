namespace Exe3_CVSDS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTemperaturaC = new System.Windows.Forms.Label();
            this.txtTempF = new System.Windows.Forms.TextBox();
            this.txtTempK = new System.Windows.Forms.TextBox();
            this.txtTempC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTempK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 141);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTemperaturaC
            // 
            this.lblTemperaturaC.AutoSize = true;
            this.lblTemperaturaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperaturaC.Location = new System.Drawing.Point(9, 97);
            this.lblTemperaturaC.Name = "lblTemperaturaC";
            this.lblTemperaturaC.Size = new System.Drawing.Size(148, 18);
            this.lblTemperaturaC.TabIndex = 1;
            this.lblTemperaturaC.Text = "Digite a temperatura :";
            // 
            // txtTempF
            // 
            this.txtTempF.Location = new System.Drawing.Point(181, 204);
            this.txtTempF.Name = "txtTempF";
            this.txtTempF.Size = new System.Drawing.Size(100, 20);
            this.txtTempF.TabIndex = 2;
            // 
            // txtTempK
            // 
            this.txtTempK.Location = new System.Drawing.Point(181, 237);
            this.txtTempK.Name = "txtTempK";
            this.txtTempK.Size = new System.Drawing.Size(100, 20);
            this.txtTempK.TabIndex = 3;
            // 
            // txtTempC
            // 
            this.txtTempC.Location = new System.Drawing.Point(181, 98);
            this.txtTempC.Name = "txtTempC";
            this.txtTempC.Size = new System.Drawing.Size(100, 20);
            this.txtTempC.TabIndex = 4;
            this.txtTempC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperatura Fahrenheit :";
            // 
            // lblTempK
            // 
            this.lblTempK.AutoSize = true;
            this.lblTempK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempK.Location = new System.Drawing.Point(2, 237);
            this.lblTempK.Name = "lblTempK";
            this.lblTempK.Size = new System.Drawing.Size(143, 18);
            this.lblTempK.TabIndex = 6;
            this.lblTempK.Text = "Temperatura Kelvin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite a temperatura em Celsius ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 71);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Developer Carlos Vinícius Souza Dos Santos© ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Location = new System.Drawing.Point(361, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 319);
            this.panel2.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(42, 268);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTempK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTempC);
            this.Controls.Add(this.txtTempK);
            this.Controls.Add(this.txtTempF);
            this.Controls.Add(this.lblTemperaturaC);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Convertendo as temperaturas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTemperaturaC;
        private System.Windows.Forms.TextBox txtTempF;
        private System.Windows.Forms.TextBox txtTempK;
        private System.Windows.Forms.TextBox txtTempC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTempK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
    }
}

