﻿namespace Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOper = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.numOper2 = new System.Windows.Forms.NumericUpDown();
            this.numOper1 = new System.Windows.Forms.NumericUpDown();
            this.btIgual = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operando 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operando 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(279, 127);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(31, 29);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "...";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(70, 380);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(266, 37);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOper2
            // 
            this.numOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper2.Location = new System.Drawing.Point(217, 191);
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
            this.numOper2.Size = new System.Drawing.Size(120, 35);
            this.numOper2.TabIndex = 4;
            // 
            // numOper1
            // 
            this.numOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper1.Location = new System.Drawing.Point(216, 52);
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
            this.numOper1.Size = new System.Drawing.Size(120, 35);
            this.numOper1.TabIndex = 5;
            // 
            // btIgual
            // 
            this.btIgual.Enabled = false;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(94, 271);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(216, 49);
            this.btIgual.TabIndex = 6;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(217, 121);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(47, 41);
            this.btDiv.TabIndex = 7;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btMult
            // 
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMult.Location = new System.Drawing.Point(164, 121);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(47, 41);
            this.btMult.TabIndex = 8;
            this.btMult.Text = "x";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(111, 121);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(47, 41);
            this.btSub.TabIndex = 9;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.Location = new System.Drawing.Point(58, 121);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(47, 41);
            this.btSoma.TabIndex = 10;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculadora.Properties.Resources.cd_ricardo_pessoa;
            this.ClientSize = new System.Drawing.Size(762, 589);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.numOper1);
            this.Controls.Add(this.numOper2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown numOper2;
        private System.Windows.Forms.NumericUpDown numOper1;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btSoma;
    }
}

