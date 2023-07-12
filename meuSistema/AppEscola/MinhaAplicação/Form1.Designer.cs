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
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(428, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(73, 24);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // button1
            // 
            button1.Location = new Point(271, 321);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            Controls.Add(button1);
            Controls.Add(btn1);
            Controls.Add(txtBox);
            Controls.Add(rdRadio);
            Controls.Add(rdTv);
            Controls.Add(rdSuco);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Título x";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdSuco;
        private RadioButton rdTv;
        private RadioButton rdRadio;
        private TextBox txtBox;
        private Button btn1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private Button button1;
    }
}