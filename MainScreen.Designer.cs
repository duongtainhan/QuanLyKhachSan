namespace QuanLyKhachSan
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.panelTitleTop = new System.Windows.Forms.Panel();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxSizeWindow = new System.Windows.Forms.PictureBox();
            this.pictureBoxShutdown = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.buttonDashBoard = new System.Windows.Forms.Button();
            this.panelMenuVertical.SuspendLayout();
            this.panelTitleTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShutdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelMenuVertical.Controls.Add(this.buttonDashBoard);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(250, 800);
            this.panelMenuVertical.TabIndex = 0;
            // 
            // panelTitleTop
            // 
            this.panelTitleTop.Controls.Add(this.pictureBoxMinimize);
            this.panelTitleTop.Controls.Add(this.pictureBoxSizeWindow);
            this.panelTitleTop.Controls.Add(this.pictureBoxShutdown);
            this.panelTitleTop.Controls.Add(this.pictureBoxMenu);
            this.panelTitleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleTop.Location = new System.Drawing.Point(250, 0);
            this.panelTitleTop.Name = "panelTitleTop";
            this.panelTitleTop.Size = new System.Drawing.Size(1150, 59);
            this.panelTitleTop.TabIndex = 1;
            this.panelTitleTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleTop_MouseDown);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimize.Image")));
            this.pictureBoxMinimize.Location = new System.Drawing.Point(963, 12);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(43, 41);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimize.TabIndex = 4;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // pictureBoxSizeWindow
            // 
            this.pictureBoxSizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSizeWindow.Image")));
            this.pictureBoxSizeWindow.Location = new System.Drawing.Point(1031, 12);
            this.pictureBoxSizeWindow.Name = "pictureBoxSizeWindow";
            this.pictureBoxSizeWindow.Size = new System.Drawing.Size(43, 41);
            this.pictureBoxSizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSizeWindow.TabIndex = 2;
            this.pictureBoxSizeWindow.TabStop = false;
            this.pictureBoxSizeWindow.Click += new System.EventHandler(this.pictureBoxSizeWindow_Click);
            // 
            // pictureBoxShutdown
            // 
            this.pictureBoxShutdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxShutdown.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShutdown.Image")));
            this.pictureBoxShutdown.Location = new System.Drawing.Point(1095, 12);
            this.pictureBoxShutdown.Name = "pictureBoxShutdown";
            this.pictureBoxShutdown.Size = new System.Drawing.Size(43, 41);
            this.pictureBoxShutdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShutdown.TabIndex = 1;
            this.pictureBoxShutdown.TabStop = false;
            this.pictureBoxShutdown.Click += new System.EventHandler(this.pictureBoxShutdown_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(6, 12);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(42, 41);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenu.TabIndex = 0;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBoxMenu_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 59);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1150, 741);
            this.panelContainer.TabIndex = 2;
            // 
            // buttonDashBoard
            // 
            this.buttonDashBoard.FlatAppearance.BorderSize = 0;
            this.buttonDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashBoard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashBoard.Image")));
            this.buttonDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashBoard.Location = new System.Drawing.Point(0, 94);
            this.buttonDashBoard.Name = "buttonDashBoard";
            this.buttonDashBoard.Size = new System.Drawing.Size(250, 49);
            this.buttonDashBoard.TabIndex = 0;
            this.buttonDashBoard.Text = "DashBoard";
            this.buttonDashBoard.UseVisualStyleBackColor = true;
            this.buttonDashBoard.Click += new System.EventHandler(this.buttonDashBoard_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleTop);
            this.Controls.Add(this.panelMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.panelMenuVertical.ResumeLayout(false);
            this.panelTitleTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShutdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Panel panelTitleTop;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxSizeWindow;
        private System.Windows.Forms.PictureBox pictureBoxShutdown;
        private System.Windows.Forms.Button buttonDashBoard;
    }
}

