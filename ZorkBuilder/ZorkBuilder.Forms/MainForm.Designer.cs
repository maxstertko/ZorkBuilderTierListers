namespace ZorkBuilder.Forms
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameControl = new System.Windows.Forms.TabControl();
            this.roomsTab = new System.Windows.Forms.TabPage();
            this.westBox = new System.Windows.Forms.TextBox();
            this.westLabel = new System.Windows.Forms.Label();
            this.eastBox = new System.Windows.Forms.TextBox();
            this.East = new System.Windows.Forms.Label();
            this.southBox = new System.Windows.Forms.TextBox();
            this.southLabel = new System.Windows.Forms.Label();
            this.northBox = new System.Windows.Forms.TextBox();
            this.northLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.worldInfoTab = new System.Windows.Forms.TabPage();
            this.welcomeBox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.startRoomBox = new System.Windows.Forms.TextBox();
            this.startRoomLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.createNewDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.gameControl.SuspendLayout();
            this.roomsTab.SuspendLayout();
            this.worldInfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(763, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.openGameToolStripMenuItem,
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
            // openGameToolStripMenuItem
            // 
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openGameToolStripMenuItem.Text = "&Open Game";
            this.openGameToolStripMenuItem.Click += new System.EventHandler(this.OpenGameToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // gameControl
            // 
            this.gameControl.Controls.Add(this.roomsTab);
            this.gameControl.Controls.Add(this.worldInfoTab);
            this.gameControl.Location = new System.Drawing.Point(13, 28);
            this.gameControl.Name = "gameControl";
            this.gameControl.SelectedIndex = 0;
            this.gameControl.Size = new System.Drawing.Size(736, 410);
            this.gameControl.TabIndex = 1;
            // 
            // roomsTab
            // 
            this.roomsTab.Controls.Add(this.westBox);
            this.roomsTab.Controls.Add(this.westLabel);
            this.roomsTab.Controls.Add(this.eastBox);
            this.roomsTab.Controls.Add(this.East);
            this.roomsTab.Controls.Add(this.southBox);
            this.roomsTab.Controls.Add(this.southLabel);
            this.roomsTab.Controls.Add(this.northBox);
            this.roomsTab.Controls.Add(this.northLabel);
            this.roomsTab.Controls.Add(this.descriptionBox);
            this.roomsTab.Controls.Add(this.descriptionLabel);
            this.roomsTab.Controls.Add(this.nameBox);
            this.roomsTab.Controls.Add(this.nameLabel);
            this.roomsTab.Controls.Add(this.deleteButton);
            this.roomsTab.Controls.Add(this.addButton);
            this.roomsTab.Controls.Add(this.roomsListBox);
            this.roomsTab.Location = new System.Drawing.Point(4, 22);
            this.roomsTab.Name = "roomsTab";
            this.roomsTab.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTab.Size = new System.Drawing.Size(728, 384);
            this.roomsTab.TabIndex = 0;
            this.roomsTab.Text = "Rooms";
            this.roomsTab.UseVisualStyleBackColor = true;
            // 
            // westBox
            // 
            this.westBox.Location = new System.Drawing.Point(227, 351);
            this.westBox.Name = "westBox";
            this.westBox.Size = new System.Drawing.Size(207, 20);
            this.westBox.TabIndex = 13;
            // 
            // westLabel
            // 
            this.westLabel.AutoSize = true;
            this.westLabel.Location = new System.Drawing.Point(227, 335);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(35, 13);
            this.westLabel.TabIndex = 12;
            this.westLabel.Text = "West:";
            // 
            // eastBox
            // 
            this.eastBox.Location = new System.Drawing.Point(227, 304);
            this.eastBox.Name = "eastBox";
            this.eastBox.Size = new System.Drawing.Size(207, 20);
            this.eastBox.TabIndex = 11;
            // 
            // East
            // 
            this.East.AutoSize = true;
            this.East.Location = new System.Drawing.Point(227, 288);
            this.East.Name = "East";
            this.East.Size = new System.Drawing.Size(31, 13);
            this.East.TabIndex = 10;
            this.East.Text = "East:";
            // 
            // southBox
            // 
            this.southBox.Location = new System.Drawing.Point(227, 251);
            this.southBox.Name = "southBox";
            this.southBox.Size = new System.Drawing.Size(207, 20);
            this.southBox.TabIndex = 9;
            // 
            // southLabel
            // 
            this.southLabel.AutoSize = true;
            this.southLabel.Location = new System.Drawing.Point(227, 235);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(38, 13);
            this.southLabel.TabIndex = 8;
            this.southLabel.Text = "South:";
            // 
            // northBox
            // 
            this.northBox.Location = new System.Drawing.Point(227, 202);
            this.northBox.Name = "northBox";
            this.northBox.Size = new System.Drawing.Size(207, 20);
            this.northBox.TabIndex = 7;
            // 
            // northLabel
            // 
            this.northLabel.AutoSize = true;
            this.northLabel.Location = new System.Drawing.Point(227, 186);
            this.northLabel.Name = "northLabel";
            this.northLabel.Size = new System.Drawing.Size(36, 13);
            this.northLabel.TabIndex = 6;
            this.northLabel.Text = "North:";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(227, 73);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(429, 99);
            this.descriptionBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(227, 57);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(227, 19);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(207, 20);
            this.nameBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(227, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(101, 348);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 348);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "&Add...";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // roomsListBox
            // 
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(0, 0);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(221, 342);
            this.roomsListBox.TabIndex = 0;
            // 
            // worldInfoTab
            // 
            this.worldInfoTab.Controls.Add(this.welcomeBox);
            this.worldInfoTab.Controls.Add(this.welcomeLabel);
            this.worldInfoTab.Controls.Add(this.startRoomBox);
            this.worldInfoTab.Controls.Add(this.startRoomLabel);
            this.worldInfoTab.Location = new System.Drawing.Point(4, 22);
            this.worldInfoTab.Name = "worldInfoTab";
            this.worldInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.worldInfoTab.Size = new System.Drawing.Size(728, 384);
            this.worldInfoTab.TabIndex = 1;
            this.worldInfoTab.Text = "World Info";
            this.worldInfoTab.UseVisualStyleBackColor = true;
            // 
            // welcomeBox
            // 
            this.welcomeBox.Location = new System.Drawing.Point(30, 89);
            this.welcomeBox.Multiline = true;
            this.welcomeBox.Name = "welcomeBox";
            this.welcomeBox.Size = new System.Drawing.Size(429, 83);
            this.welcomeBox.TabIndex = 7;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(30, 73);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(101, 13);
            this.welcomeLabel.TabIndex = 6;
            this.welcomeLabel.Text = "Welcome Message:";
            // 
            // startRoomBox
            // 
            this.startRoomBox.Location = new System.Drawing.Point(30, 33);
            this.startRoomBox.Name = "startRoomBox";
            this.startRoomBox.Size = new System.Drawing.Size(207, 20);
            this.startRoomBox.TabIndex = 5;
            // 
            // startRoomLabel
            // 
            this.startRoomLabel.AutoSize = true;
            this.startRoomLabel.Location = new System.Drawing.Point(30, 17);
            this.startRoomLabel.Name = "startRoomLabel";
            this.startRoomLabel.Size = new System.Drawing.Size(77, 13);
            this.startRoomLabel.TabIndex = 4;
            this.startRoomLabel.Text = "Starting Room:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.gameControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Zork Builder 5.0";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gameControl.ResumeLayout(false);
            this.roomsTab.ResumeLayout(false);
            this.roomsTab.PerformLayout();
            this.worldInfoTab.ResumeLayout(false);
            this.worldInfoTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl gameControl;
        private System.Windows.Forms.TabPage roomsTab;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.TabPage worldInfoTab;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox westBox;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.TextBox eastBox;
        private System.Windows.Forms.Label East;
        private System.Windows.Forms.TextBox southBox;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.TextBox northBox;
        private System.Windows.Forms.Label northLabel;
        private System.Windows.Forms.TextBox welcomeBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox startRoomBox;
        private System.Windows.Forms.Label startRoomLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SaveFileDialog createNewDialog;
    }
}

