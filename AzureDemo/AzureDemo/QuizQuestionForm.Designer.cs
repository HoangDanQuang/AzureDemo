namespace AzureDemo
{
    partial class QuizQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizQuestionForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.savedWordNavBtn = new System.Windows.Forms.Button();
            this.quizNavBtn = new System.Windows.Forms.Button();
            this.newWordNavBtn = new System.Windows.Forms.Button();
            this.translateNavBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btOp4 = new System.Windows.Forms.Button();
            this.btOp2 = new System.Windows.Forms.Button();
            this.btOp3 = new System.Windows.Forms.Button();
            this.btOp1 = new System.Windows.Forms.Button();
            this.lbQues = new System.Windows.Forms.Label();
            this.lbDisplayname = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel2.Controls.Add(this.button11);
            this.splitContainer1.Panel2.Controls.Add(this.button10);
            this.splitContainer1.Panel2.Controls.Add(this.btOp4);
            this.splitContainer1.Panel2.Controls.Add(this.btOp2);
            this.splitContainer1.Panel2.Controls.Add(this.btOp3);
            this.splitContainer1.Panel2.Controls.Add(this.btOp1);
            this.splitContainer1.Panel2.Controls.Add(this.lbQues);
            this.splitContainer1.Panel2.Controls.Add(this.lbDisplayname);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1348, 721);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 3;
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
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(735, 556);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(146, 44);
            this.button11.TabIndex = 14;
            this.button11.Text = "Kết thúc";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(523, 556);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(146, 44);
            this.button10.TabIndex = 13;
            this.button10.Text = "Tiếp theo";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btOp4
            // 
            this.btOp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOp4.Location = new System.Drawing.Point(523, 414);
            this.btOp4.Name = "btOp4";
            this.btOp4.Size = new System.Drawing.Size(358, 99);
            this.btOp4.TabIndex = 12;
            this.btOp4.Text = "D. Answer answer answer answer answer answer answer ";
            this.btOp4.UseVisualStyleBackColor = true;
            this.btOp4.Click += new System.EventHandler(this.btOp4_Click);
            // 
            // btOp2
            // 
            this.btOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOp2.Location = new System.Drawing.Point(523, 253);
            this.btOp2.Name = "btOp2";
            this.btOp2.Size = new System.Drawing.Size(358, 99);
            this.btOp2.TabIndex = 11;
            this.btOp2.Text = "B. Answer answer answer answer answer answer answer ";
            this.btOp2.UseVisualStyleBackColor = true;
            this.btOp2.Click += new System.EventHandler(this.btOp2_Click);
            // 
            // btOp3
            // 
            this.btOp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOp3.ForeColor = System.Drawing.Color.Black;
            this.btOp3.Location = new System.Drawing.Point(94, 414);
            this.btOp3.Name = "btOp3";
            this.btOp3.Size = new System.Drawing.Size(358, 99);
            this.btOp3.TabIndex = 10;
            this.btOp3.Text = "C. Answer answer answer answer answer answer answer ";
            this.btOp3.UseVisualStyleBackColor = true;
            this.btOp3.Click += new System.EventHandler(this.btOp3_Click);
            // 
            // btOp1
            // 
            this.btOp1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btOp1.Location = new System.Drawing.Point(94, 253);
            this.btOp1.Name = "btOp1";
            this.btOp1.Size = new System.Drawing.Size(358, 99);
            this.btOp1.TabIndex = 9;
            this.btOp1.Text = "A. Answer answer answer answer answer answer answer ";
            this.btOp1.UseVisualStyleBackColor = false;
            this.btOp1.Click += new System.EventHandler(this.btOp1_Click);
            // 
            // lbQues
            // 
            this.lbQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQues.Location = new System.Drawing.Point(89, 128);
            this.lbQues.Name = "lbQues";
            this.lbQues.Size = new System.Drawing.Size(792, 89);
            this.lbQues.TabIndex = 8;
            this.lbQues.Text = "1. Question question question question question question question question questi" +
    "on question question question?";
            this.lbQues.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDisplayname
            // 
            this.lbDisplayname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayname.Location = new System.Drawing.Point(681, 18);
            this.lbDisplayname.Name = "lbDisplayname";
            this.lbDisplayname.Size = new System.Drawing.Size(207, 30);
            this.lbDisplayname.TabIndex = 7;
            this.lbDisplayname.Text = "Cyber Ninja";
            this.lbDisplayname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // QuizQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuizQuestionForm";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btOp3;
        private System.Windows.Forms.Button btOp1;
        private System.Windows.Forms.Label lbQues;
        private System.Windows.Forms.Label lbDisplayname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btOp4;
        private System.Windows.Forms.Button btOp2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
    }
}