namespace HeadSoccer.Screens
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.goalBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.goalBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // goalBox
            // 
            this.goalBox.BackColor = System.Drawing.Color.Transparent;
            this.goalBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.goalBox.Image = global::HeadSoccer.Properties.Resources.Goal;
            this.goalBox.Location = new System.Drawing.Point(246, 28);
            this.goalBox.Name = "goalBox";
            this.goalBox.Size = new System.Drawing.Size(602, 279);
            this.goalBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goalBox.TabIndex = 0;
            this.goalBox.TabStop = false;
            this.goalBox.Visible = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImage = global::HeadSoccer.Properties.Resources.Stadium;
            this.Controls.Add(this.goalBox);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1106, 720);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.goalBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox goalBox;
    }
}
