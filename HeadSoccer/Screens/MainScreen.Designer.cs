namespace HeadSoccer.Screens
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.statButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(15, 202);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(270, 94);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(15, 402);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(270, 94);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // statButton
            // 
            this.statButton.Location = new System.Drawing.Point(15, 302);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(270, 94);
            this.statButton.TabIndex = 2;
            this.statButton.Text = "Statistics";
            this.statButton.UseVisualStyleBackColor = true;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1106, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button statButton;
    }
}
