namespace MinhaAplicação
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
            rdSuco = new RadioButton();
            rdTv = new RadioButton();
            rdRadio = new RadioButton();
            txtBox = new TextBox();
            btn1 = new Button();
            SuspendLayout();
            // 
            // rdSuco
            // 
            rdSuco.AutoSize = true;
            rdSuco.Checked = true;
            rdSuco.Location = new Point(109, 77);
            rdSuco.Name = "rdSuco";
            rdSuco.Size = new Size(114, 24);
            rdSuco.TabIndex = 0;
            rdSuco.TabStop = true;
            rdSuco.Text = "radioButton1";
            rdSuco.UseVisualStyleBackColor = true;
            // 
            // rdTv
            // 
            rdTv.AutoSize = true;
            rdTv.Location = new Point(109, 132);
            rdTv.Name = "rdTv";
            rdTv.Size = new Size(44, 24);
            rdTv.TabIndex = 1;
            rdTv.Text = "TV";
            rdTv.UseVisualStyleBackColor = true;
            // 
            // rdRadio
            // 
            rdRadio.AutoSize = true;
            rdRadio.Location = new Point(109, 194);
            rdRadio.Name = "rdRadio";
            rdRadio.Size = new Size(66, 24);
            rdRadio.TabIndex = 2;
            rdRadio.Text = "Rádio";
            rdRadio.UseVisualStyleBackColor = true;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(109, 258);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(100, 27);
            txtBox.TabIndex = 3;
            // 
            // btn1
            // 
            btn1.Location = new Point(105, 338);
            btn1.Name = "btn1";
            btn1.Size = new Size(91, 32);
            btn1.TabIndex = 4;
            btn1.Text = "OK";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 450);
            Controls.Add(btn1);
            Controls.Add(txtBox);
            Controls.Add(rdRadio);
            Controls.Add(rdTv);
            Controls.Add(rdSuco);
            Name = "Form1";
            Text = "Título x";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdSuco;
        private RadioButton rdTv;
        private RadioButton rdRadio;
        private TextBox txtBox;
        private Button btn1;
    }
}