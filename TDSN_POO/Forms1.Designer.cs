﻿
namespace TDSN2024
{
    partial class Forms1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblForma = new System.Windows.Forms.Label();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.cmbTriangulo = new System.Windows.Forms.ComboBox();
            this.cmbObjetos = new System.Windows.Forms.ComboBox();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.Label();
            this.txtHipotenusa = new System.Windows.Forms.Label();
            this.lblHipotenusa = new System.Windows.Forms.Label();
            this.AlturaEquilátero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.BackColor = System.Drawing.Color.Transparent;
            this.lblForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForma.Location = new System.Drawing.Point(28, 27);
            this.lblForma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(48, 17);
            this.lblForma.TabIndex = 0;
            this.lblForma.Text = "Forma";
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriangulo.Location = new System.Drawing.Point(190, 26);
            this.lblTriangulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(68, 17);
            this.lblTriangulo.TabIndex = 1;
            this.lblTriangulo.Text = "Triângulo";
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.White;
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(365, 24);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(50, 22);
            this.btnCriar.TabIndex = 2;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // cmbForma
            // 
            this.cmbForma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            "Circunferência",
            "Quadrado",
            "Retângulo",
            "Triângulo"});
            this.cmbForma.Location = new System.Drawing.Point(76, 24);
            this.cmbForma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(96, 23);
            this.cmbForma.TabIndex = 3;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.cmbForma_SelectedIndexChanged);
            // 
            // cmbTriangulo
            // 
            this.cmbTriangulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTriangulo.FormattingEnabled = true;
            this.cmbTriangulo.Items.AddRange(new object[] {
            "Reto",
            "Equilátero",
            "Isósceles"});
            this.cmbTriangulo.Location = new System.Drawing.Point(253, 24);
            this.cmbTriangulo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTriangulo.Name = "cmbTriangulo";
            this.cmbTriangulo.Size = new System.Drawing.Size(84, 23);
            this.cmbTriangulo.TabIndex = 4;
            this.cmbTriangulo.SelectedIndexChanged += new System.EventHandler(this.cmbTriangulo_SelectedIndexChanged);
            // 
            // cmbObjetos
            // 
            this.cmbObjetos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObjetos.FormattingEnabled = true;
            this.cmbObjetos.Location = new System.Drawing.Point(420, 24);
            this.cmbObjetos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbObjetos.Name = "cmbObjetos";
            this.cmbObjetos.Size = new System.Drawing.Size(101, 23);
            this.cmbObjetos.TabIndex = 5;
            this.cmbObjetos.SelectedIndexChanged += new System.EventHandler(this.cmbObjetos_SelectedIndexChanged);
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.BackColor = System.Drawing.Color.Transparent;
            this.lblRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaio.Location = new System.Drawing.Point(35, 71);
            this.lblRaio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(37, 17);
            this.lblRaio.TabIndex = 6;
            this.lblRaio.Text = "Raio";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.BackColor = System.Drawing.Color.Transparent;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.Location = new System.Drawing.Point(35, 69);
            this.lblLado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(40, 17);
            this.lblLado.TabIndex = 7;
            this.lblLado.Text = "Lado";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.BackColor = System.Drawing.Color.Transparent;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(35, 100);
            this.lblBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(40, 17);
            this.lblBase.TabIndex = 8;
            this.lblBase.Text = "Base";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(35, 133);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 17);
            this.lblAltura.TabIndex = 9;
            this.lblAltura.Text = "Altura";
            // 
            // txtRaio
            // 
            this.txtRaio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaio.Location = new System.Drawing.Point(82, 69);
            this.txtRaio.Margin = new System.Windows.Forms.Padding(2);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(68, 21);
            this.txtRaio.TabIndex = 10;
            // 
            // txtLado
            // 
            this.txtLado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado.Location = new System.Drawing.Point(82, 69);
            this.txtLado.Margin = new System.Windows.Forms.Padding(2);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(68, 21);
            this.txtLado.TabIndex = 11;
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.Location = new System.Drawing.Point(82, 99);
            this.txtBase.Margin = new System.Windows.Forms.Padding(2);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(68, 21);
            this.txtBase.TabIndex = 12;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(82, 132);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(68, 21);
            this.txtAltura.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Área";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Perímetro";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(282, 69);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(83, 21);
            this.txtArea.TabIndex = 16;
            this.txtArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPerimetro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerimetro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimetro.Location = new System.Drawing.Point(282, 100);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(83, 21);
            this.txtPerimetro.TabIndex = 17;
            this.txtPerimetro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHipotenusa
            // 
            this.txtHipotenusa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHipotenusa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHipotenusa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHipotenusa.Location = new System.Drawing.Point(282, 136);
            this.txtHipotenusa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtHipotenusa.Name = "txtHipotenusa";
            this.txtHipotenusa.Size = new System.Drawing.Size(83, 22);
            this.txtHipotenusa.TabIndex = 18;
            this.txtHipotenusa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtHipotenusa.Click += new System.EventHandler(this.txtHipotenusa_Click);
            // 
            // lblHipotenusa
            // 
            this.lblHipotenusa.AutoSize = true;
            this.lblHipotenusa.BackColor = System.Drawing.Color.Transparent;
            this.lblHipotenusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHipotenusa.Location = new System.Drawing.Point(198, 136);
            this.lblHipotenusa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHipotenusa.Name = "lblHipotenusa";
            this.lblHipotenusa.Size = new System.Drawing.Size(80, 17);
            this.lblHipotenusa.TabIndex = 19;
            this.lblHipotenusa.Text = "Hipotenusa";
            // 
            // AlturaEquilátero
            // 
            this.AlturaEquilátero.AutoSize = true;
            this.AlturaEquilátero.BackColor = System.Drawing.Color.Transparent;
            this.AlturaEquilátero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlturaEquilátero.Location = new System.Drawing.Point(80, 136);
            this.AlturaEquilátero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlturaEquilátero.Name = "AlturaEquilátero";
            this.AlturaEquilátero.Size = new System.Drawing.Size(0, 15);
            this.AlturaEquilátero.TabIndex = 21;
            // 
            // Forms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 288);
            this.Controls.Add(this.AlturaEquilátero);
            this.Controls.Add(this.lblHipotenusa);
            this.Controls.Add(this.txtHipotenusa);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblRaio);
            this.Controls.Add(this.cmbObjetos);
            this.Controls.Add(this.cmbTriangulo);
            this.Controls.Add(this.cmbForma);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.lblForma);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Forms1";
            this.Text = "TDSN ";
            this.Load += new System.EventHandler(this.APFormas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.ComboBox cmbTriangulo;
        private System.Windows.Forms.ComboBox cmbObjetos;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtArea;
        private System.Windows.Forms.Label txtPerimetro;
        private System.Windows.Forms.Label txtHipotenusa;
        private System.Windows.Forms.Label lblHipotenusa;
        private System.Windows.Forms.Label AlturaEquilátero;
    }
}

