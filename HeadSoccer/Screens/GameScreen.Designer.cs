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
            this.p1winBox = new System.Windows.Forms.PictureBox();
            this.p2winBox = new System.Windows.Forms.PictureBox();
            this.p1Label = new System.Windows.Forms.Label();
            this.p2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1winBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2winBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
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
            // p1winBox
            // 
            this.p1winBox.BackColor = System.Drawing.Color.Transparent;
            this.p1winBox.Image = global::HeadSoccer.Properties.Resources.Player_1_Wins;
            this.p1winBox.Location = new System.Drawing.Point(140, 423);
            this.p1winBox.Name = "p1winBox";
            this.p1winBox.Size = new System.Drawing.Size(854, 93);
            this.p1winBox.TabIndex = 1;
            this.p1winBox.TabStop = false;
            this.p1winBox.Visible = false;
            // 
            // p2winBox
            // 
            this.p2winBox.BackColor = System.Drawing.Color.Transparent;
            this.p2winBox.Image = global::HeadSoccer.Properties.Resources.Player_2_wins;
            this.p2winBox.Location = new System.Drawing.Point(135, 423);
            this.p2winBox.Name = "p2winBox";
            this.p2winBox.Size = new System.Drawing.Size(859, 91);
            this.p2winBox.TabIndex = 2;
            this.p2winBox.TabStop = false;
            this.p2winBox.Visible = false;
            // 
            // p1Label
            // 
            this.p1Label.BackColor = System.Drawing.SystemColors.Control;
            this.p1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.p1Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p1Label.Location = new System.Drawing.Point(133, 620);
            this.p1Label.Name = "p1Label";
            this.p1Label.Size = new System.Drawing.Size(183, 47);
            this.p1Label.TabIndex = 3;
            this.p1Label.Text = "Player 1: 0";
            this.p1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // p2Label
            // 
            this.p2Label.BackColor = System.Drawing.SystemColors.Control;
            this.p2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.p2Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p2Label.Location = new System.Drawing.Point(811, 620);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(183, 47);
            this.p2Label.TabIndex = 4;
            this.p2Label.Text = "Player 2: 0";
            this.p2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImage = global::HeadSoccer.Properties.Resources.Stadium;
            this.Controls.Add(this.p2Label);
            this.Controls.Add(this.p1Label);
            this.Controls.Add(this.p2winBox);
            this.Controls.Add(this.p1winBox);
            this.Controls.Add(this.goalBox);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1106, 720);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.goalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1winBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2winBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox goalBox;
        private System.Windows.Forms.PictureBox p1winBox;
        private System.Windows.Forms.PictureBox p2winBox;
        private System.Windows.Forms.Label p1Label;
        private System.Windows.Forms.Label p2Label;
    }
}
