namespace TelegramStickersHelper
{
    partial class formMain
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openTextButton = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.OpenFileDialog();
            this.saveTextButton = new System.Windows.Forms.Button();
            this.loadPicButton = new System.Windows.Forms.Button();
            this.picFile = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelOldText = new System.Windows.Forms.Label();
            this.newTextBox = new System.Windows.Forms.TextBox();
            this.labelTextPath = new System.Windows.Forms.Label();
            this.createFileButton = new System.Windows.Forms.Button();
            this.saveNameButton = new System.Windows.Forms.Button();
            this.labelNewText = new System.Windows.Forms.Label();
            this.labelPicPath = new System.Windows.Forms.Label();
            this.excelButton = new System.Windows.Forms.Button();
            this.nextPicButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 49);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(360, 200);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // openTextButton
            // 
            this.openTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTextButton.Location = new System.Drawing.Point(400, 173);
            this.openTextButton.Name = "openTextButton";
            this.openTextButton.Size = new System.Drawing.Size(100, 35);
            this.openTextButton.TabIndex = 1;
            this.openTextButton.Text = "open file";
            this.openTextButton.UseVisualStyleBackColor = true;
            this.openTextButton.Click += new System.EventHandler(this.openTextButton_Click);
            // 
            // textFile
            // 
            this.textFile.FileName = "textFile";
            // 
            // saveTextButton
            // 
            this.saveTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTextButton.Location = new System.Drawing.Point(400, 214);
            this.saveTextButton.Name = "saveTextButton";
            this.saveTextButton.Size = new System.Drawing.Size(100, 35);
            this.saveTextButton.TabIndex = 2;
            this.saveTextButton.Text = "save file";
            this.saveTextButton.UseVisualStyleBackColor = true;
            this.saveTextButton.Click += new System.EventHandler(this.saveTextButton_Click);
            // 
            // loadPicButton
            // 
            this.loadPicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPicButton.Location = new System.Drawing.Point(288, 407);
            this.loadPicButton.Name = "loadPicButton";
            this.loadPicButton.Size = new System.Drawing.Size(100, 35);
            this.loadPicButton.TabIndex = 4;
            this.loadPicButton.Text = "load pic";
            this.loadPicButton.UseVisualStyleBackColor = true;
            this.loadPicButton.Click += new System.EventHandler(this.loadPicButton_Click);
            // 
            // picFile
            // 
            this.picFile.FileName = "picFile";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 313);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(256, 256);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // labelOldText
            // 
            this.labelOldText.AutoSize = true;
            this.labelOldText.Location = new System.Drawing.Point(402, 49);
            this.labelOldText.Name = "labelOldText";
            this.labelOldText.Size = new System.Drawing.Size(98, 17);
            this.labelOldText.TabIndex = 6;
            this.labelOldText.Text = "Current name:";
            // 
            // newTextBox
            // 
            this.newTextBox.Location = new System.Drawing.Point(405, 112);
            this.newTextBox.Name = "newTextBox";
            this.newTextBox.Size = new System.Drawing.Size(100, 22);
            this.newTextBox.TabIndex = 7;
            // 
            // labelTextPath
            // 
            this.labelTextPath.AutoSize = true;
            this.labelTextPath.Location = new System.Drawing.Point(22, 13);
            this.labelTextPath.Name = "labelTextPath";
            this.labelTextPath.Size = new System.Drawing.Size(91, 17);
            this.labelTextPath.TabIndex = 9;
            this.labelTextPath.Text = "Current path:";
            // 
            // createFileButton
            // 
            this.createFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFileButton.Location = new System.Drawing.Point(505, 193);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(100, 35);
            this.createFileButton.TabIndex = 10;
            this.createFileButton.Text = "create";
            this.createFileButton.UseVisualStyleBackColor = true;
            this.createFileButton.Click += new System.EventHandler(this.createFileButton_Click);
            // 
            // saveNameButton
            // 
            this.saveNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNameButton.Location = new System.Drawing.Point(528, 105);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(100, 35);
            this.saveNameButton.TabIndex = 11;
            this.saveNameButton.Text = "save name";
            this.saveNameButton.UseVisualStyleBackColor = true;
            this.saveNameButton.Click += new System.EventHandler(this.saveNameButton_Click);
            // 
            // labelNewText
            // 
            this.labelNewText.AutoSize = true;
            this.labelNewText.Location = new System.Drawing.Point(405, 80);
            this.labelNewText.Name = "labelNewText";
            this.labelNewText.Size = new System.Drawing.Size(78, 17);
            this.labelNewText.TabIndex = 8;
            this.labelNewText.Text = "New name:";
            // 
            // labelPicPath
            // 
            this.labelPicPath.AutoSize = true;
            this.labelPicPath.Location = new System.Drawing.Point(22, 271);
            this.labelPicPath.Name = "labelPicPath";
            this.labelPicPath.Size = new System.Drawing.Size(91, 17);
            this.labelPicPath.TabIndex = 12;
            this.labelPicPath.Text = "Current path:";
            // 
            // excelButton
            // 
            this.excelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelButton.Location = new System.Drawing.Point(465, 407);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(100, 35);
            this.excelButton.TabIndex = 13;
            this.excelButton.Text = "excel";
            this.excelButton.UseVisualStyleBackColor = true;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // nextPicButton
            // 
            this.nextPicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPicButton.Location = new System.Drawing.Point(288, 356);
            this.nextPicButton.Name = "nextPicButton";
            this.nextPicButton.Size = new System.Drawing.Size(100, 35);
            this.nextPicButton.TabIndex = 14;
            this.nextPicButton.Text = "next pic";
            this.nextPicButton.UseVisualStyleBackColor = true;
            this.nextPicButton.Click += new System.EventHandler(this.nextPicButton_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 581);
            this.Controls.Add(this.nextPicButton);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.labelPicPath);
            this.Controls.Add(this.saveNameButton);
            this.Controls.Add(this.createFileButton);
            this.Controls.Add(this.labelTextPath);
            this.Controls.Add(this.labelNewText);
            this.Controls.Add(this.newTextBox);
            this.Controls.Add(this.labelOldText);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.loadPicButton);
            this.Controls.Add(this.saveTextButton);
            this.Controls.Add(this.openTextButton);
            this.Controls.Add(this.richTextBox);
            this.Name = "formMain";
            this.Text = "formMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button openTextButton;
        private System.Windows.Forms.OpenFileDialog textFile;
        private System.Windows.Forms.Button saveTextButton;
        private System.Windows.Forms.Button loadPicButton;
        private System.Windows.Forms.OpenFileDialog picFile;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelOldText;
        private System.Windows.Forms.TextBox newTextBox;
        private System.Windows.Forms.Label labelTextPath;
        private System.Windows.Forms.Button createFileButton;
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.Label labelNewText;
        private System.Windows.Forms.Label labelPicPath;
        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Button nextPicButton;
    }
}

