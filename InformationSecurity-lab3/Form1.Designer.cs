
namespace InformationSecurity_lab3
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
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keySizeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.privateKeyTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.generateKeyBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.publicKeyTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.replaceTextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 32);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(776, 120);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Входной текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Размер ключа";
            // 
            // keySizeBox
            // 
            this.keySizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keySizeBox.Items.AddRange(new object[] {
            "5",
            "10",
            "30",
            "50",
            "70",
            "90",
            "110",
            "130",
            "150"});
            this.keySizeBox.Location = new System.Drawing.Point(12, 243);
            this.keySizeBox.Name = "keySizeBox";
            this.keySizeBox.Size = new System.Drawing.Size(151, 28);
            this.keySizeBox.TabIndex = 3;
            this.keySizeBox.SelectedIndexChanged += new System.EventHandler(this.keySizeBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Закрытый ключ";
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.Location = new System.Drawing.Point(12, 297);
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.ReadOnly = true;
            this.privateKeyTextBox.Size = new System.Drawing.Size(776, 97);
            this.privateKeyTextBox.TabIndex = 5;
            this.privateKeyTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "N";
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(12, 543);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.ReadOnly = true;
            this.mTextBox.Size = new System.Drawing.Size(647, 27);
            this.mTextBox.TabIndex = 8;
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(665, 543);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.ReadOnly = true;
            this.nTextBox.Size = new System.Drawing.Size(125, 27);
            this.nTextBox.TabIndex = 9;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(12, 158);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(160, 29);
            this.openFileBtn.TabIndex = 10;
            this.openFileBtn.Text = "Загрузить из файла";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 633);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Выходной текст";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 656);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(776, 120);
            this.outputTextBox.TabIndex = 11;
            this.outputTextBox.Text = "";
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(12, 576);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(160, 29);
            this.encryptBtn.TabIndex = 13;
            this.encryptBtn.Text = "Зашифровать";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(178, 576);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(160, 29);
            this.decryptBtn.TabIndex = 14;
            this.decryptBtn.Text = "Расшифровать";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // generateKeyBtn
            // 
            this.generateKeyBtn.Location = new System.Drawing.Point(344, 576);
            this.generateKeyBtn.Name = "generateKeyBtn";
            this.generateKeyBtn.Size = new System.Drawing.Size(160, 29);
            this.generateKeyBtn.TabIndex = 15;
            this.generateKeyBtn.Text = "Создать случ. ключ";
            this.generateKeyBtn.UseVisualStyleBackColor = true;
            this.generateKeyBtn.Click += new System.EventHandler(this.generateKeyBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Location = new System.Drawing.Point(12, 420);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.ReadOnly = true;
            this.publicKeyTextBox.Size = new System.Drawing.Size(776, 97);
            this.publicKeyTextBox.TabIndex = 18;
            this.publicKeyTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Открытый ключ";
            // 
            // replaceTextBtn
            // 
            this.replaceTextBtn.Location = new System.Drawing.Point(630, 576);
            this.replaceTextBtn.Name = "replaceTextBtn";
            this.replaceTextBtn.Size = new System.Drawing.Size(160, 29);
            this.replaceTextBtn.TabIndex = 19;
            this.replaceTextBtn.Text = "Replace text";
            this.replaceTextBtn.UseVisualStyleBackColor = true;
            this.replaceTextBtn.Click += new System.EventHandler(this.replaceTextBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 784);
            this.Controls.Add(this.replaceTextBtn);
            this.Controls.Add(this.publicKeyTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.generateKeyBtn);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.mTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.privateKeyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keySizeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox keySizeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox privateKeyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button generateKeyBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox publicKeyTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button replaceTextBtn;
    }
}

