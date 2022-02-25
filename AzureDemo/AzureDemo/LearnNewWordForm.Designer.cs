namespace AzureDemo
{
    partial class LearnNewWordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnNewWordForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("item 1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("item 2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("item 3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("item 4");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("item 5");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("item 6");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("item 7");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Item 8");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Item 9");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Item 10");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.savedWordNavBtn = new System.Windows.Forms.Button();
            this.quizNavBtn = new System.Windows.Forms.Button();
            this.newWordNavBtn = new System.Windows.Forms.Button();
            this.translateNavBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
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
            this.quizNavBtn.Text = "       Trắc nhiệm vui";
            this.quizNavBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quizNavBtn.UseVisualStyleBackColor = false;
            this.quizNavBtn.Click += new System.EventHandler(this.quizNavBtn_Click);
            // 
            // newWordNavBtn
            // 
            this.newWordNavBtn.BackColor = System.Drawing.Color.White;
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
            this.translateNavBtn.Click += new System.EventHandler(this.TranslateNavBtn_Click);
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::AzureDemo.Properties.Resources.fb_ic_arrow_back;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(9, 8);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(60, 50);
            this.button3.TabIndex = 7;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(528, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 385);
            this.panel1.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(78, 332);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 41);
            this.button8.TabIndex = 14;
            this.button8.Text = "Thêm";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 70);
            this.label3.TabIndex = 2;
            this.label3.Text = "Meaning Meaning Meaning Meaning Meaning Meaning";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::AzureDemo.Properties.Resources.word_image_346;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(314, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView1.Location = new System.Drawing.Point(115, 168);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(366, 385);
            this.listView1.TabIndex = 10;
            this.listView1.TileSize = new System.Drawing.Size(200, 40);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // LearnNewWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LearnNewWordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch tự động";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
    }
}

