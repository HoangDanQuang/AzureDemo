namespace AzureDemo
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btSignout = new System.Windows.Forms.Button();
            this.savedWordNavBtn = new System.Windows.Forms.Button();
            this.quizNavBtn = new System.Windows.Forms.Button();
            this.newWordNavBtn = new System.Windows.Forms.Button();
            this.translateNavBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMenu = new System.Windows.Forms.Button();
            this.startQuizBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.btSignout);
            this.splitContainer1.Panel1.Controls.Add(this.savedWordNavBtn);
            this.splitContainer1.Panel1.Controls.Add(this.quizNavBtn);
            this.splitContainer1.Panel1.Controls.Add(this.newWordNavBtn);
            this.splitContainer1.Panel1.Controls.Add(this.translateNavBtn);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.startQuizBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1348, 721);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 2;
            // 
            // btSignout
            // 
            this.btSignout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignout.Image = global::AzureDemo.Properties.Resources.fb_ic_arrow_back;
            this.btSignout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSignout.Location = new System.Drawing.Point(0, 502);
            this.btSignout.Name = "btSignout";
            this.btSignout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btSignout.Size = new System.Drawing.Size(364, 64);
            this.btSignout.TabIndex = 7;
            this.btSignout.Text = "       Đăng xuất";
            this.btSignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSignout.UseVisualStyleBackColor = false;
            this.btSignout.Click += new System.EventHandler(this.logoutNavBtn_Click);
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
            this.quizNavBtn.BackColor = System.Drawing.Color.White;
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
            this.translateNavBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.translateNavBtn.Click += new System.EventHandler(this.translateNavBtn_Click);
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
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btMenu.BackgroundImage = global::AzureDemo.Properties.Resources._2849812_menu_multimedia_bars_media_icon;
            this.btMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btMenu.FlatAppearance.BorderSize = 0;
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btMenu.Location = new System.Drawing.Point(15, 9);
            this.btMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(42, 39);
            this.btMenu.TabIndex = 0;
            this.btMenu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btMenu.UseVisualStyleBackColor = false;
            // 
            // startQuizBtn
            // 
            this.startQuizBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.startQuizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startQuizBtn.Location = new System.Drawing.Point(372, 336);
            this.startQuizBtn.Name = "startQuizBtn";
            this.startQuizBtn.Size = new System.Drawing.Size(239, 67);
            this.startQuizBtn.TabIndex = 10;
            this.startQuizBtn.Text = "Bắt đầu";
            this.startQuizBtn.UseVisualStyleBackColor = false;
            this.startQuizBtn.Click += new System.EventHandler(this.startQuizBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(971, 53);
            this.label3.TabIndex = 9;
            this.label3.Text = "50 câu hỏi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(971, 53);
            this.label2.TabIndex = 8;
            this.label2.Text = "Câu hỏi trắc nghiệm ôn tập";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Câu hỏi ôn tập";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button savedWordNavBtn;
        private System.Windows.Forms.Button quizNavBtn;
        private System.Windows.Forms.Button newWordNavBtn;
        private System.Windows.Forms.Button translateNavBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button startQuizBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btSignout;
    }
}