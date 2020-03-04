namespace Trabalho_de_Conclusão_de_Disciplina
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRingo = new System.Windows.Forms.TextBox();
            this.txtGeorge = new System.Windows.Forms.TextBox();
            this.txtPaul = new System.Windows.Forms.TextBox();
            this.txtJohn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEnredo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtRingo);
            this.groupBox1.Controls.Add(this.txtGeorge);
            this.groupBox1.Controls.Add(this.txtPaul);
            this.groupBox1.Controls.Add(this.txtJohn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("BOOTLE", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSIRA OS TEMPOS:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(300, 27);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(55, 44);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "15";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar);
            // 
            // txtRingo
            // 
            this.txtRingo.Location = new System.Drawing.Point(291, 109);
            this.txtRingo.Name = "txtRingo";
            this.txtRingo.Size = new System.Drawing.Size(64, 44);
            this.txtRingo.TabIndex = 4;
            this.txtRingo.Text = "4";
            this.txtRingo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRingo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar);
            // 
            // txtGeorge
            // 
            this.txtGeorge.Location = new System.Drawing.Point(202, 109);
            this.txtGeorge.Name = "txtGeorge";
            this.txtGeorge.Size = new System.Drawing.Size(62, 44);
            this.txtGeorge.TabIndex = 4;
            this.txtGeorge.Text = "3";
            this.txtGeorge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGeorge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar);
            // 
            // txtPaul
            // 
            this.txtPaul.Location = new System.Drawing.Point(113, 110);
            this.txtPaul.Name = "txtPaul";
            this.txtPaul.Size = new System.Drawing.Size(62, 44);
            this.txtPaul.TabIndex = 4;
            this.txtPaul.Text = "2";
            this.txtPaul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar);
            // 
            // txtJohn
            // 
            this.txtJohn.Location = new System.Drawing.Point(24, 110);
            this.txtJohn.Name = "txtJohn";
            this.txtJohn.Size = new System.Drawing.Size(62, 44);
            this.txtJohn.TabIndex = 3;
            this.txtJohn.Text = "1";
            this.txtJohn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtJohn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BOOTLE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(297, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ringo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BOOTLE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(202, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "George";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BOOTLE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BOOTLE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "John";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("BOOTLE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo total:";
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJogar.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.White;
            this.btnJogar.Location = new System.Drawing.Point(13, 514);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(177, 39);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(212, 514);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(177, 39);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEnredo
            // 
            this.btnEnredo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnredo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnredo.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnredo.ForeColor = System.Drawing.Color.White;
            this.btnEnredo.Location = new System.Drawing.Point(24, 294);
            this.btnEnredo.Name = "btnEnredo";
            this.btnEnredo.Size = new System.Drawing.Size(122, 36);
            this.btnEnredo.TabIndex = 3;
            this.btnEnredo.Text = "ENREDO";
            this.btnEnredo.UseVisualStyleBackColor = false;
            this.btnEnredo.Click += new System.EventHandler(this.btnEnredo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(401, 563);
            this.Controls.Add(this.btnEnredo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRingo;
        private System.Windows.Forms.TextBox txtGeorge;
        private System.Windows.Forms.TextBox txtPaul;
        private System.Windows.Forms.TextBox txtJohn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnEnredo;
    }
}

