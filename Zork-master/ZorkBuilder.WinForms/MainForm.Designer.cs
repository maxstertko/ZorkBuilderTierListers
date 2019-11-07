namespace ZorkBuilder.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Rooms = new System.Windows.Forms.TabPage();
            this.GameInfo = new System.Windows.Forms.TabPage();
            this.roomBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.northLabel = new System.Windows.Forms.Label();
            this.northBox = new System.Windows.Forms.TextBox();
            this.southLabel = new System.Windows.Forms.Label();
            this.southBox = new System.Windows.Forms.TextBox();
            this.eastLabel = new System.Windows.Forms.Label();
            this.eastBox = new System.Windows.Forms.TextBox();
            this.westLabel = new System.Windows.Forms.Label();
            this.westBox = new System.Windows.Forms.TextBox();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.welcomeBox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.startingRoomBox = new System.Windows.Forms.TextBox();
            this.startingRoomLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Rooms.SuspendLayout();
            this.GameInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Rooms);
            this.tabControl.Controls.Add(this.GameInfo);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(569, 411);
            this.tabControl.TabIndex = 1;
            // 
            // Rooms
            // 
            this.Rooms.Controls.Add(this.deleteRoomButton);
            this.Rooms.Controls.Add(this.addRoomButton);
            this.Rooms.Controls.Add(this.westBox);
            this.Rooms.Controls.Add(this.westLabel);
            this.Rooms.Controls.Add(this.eastBox);
            this.Rooms.Controls.Add(this.eastLabel);
            this.Rooms.Controls.Add(this.southBox);
            this.Rooms.Controls.Add(this.southLabel);
            this.Rooms.Controls.Add(this.northBox);
            this.Rooms.Controls.Add(this.northLabel);
            this.Rooms.Controls.Add(this.descriptionBox);
            this.Rooms.Controls.Add(this.descriptionLabel);
            this.Rooms.Controls.Add(this.nameBox);
            this.Rooms.Controls.Add(this.nameLabel);
            this.Rooms.Controls.Add(this.roomBox);
            this.Rooms.Location = new System.Drawing.Point(4, 22);
            this.Rooms.Name = "Rooms";
            this.Rooms.Padding = new System.Windows.Forms.Padding(3);
            this.Rooms.Size = new System.Drawing.Size(561, 385);
            this.Rooms.TabIndex = 0;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = true;
            // 
            // GameInfo
            // 
            this.GameInfo.Controls.Add(this.startingRoomBox);
            this.GameInfo.Controls.Add(this.startingRoomLabel);
            this.GameInfo.Controls.Add(this.welcomeBox);
            this.GameInfo.Controls.Add(this.welcomeLabel);
            this.GameInfo.Location = new System.Drawing.Point(4, 22);
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Padding = new System.Windows.Forms.Padding(3);
            this.GameInfo.Size = new System.Drawing.Size(561, 385);
            this.GameInfo.TabIndex = 1;
            this.GameInfo.Text = "Game Info";
            this.GameInfo.UseVisualStyleBackColor = true;
            // 
            // roomBox
            // 
            this.roomBox.FormattingEnabled = true;
            this.roomBox.Location = new System.Drawing.Point(7, 7);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(160, 342);
            this.roomBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(191, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(194, 30);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(201, 20);
            this.nameBox.TabIndex = 2;
            this.nameBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(191, 64);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(194, 81);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(316, 90);
            this.descriptionBox.TabIndex = 2;
            this.descriptionBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // northLabel
            // 
            this.northLabel.AutoSize = true;
            this.northLabel.Location = new System.Drawing.Point(191, 184);
            this.northLabel.Name = "northLabel";
            this.northLabel.Size = new System.Drawing.Size(33, 13);
            this.northLabel.TabIndex = 1;
            this.northLabel.Text = "North";
            // 
            // northBox
            // 
            this.northBox.Location = new System.Drawing.Point(194, 201);
            this.northBox.Name = "northBox";
            this.northBox.Size = new System.Drawing.Size(201, 20);
            this.northBox.TabIndex = 2;
            this.northBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // southLabel
            // 
            this.southLabel.AutoSize = true;
            this.southLabel.Location = new System.Drawing.Point(191, 224);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(35, 13);
            this.southLabel.TabIndex = 1;
            this.southLabel.Text = "South";
            // 
            // southBox
            // 
            this.southBox.Location = new System.Drawing.Point(194, 241);
            this.southBox.Name = "southBox";
            this.southBox.Size = new System.Drawing.Size(201, 20);
            this.southBox.TabIndex = 2;
            this.southBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // eastLabel
            // 
            this.eastLabel.AutoSize = true;
            this.eastLabel.Location = new System.Drawing.Point(191, 264);
            this.eastLabel.Name = "eastLabel";
            this.eastLabel.Size = new System.Drawing.Size(28, 13);
            this.eastLabel.TabIndex = 1;
            this.eastLabel.Text = "East";
            // 
            // eastBox
            // 
            this.eastBox.Location = new System.Drawing.Point(194, 281);
            this.eastBox.Name = "eastBox";
            this.eastBox.Size = new System.Drawing.Size(201, 20);
            this.eastBox.TabIndex = 2;
            this.eastBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // westLabel
            // 
            this.westLabel.AutoSize = true;
            this.westLabel.Location = new System.Drawing.Point(191, 304);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(32, 13);
            this.westLabel.TabIndex = 1;
            this.westLabel.Text = "West";
            // 
            // westBox
            // 
            this.westBox.Location = new System.Drawing.Point(194, 321);
            this.westBox.Name = "westBox";
            this.westBox.Size = new System.Drawing.Size(201, 20);
            this.westBox.TabIndex = 2;
            this.westBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(7, 356);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 3;
            this.addRoomButton.Text = "&Add...";
            this.addRoomButton.UseVisualStyleBackColor = true;
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(92, 355);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomButton.TabIndex = 4;
            this.deleteRoomButton.Text = "Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            // 
            // welcomeBox
            // 
            this.welcomeBox.Location = new System.Drawing.Point(20, 29);
            this.welcomeBox.Multiline = true;
            this.welcomeBox.Name = "welcomeBox";
            this.welcomeBox.Size = new System.Drawing.Size(316, 90);
            this.welcomeBox.TabIndex = 4;
            this.welcomeBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(17, 12);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(98, 13);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome Message";
            // 
            // startingRoomBox
            // 
            this.startingRoomBox.Location = new System.Drawing.Point(20, 167);
            this.startingRoomBox.Name = "startingRoomBox";
            this.startingRoomBox.Size = new System.Drawing.Size(316, 20);
            this.startingRoomBox.TabIndex = 6;
            // 
            // startingRoomLabel
            // 
            this.startingRoomLabel.AutoSize = true;
            this.startingRoomLabel.Location = new System.Drawing.Point(17, 150);
            this.startingRoomLabel.Name = "startingRoomLabel";
            this.startingRoomLabel.Size = new System.Drawing.Size(74, 13);
            this.startingRoomLabel.TabIndex = 5;
            this.startingRoomLabel.Text = "Starting Room";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.Rooms.ResumeLayout(false);
            this.Rooms.PerformLayout();
            this.GameInfo.ResumeLayout(false);
            this.GameInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Rooms;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox roomBox;
        private System.Windows.Forms.TabPage GameInfo;
        private System.Windows.Forms.TextBox westBox;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.TextBox eastBox;
        private System.Windows.Forms.Label eastLabel;
        private System.Windows.Forms.TextBox southBox;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.TextBox northBox;
        private System.Windows.Forms.Label northLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.TextBox startingRoomBox;
        private System.Windows.Forms.Label startingRoomLabel;
        private System.Windows.Forms.TextBox welcomeBox;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

