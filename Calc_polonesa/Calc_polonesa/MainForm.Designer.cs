/*
 * Created by SharpDevelop.
 * User: 93248003
 * Date: 09/04/2018
 * Time: 09:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calc_polonesa
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtExpressao = new System.Windows.Forms.TextBox();
			this.txtExpressaoPosfixa = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.BtnCalcular = new System.Windows.Forms.Button();
			this.BtnClear = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(144, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Expressão";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(111, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Expressão Pos Fixa";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(144, 228);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Resultado";
			// 
			// txtExpressao
			// 
			this.txtExpressao.Location = new System.Drawing.Point(56, 20);
			this.txtExpressao.Name = "txtExpressao";
			this.txtExpressao.Size = new System.Drawing.Size(240, 20);
			this.txtExpressao.TabIndex = 3;
			// 
			// txtExpressaoPosfixa
			// 
			this.txtExpressaoPosfixa.Location = new System.Drawing.Point(56, 120);
			this.txtExpressaoPosfixa.Name = "txtExpressaoPosfixa";
			this.txtExpressaoPosfixa.Size = new System.Drawing.Size(240, 20);
			this.txtExpressaoPosfixa.TabIndex = 4;
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(56, 205);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(240, 20);
			this.txtResult.TabIndex = 5;
			// 
			// BtnCalcular
			// 
			this.BtnCalcular.Location = new System.Drawing.Point(340, 59);
			this.BtnCalcular.Name = "BtnCalcular";
			this.BtnCalcular.Size = new System.Drawing.Size(75, 41);
			this.BtnCalcular.TabIndex = 6;
			this.BtnCalcular.Text = "Calcular";
			this.BtnCalcular.UseVisualStyleBackColor = true;
			this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			this.BtnCalcular.Enter += new System.EventHandler(this.BtnCalcularClick);
			// 
			// BtnClear
			// 
			this.BtnClear.Location = new System.Drawing.Point(340, 153);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(75, 45);
			this.BtnClear.TabIndex = 7;
			this.BtnClear.Text = "Limpar";
			this.BtnClear.UseVisualStyleBackColor = true;
			this.BtnClear.Click += new System.EventHandler(this.BtnClearClick);
			
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "( + )";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(27, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(22, 19);
			this.label5.TabIndex = 9;
			this.label5.Text = "( - )";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(67, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 14);
			this.label6.TabIndex = 10;
			this.label6.Text = "( / )";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(48, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "( * )";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(90, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(27, 17);
			this.label8.TabIndex = 12;
			this.label8.Text = "( ^ )";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(114, 21);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 17);
			this.label9.TabIndex = 13;
			this.label9.Text = "( r )";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(12, 59);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(146, 41);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operações";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Location = new System.Drawing.Point(164, 59);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(146, 41);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Exemplo";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(18, 19);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(114, 16);
			this.label13.TabIndex = 8;
			this.label13.Text = "1+2-3*5(r25+(2^4))/10";
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(427, 265);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.BtnClear);
			this.Controls.Add(this.BtnCalcular);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtExpressaoPosfixa);
			this.Controls.Add(this.txtExpressao);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Calculadora Polonesa Reversa";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.Button BtnCalcular;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.TextBox txtExpressaoPosfixa;
		private System.Windows.Forms.TextBox txtExpressao;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		
	}
}
