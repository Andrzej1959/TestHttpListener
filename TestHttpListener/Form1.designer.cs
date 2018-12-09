namespace TestHttpListener
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelReqQuerry = new System.Windows.Forms.Label();
            this.labelReqParam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelContentType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHeders = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelReqQuerry
            // 
            this.labelReqQuerry.AutoSize = true;
            this.labelReqQuerry.Location = new System.Drawing.Point(236, 207);
            this.labelReqQuerry.Name = "labelReqQuerry";
            this.labelReqQuerry.Size = new System.Drawing.Size(124, 13);
            this.labelReqQuerry.TabIndex = 5;
            this.labelReqQuerry.Text = "Querry String Parameters";
            // 
            // labelReqParam
            // 
            this.labelReqParam.AutoSize = true;
            this.labelReqParam.Location = new System.Drawing.Point(236, 54);
            this.labelReqParam.Name = "labelReqParam";
            this.labelReqParam.Size = new System.Drawing.Size(103, 13);
            this.labelReqParam.TabIndex = 13;
            this.labelReqParam.Text = "Request Parameters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Content";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(185, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "listen";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(598, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Listener";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "1777";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(245, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "port";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBoxResponse);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Location = new System.Drawing.Point(506, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 429);
            this.panel2.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Start Stop the listener -->";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(343, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "To run the listener, the program must be run with administrator privileges";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(63, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Received Request";
            // 
            // labelContentType
            // 
            this.labelContentType.AutoSize = true;
            this.labelContentType.Location = new System.Drawing.Point(99, 266);
            this.labelContentType.Name = "labelContentType";
            this.labelContentType.Size = new System.Drawing.Size(27, 13);
            this.labelContentType.TabIndex = 25;
            this.labelContentType.Text = "type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(46, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Content";
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(10, 271);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(395, 144);
            this.textBoxResponse.TabIndex = 23;
            this.textBoxResponse.Text = "Example response content\r\nThe program must be run with administrator privileges";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(128, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Response to Send";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(25, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 211);
            this.panel3.TabIndex = 21;
            // 
            // labelHeders
            // 
            this.labelHeders.AutoSize = true;
            this.labelHeders.Location = new System.Drawing.Point(22, 54);
            this.labelHeders.Name = "labelHeders";
            this.labelHeders.Size = new System.Drawing.Size(41, 13);
            this.labelHeders.TabIndex = 15;
            this.labelHeders.Text = "Heders";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 572);
            this.Controls.Add(this.labelHeders);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelContentType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelReqQuerry);
            this.Controls.Add(this.labelReqParam);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "http Sender and Listener";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelReqQuerry;
        private System.Windows.Forms.Label labelReqParam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelContentType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelHeders;
    }
}

