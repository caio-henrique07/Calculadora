namespace Calculadora
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblOper = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.numOper2 = new System.Windows.Forms.NumericUpDown();
            this.numOper1 = new System.Windows.Forms.NumericUpDown();
            this.btIgual = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            this.btSeguir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(61, 69);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(205, 39);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Operando 1:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(61, 235);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(205, 39);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Operando 2:";
            this.lbl2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(372, 156);
            this.lblOper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(39, 36);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "...";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(68, 460);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(380, 54);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOper2
            // 
            this.numOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper2.Location = new System.Drawing.Point(289, 235);
            this.numOper2.Margin = new System.Windows.Forms.Padding(4);
            this.numOper2.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numOper2.Minimum = new decimal(new int[] {
            -727379968,
            232,
            0,
            -2147483648});
            this.numOper2.Name = "numOper2";
            this.numOper2.Size = new System.Drawing.Size(160, 41);
            this.numOper2.TabIndex = 4;
            // 
            // numOper1
            // 
            this.numOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper1.Location = new System.Drawing.Point(288, 64);
            this.numOper1.Margin = new System.Windows.Forms.Padding(4);
            this.numOper1.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numOper1.Minimum = new decimal(new int[] {
            -727379968,
            232,
            0,
            -2147483648});
            this.numOper1.Name = "numOper1";
            this.numOper1.Size = new System.Drawing.Size(160, 41);
            this.numOper1.TabIndex = 5;
            // 
            // btIgual
            // 
            this.btIgual.Enabled = false;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(125, 334);
            this.btIgual.Margin = new System.Windows.Forms.Padding(4);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(288, 60);
            this.btIgual.TabIndex = 6;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(289, 149);
            this.btDiv.Margin = new System.Windows.Forms.Padding(4);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(63, 50);
            this.btDiv.TabIndex = 7;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btMult
            // 
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMult.Location = new System.Drawing.Point(219, 149);
            this.btMult.Margin = new System.Windows.Forms.Padding(4);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(63, 50);
            this.btMult.TabIndex = 8;
            this.btMult.Text = "x";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(148, 149);
            this.btSub.Margin = new System.Windows.Forms.Padding(4);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(63, 50);
            this.btSub.TabIndex = 9;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.Location = new System.Drawing.Point(77, 149);
            this.btSoma.Margin = new System.Windows.Forms.Padding(4);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(63, 50);
            this.btSoma.TabIndex = 10;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSeguir
            // 
            this.btSeguir.Location = new System.Drawing.Point(68, 557);
            this.btSeguir.Name = "btSeguir";
            this.btSeguir.Size = new System.Drawing.Size(143, 58);
            this.btSeguir.TabIndex = 11;
            this.btSeguir.Text = "SEGUE";
            this.btSeguir.UseVisualStyleBackColor = true;
            this.btSeguir.Click += new System.EventHandler(this.btSeguir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(305, 557);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(143, 58);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "LIMPA";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculadora.Properties.Resources.Captura_de_tela_2025_03_03_173019;
            this.ClientSize = new System.Drawing.Size(527, 725);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSeguir);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.numOper1);
            this.Controls.Add(this.numOper2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown numOper2;
        private System.Windows.Forms.NumericUpDown numOper1;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSeguir;
        private System.Windows.Forms.Button btLimpar;
    }
}

