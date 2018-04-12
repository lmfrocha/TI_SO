namespace TrabalhoIntegradoComSO
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLoadLista = new System.Windows.Forms.Button();
            this.txInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(707, 388);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start !";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnLoadLista
            // 
            this.btnLoadLista.Location = new System.Drawing.Point(707, 332);
            this.btnLoadLista.Name = "btnLoadLista";
            this.btnLoadLista.Size = new System.Drawing.Size(81, 50);
            this.btnLoadLista.TabIndex = 1;
            this.btnLoadLista.Text = "Carregar Lista";
            this.btnLoadLista.UseVisualStyleBackColor = true;
            this.btnLoadLista.Click += new System.EventHandler(this.btnLoadLista_Click);
            // 
            // txInfo
            // 
            this.txInfo.Location = new System.Drawing.Point(454, 388);
            this.txInfo.Name = "txInfo";
            this.txInfo.Size = new System.Drawing.Size(164, 20);
            this.txInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txInfo);
            this.Controls.Add(this.btnLoadLista);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLoadLista;
        private System.Windows.Forms.TextBox txInfo;
    }
}

