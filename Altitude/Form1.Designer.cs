namespace Altitude
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whyTheFuckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aAtoll = new System.Windows.Forms.Button();
            this.aSummit = new System.Windows.Forms.Button();
            this.aMeadow = new System.Windows.Forms.Button();
            this.aValley = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.aVoteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aVote1 = new System.Windows.Forms.CheckBox();
            this.aVote6 = new System.Windows.Forms.CheckBox();
            this.aVote5 = new System.Windows.Forms.CheckBox();
            this.aVote2 = new System.Windows.Forms.CheckBox();
            this.aVote4 = new System.Windows.Forms.CheckBox();
            this.aVote3 = new System.Windows.Forms.CheckBox();
            this.aFuckingUselessIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.aSaveDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(578, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_2);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem,
            this.whyTheFuckToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.informationToolStripMenuItem.Text = "Info";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.InformationToolStripMenuItem_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.buildToolStripMenuItem.Text = "Build";
            this.buildToolStripMenuItem.Click += new System.EventHandler(this.BuildToolStripMenuItem_Click);
            // 
            // whyTheFuckToolStripMenuItem
            // 
            this.whyTheFuckToolStripMenuItem.Name = "whyTheFuckToolStripMenuItem";
            this.whyTheFuckToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.whyTheFuckToolStripMenuItem.Text = "why the fuck";
            this.whyTheFuckToolStripMenuItem.Click += new System.EventHandler(this.WhyTheFuckToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // aAtoll
            // 
            this.aAtoll.Location = new System.Drawing.Point(16, 280);
            this.aAtoll.Name = "aAtoll";
            this.aAtoll.Size = new System.Drawing.Size(73, 23);
            this.aAtoll.TabIndex = 2;
            this.aAtoll.Text = "Atoll";
            this.aAtoll.UseVisualStyleBackColor = true;
            this.aAtoll.Click += new System.EventHandler(this.Button1_Click);
            // 
            // aSummit
            // 
            this.aSummit.Location = new System.Drawing.Point(246, 280);
            this.aSummit.Name = "aSummit";
            this.aSummit.Size = new System.Drawing.Size(73, 23);
            this.aSummit.TabIndex = 3;
            this.aSummit.Text = "Summit";
            this.aSummit.UseVisualStyleBackColor = true;
            this.aSummit.Click += new System.EventHandler(this.ASummit_Click);
            // 
            // aMeadow
            // 
            this.aMeadow.Location = new System.Drawing.Point(129, 280);
            this.aMeadow.Name = "aMeadow";
            this.aMeadow.Size = new System.Drawing.Size(73, 23);
            this.aMeadow.TabIndex = 4;
            this.aMeadow.Text = "Meadow";
            this.aMeadow.UseVisualStyleBackColor = true;
            this.aMeadow.Click += new System.EventHandler(this.AMeadow_Click);
            // 
            // aValley
            // 
            this.aValley.Location = new System.Drawing.Point(361, 280);
            this.aValley.Name = "aValley";
            this.aValley.Size = new System.Drawing.Size(73, 23);
            this.aValley.TabIndex = 5;
            this.aValley.Text = "Valley";
            this.aValley.UseVisualStyleBackColor = true;
            this.aValley.Click += new System.EventHandler(this.AValley_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wozcott", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "DYNMAPS\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label1, "Opens DYNMAP\'s for the Altitude servers. Click one of the \r\nbuttons below to get " +
        "to each. ");
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // aVoteButton
            // 
            this.aVoteButton.Location = new System.Drawing.Point(971, 357);
            this.aVoteButton.Name = "aVoteButton";
            this.aVoteButton.Size = new System.Drawing.Size(75, 23);
            this.aVoteButton.TabIndex = 13;
            this.aVoteButton.Text = "Vote Links";
            this.toolTip1.SetToolTip(this.aVoteButton, "Check a checkbox, and you\'ll go to that website");
            this.aVoteButton.UseVisualStyleBackColor = true;
            this.aVoteButton.Click += new System.EventHandler(this.AVoteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wozcott", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(952, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vote Links";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label2, "Opens DYNMAP\'s for the Altitude servers. Click one of the \r\nbuttons below to get " +
        "to each. ");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wozcott", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 21;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label3, "Opens DYNMAP\'s for the Altitude servers. Click one of the \r\nbuttons below to get " +
        "to each. ");
            // 
            // aVote1
            // 
            this.aVote1.AutoSize = true;
            this.aVote1.Checked = true;
            this.aVote1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aVote1.Location = new System.Drawing.Point(905, 288);
            this.aVote1.Name = "aVote1";
            this.aVote1.Size = new System.Drawing.Size(109, 17);
            this.aVote1.TabIndex = 7;
            this.aVote1.Text = "Minecraft Servers";
            this.aVote1.UseVisualStyleBackColor = true;
            this.aVote1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // aVote6
            // 
            this.aVote6.AutoSize = true;
            this.aVote6.Checked = true;
            this.aVote6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aVote6.Location = new System.Drawing.Point(1014, 334);
            this.aVote6.Name = "aVote6";
            this.aVote6.Size = new System.Drawing.Size(89, 17);
            this.aVote6.TabIndex = 8;
            this.aVote6.Text = "Minecraft-MP";
            this.aVote6.UseVisualStyleBackColor = true;
            this.aVote6.CheckedChanged += new System.EventHandler(this.AVote6_CheckedChanged);
            // 
            // aVote5
            // 
            this.aVote5.AutoSize = true;
            this.aVote5.Checked = true;
            this.aVote5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aVote5.Location = new System.Drawing.Point(905, 334);
            this.aVote5.Name = "aVote5";
            this.aVote5.Size = new System.Drawing.Size(103, 17);
            this.aVote5.TabIndex = 9;
            this.aVote5.Text = "Planet Minecraft";
            this.aVote5.UseVisualStyleBackColor = true;
            // 
            // aVote2
            // 
            this.aVote2.AutoSize = true;
            this.aVote2.Checked = true;
            this.aVote2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aVote2.Location = new System.Drawing.Point(1014, 288);
            this.aVote2.Name = "aVote2";
            this.aVote2.Size = new System.Drawing.Size(131, 17);
            this.aVote2.TabIndex = 10;
            this.aVote2.Text = "Top Minecraft Servers";
            this.aVote2.UseVisualStyleBackColor = true;
            this.aVote2.CheckedChanged += new System.EventHandler(this.AVote2_CheckedChanged);
            // 
            // aVote4
            // 
            this.aVote4.AutoSize = true;
            this.aVote4.Checked = true;
            this.aVote4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aVote4.Location = new System.Drawing.Point(1014, 311);
            this.aVote4.Name = "aVote4";
            this.aVote4.Size = new System.Drawing.Size(104, 17);
            this.aVote4.TabIndex = 11;
            this.aVote4.Text = "Minecraft-Server";
            this.aVote4.UseVisualStyleBackColor = true;
            // 
            // aVote3
            // 
            this.aVote3.AutoSize = true;
            this.aVote3.Checked = true;
            this.aVote3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aVote3.Location = new System.Drawing.Point(905, 311);
            this.aVote3.Name = "aVote3";
            this.aVote3.Size = new System.Drawing.Size(55, 17);
            this.aVote3.TabIndex = 12;
            this.aVote3.Text = "MCSL";
            this.aVote3.UseVisualStyleBackColor = true;
            this.aVote3.CheckedChanged += new System.EventHandler(this.AVote3_CheckedChanged);
            // 
            // aFuckingUselessIcon
            // 
            this.aFuckingUselessIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.aFuckingUselessIcon.BalloonTipText = "This is just to fucking annoy you";
            this.aFuckingUselessIcon.BalloonTipTitle = "This is just to fucking annoy you";
            this.aFuckingUselessIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("aFuckingUselessIcon.Icon")));
            this.aFuckingUselessIcon.Text = "This is just to fucking annoy you";
            this.aFuckingUselessIcon.Visible = true;
            this.aFuckingUselessIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.aFuckingUselessIcon_MouseDoubleClick);
            // 
            // aSaveDialog
            // 
            this.aSaveDialog.CreatePrompt = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1250, 789);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aVoteButton);
            this.Controls.Add(this.aVote3);
            this.Controls.Add(this.aVote4);
            this.Controls.Add(this.aVote2);
            this.Controls.Add(this.aVote5);
            this.Controls.Add(this.aVote6);
            this.Controls.Add(this.aVote1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aValley);
            this.Controls.Add(this.aMeadow);
            this.Controls.Add(this.aSummit);
            this.Controls.Add(this.aAtoll);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Altitude ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whyTheFuckToolStripMenuItem;
        public System.Windows.Forms.Button aSummit;
        public System.Windows.Forms.Button aMeadow;
        public System.Windows.Forms.Button aValley;
        public System.Windows.Forms.Button aAtoll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox aVote1;
        private System.Windows.Forms.CheckBox aVote6;
        private System.Windows.Forms.CheckBox aVote5;
        private System.Windows.Forms.CheckBox aVote2;
        private System.Windows.Forms.CheckBox aVote4;
        private System.Windows.Forms.CheckBox aVote3;
        private System.Windows.Forms.Button aVoteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon aFuckingUselessIcon;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog aSaveDialog;
    }
}

