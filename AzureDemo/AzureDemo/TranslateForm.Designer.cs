namespace AzureDemo
{
    partial class TranslateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslateForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.savedWordNavBtn = new System.Windows.Forms.Button();
            this.quizNavBtn = new System.Windows.Forms.Button();
            this.newWordNavBtn = new System.Windows.Forms.Button();
            this.translateNavBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.savedWordNavBtn);
            this.splitContainer1.Panel1.Controls.Add(this.quizNavBtn);
            this.splitContainer1.Panel1.Controls.Add(this.newWordNavBtn);
            this.splitContainer1.Panel1.Controls.Add(this.translateNavBtn);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.button10);
            this.splitContainer1.Panel2.Controls.Add(this.button9);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.button8);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1348, 721);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::AzureDemo.Properties.Resources.fb_ic_arrow_back;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 502);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(364, 64);
            this.button2.TabIndex = 6;
            this.button2.Text = "       Đăng xuất";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.logoutNavBtn_Click);
            // 
            // savedWordNavBtn
            // 
            this.savedWordNavBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.savedWordNavBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedWordNavBtn.Image = ((System.Drawing.Image)(resources.GetObject("savedWordNavBtn.Image")));
            this.savedWordNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savedWordNavBtn.Location = new System.Drawing.Point(0, 376);
            this.savedWordNavBtn.Name = "savedWordNavBtn";
            this.savedWordNavBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.savedWordNavBtn.Size = new System.Drawing.Size(364, 64);
            this.savedWordNavBtn.TabIndex = 5;
            this.savedWordNavBtn.Text = "       Từ vựng của tôi";
            this.savedWordNavBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savedWordNavBtn.UseVisualStyleBackColor = false;
            this.savedWordNavBtn.Click += new System.EventHandler(this.savedWordNavBtn_Click);
            // 
            // quizNavBtn
            // 
            this.quizNavBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.quizNavBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizNavBtn.Image = ((System.Drawing.Image)(resources.GetObject("quizNavBtn.Image")));
            this.quizNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quizNavBtn.Location = new System.Drawing.Point(0, 439);
            this.quizNavBtn.Name = "quizNavBtn";
            this.quizNavBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.quizNavBtn.Size = new System.Drawing.Size(364, 64);
            this.quizNavBtn.TabIndex = 4;
            this.quizNavBtn.Text = "       Câu hỏi ôn tập";
            this.quizNavBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quizNavBtn.UseVisualStyleBackColor = false;
            this.quizNavBtn.Click += new System.EventHandler(this.quizNavBtn_Click);
            // 
            // newWordNavBtn
            // 
            this.newWordNavBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.newWordNavBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWordNavBtn.Image = ((System.Drawing.Image)(resources.GetObject("newWordNavBtn.Image")));
            this.newWordNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newWordNavBtn.Location = new System.Drawing.Point(0, 313);
            this.newWordNavBtn.Name = "newWordNavBtn";
            this.newWordNavBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.newWordNavBtn.Size = new System.Drawing.Size(364, 64);
            this.newWordNavBtn.TabIndex = 3;
            this.newWordNavBtn.Text = "       Học từ mới";
            this.newWordNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newWordNavBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newWordNavBtn.UseVisualStyleBackColor = false;
            this.newWordNavBtn.Click += new System.EventHandler(this.newWordNavBtn_Click);
            // 
            // translateNavBtn
            // 
            this.translateNavBtn.BackColor = System.Drawing.Color.White;
            this.translateNavBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateNavBtn.Image = ((System.Drawing.Image)(resources.GetObject("translateNavBtn.Image")));
            this.translateNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.translateNavBtn.Location = new System.Drawing.Point(0, 251);
            this.translateNavBtn.Name = "translateNavBtn";
            this.translateNavBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.translateNavBtn.Size = new System.Drawing.Size(364, 64);
            this.translateNavBtn.TabIndex = 2;
            this.translateNavBtn.Text = "      Dịch tự động";
            this.translateNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.translateNavBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.translateNavBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::AzureDemo.Properties.Resources._176535_flurry_translate_google_icon__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(118, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 124);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.BackgroundImage = global::AzureDemo.Properties.Resources._2849812_menu_multimedia_bars_media_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(15, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::AzureDemo.Properties.Resources._3669408_volume_up_ic_icon;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(539, 391);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(29, 31);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::AzureDemo.Properties.Resources._211859_mic_icon;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(74, 391);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(29, 31);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(681, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cyber Ninja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AzureDemo.Properties.Resources._479476_ninja_avatar_samurai_warrior_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(911, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(681, 472);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(183, 51);
            this.button8.TabIndex = 5;
            this.button8.Text = "Dịch";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Trung (Giản thể)",
            "Nhật",
            "Pháp",
            "Đức",
            "Hàn"});
            this.comboBox1.Location = new System.Drawing.Point(739, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Chọn ngôn ngữ";
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(636, 173);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 32);
            this.button7.TabIndex = 3;
            this.button7.Text = "  Việt  ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button6.Location = new System.Drawing.Point(523, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 32);
            this.button6.TabIndex = 2;
            this.button6.Text = "  Anh  ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(523, 223);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(386, 208);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(64, 223);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(386, 208);
            this.textBox1.TabIndex = 0;
            // 
            // TranslateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TranslateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch tự động";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button translateNavBtn;
        private System.Windows.Forms.Button savedWordNavBtn;
        private System.Windows.Forms.Button quizNavBtn;
        private System.Windows.Forms.Button newWordNavBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button2;
    }
}

