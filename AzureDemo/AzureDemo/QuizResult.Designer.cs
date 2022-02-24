
namespace AzureDemo
{
    partial class QuizResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizResult));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.savedWordNavBtn = new System.Windows.Forms.Button();
            this.quizNavBtn = new System.Windows.Forms.Button();
            this.newWordNavBtn = new System.Windows.Forms.Button();
            this.translateNavBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.lbQues = new System.Windows.Forms.Label();
            this.lbDisplayName = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.button11);
            this.splitContainer1.Panel2.Controls.Add(this.lbQues);
            this.splitContainer1.Panel2.Controls.Add(this.lbDisplayName);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1348, 721);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 4;
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(792, 64);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số câu đúng:  0/0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(735, 556);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(146, 44);
            this.button11.TabIndex = 14;
            this.button11.Text = "Làm lại";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // lbQues
            // 
            this.lbQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQues.Location = new System.Drawing.Point(96, 203);
            this.lbQues.Name = "lbQues";
            this.lbQues.Size = new System.Drawing.Size(792, 89);
            this.lbQues.TabIndex = 8;
            this.lbQues.Text = "KẾT QUẢ";
            this.lbQues.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbQues.Click += new System.EventHandler(this.lbQues_Click);
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayName.Location = new System.Drawing.Point(681, 18);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(207, 30);
            this.lbDisplayName.TabIndex = 7;
            this.lbDisplayName.Text = "Cyber Ninja";
            this.lbDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // QuizResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.splitContainer1);
            this.Name = "QuizResult";
            this.Text = "QuizResult";
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
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label lbQues;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}