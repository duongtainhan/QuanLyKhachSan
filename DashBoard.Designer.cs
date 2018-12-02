namespace QuanLyKhachSan
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.buttonDashBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDashBoard
            // 
            this.buttonDashBoard.FlatAppearance.BorderSize = 0;
            this.buttonDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashBoard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashBoard.Image")));
            this.buttonDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashBoard.Location = new System.Drawing.Point(379, 247);
            this.buttonDashBoard.Name = "buttonDashBoard";
            this.buttonDashBoard.Size = new System.Drawing.Size(250, 49);
            this.buttonDashBoard.TabIndex = 1;
            this.buttonDashBoard.Text = "DashBoard";
            this.buttonDashBoard.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 841);
            this.Controls.Add(this.buttonDashBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDashBoard;
    }
}