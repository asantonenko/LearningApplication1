namespace LearningApplication1
{
    partial class LearningForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lPictureName = new System.Windows.Forms.Label();
            this.bRestart = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.cbShowPictures = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 10);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(510, 295);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(528, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lPictureName
            // 
            this.lPictureName.AutoSize = true;
            this.lPictureName.Location = new System.Drawing.Point(620, 296);
            this.lPictureName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPictureName.Name = "lPictureName";
            this.lPictureName.Size = new System.Drawing.Size(71, 13);
            this.lPictureName.TabIndex = 2;
            this.lPictureName.Text = "Picture Name";
            // 
            // bRestart
            // 
            this.bRestart.Location = new System.Drawing.Point(238, 310);
            this.bRestart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(56, 27);
            this.bRestart.TabIndex = 3;
            this.bRestart.Text = "Restart";
            this.bRestart.UseVisualStyleBackColor = true;
            this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(476, 310);
            this.bNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(64, 27);
            this.bNext.TabIndex = 4;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(359, 310);
            this.bBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(70, 26);
            this.bBack.TabIndex = 5;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // cbShowPictures
            // 
            this.cbShowPictures.AutoSize = true;
            this.cbShowPictures.Checked = true;
            this.cbShowPictures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowPictures.Location = new System.Drawing.Point(575, 317);
            this.cbShowPictures.Name = "cbShowPictures";
            this.cbShowPictures.Size = new System.Drawing.Size(93, 17);
            this.cbShowPictures.TabIndex = 6;
            this.cbShowPictures.Text = "Show pictures";
            this.cbShowPictures.UseVisualStyleBackColor = true;
            this.cbShowPictures.CheckedChanged += new System.EventHandler(this.cbShowPictures_CheckedChanged);
            // 
            // LearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 346);
            this.Controls.Add(this.cbShowPictures);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bRestart);
            this.Controls.Add(this.lPictureName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LearningForm";
            this.Text = "Learning";
            this.Load += new System.EventHandler(this.LearningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lPictureName;
        private System.Windows.Forms.Button bRestart;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.CheckBox cbShowPictures;
    }
}

