namespace Ceaser_sCipher_WinForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.isDecoding = new System.Windows.Forms.CheckBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isDecoding
            // 
            this.isDecoding.AutoSize = true;
            this.isDecoding.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.isDecoding.Location = new System.Drawing.Point(562, 278);
            this.isDecoding.Name = "isDecoding";
            this.isDecoding.Size = new System.Drawing.Size(138, 25);
            this.isDecoding.TabIndex = 0;
            this.isDecoding.Text = "розшифровка";
            this.isDecoding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isDecoding.UseVisualStyleBackColor = true;
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputBox.Location = new System.Drawing.Point(53, 64);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.PlaceholderText = "введіть ваш текст сюди";
            this.inputBox.Size = new System.Drawing.Size(403, 230);
            this.inputBox.TabIndex = 1;
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultBox.Location = new System.Drawing.Point(53, 325);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.PlaceholderText = "резульат виведеться в цьому полі";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(403, 241);
            this.resultBox.TabIndex = 2;
            // 
            // keyInput
            // 
            this.keyInput.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keyInput.Location = new System.Drawing.Point(511, 221);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(74, 26);
            this.keyInput.TabIndex = 3;
            this.keyInput.TextChanged += new System.EventHandler(this.keyInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(591, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "число зсуву (ключ)";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(546, 338);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(175, 44);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "конвертувати";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 620);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.isDecoding);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceaser`s Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox isDecoding;
        private TextBox inputBox;
        private TextBox resultBox;
        private TextBox keyInput;
        private Label label1;
        private Button startButton;
    }
}