namespace HeadSoccer.Screens
{
    partial class CharacterScreen
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
            this.Char1 = new System.Windows.Forms.PictureBox();
            this.Char2 = new System.Windows.Forms.PictureBox();
            this.InstructLabel = new System.Windows.Forms.Label();
            this.p1ReadyLabel = new System.Windows.Forms.Label();
            this.p2ReadyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Char1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char2)).BeginInit();
            this.SuspendLayout();
            // 
            // Char1
            // 
            this.Char1.BackColor = System.Drawing.Color.Transparent;
            this.Char1.BackgroundImage = global::HeadSoccer.Properties.Resources.Chufu_Cry_Head;
            this.Char1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Char1.Location = new System.Drawing.Point(256, 281);
            this.Char1.Name = "Char1";
            this.Char1.Size = new System.Drawing.Size(120, 167);
            this.Char1.TabIndex = 0;
            this.Char1.TabStop = false;
            // 
            // Char2
            // 
            this.Char2.BackColor = System.Drawing.Color.Transparent;
            this.Char2.BackgroundImage = global::HeadSoccer.Properties.Resources.Chufu_Cry_Head;
            this.Char2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Char2.Location = new System.Drawing.Point(727, 281);
            this.Char2.Name = "Char2";
            this.Char2.Size = new System.Drawing.Size(120, 165);
            this.Char2.TabIndex = 1;
            this.Char2.TabStop = false;
            // 
            // InstructLabel
            // 
            this.InstructLabel.AutoSize = true;
            this.InstructLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructLabel.Location = new System.Drawing.Point(414, 588);
            this.InstructLabel.Name = "InstructLabel";
            this.InstructLabel.Size = new System.Drawing.Size(299, 24);
            this.InstructLabel.TabIndex = 2;
            this.InstructLabel.Text = "Press the green button to ready up";
            // 
            // p1ReadyLabel
            // 
            this.p1ReadyLabel.AutoSize = true;
            this.p1ReadyLabel.Location = new System.Drawing.Point(299, 493);
            this.p1ReadyLabel.Name = "p1ReadyLabel";
            this.p1ReadyLabel.Size = new System.Drawing.Size(47, 13);
            this.p1ReadyLabel.TabIndex = 3;
            this.p1ReadyLabel.Text = "READY!";
            this.p1ReadyLabel.Visible = false;
            // 
            // p2ReadyLabel
            // 
            this.p2ReadyLabel.AutoSize = true;
            this.p2ReadyLabel.Location = new System.Drawing.Point(762, 493);
            this.p2ReadyLabel.Name = "p2ReadyLabel";
            this.p2ReadyLabel.Size = new System.Drawing.Size(47, 13);
            this.p2ReadyLabel.TabIndex = 4;
            this.p2ReadyLabel.Text = "READY!";
            this.p2ReadyLabel.Visible = false;
            // 
            // CharacterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.p2ReadyLabel);
            this.Controls.Add(this.p1ReadyLabel);
            this.Controls.Add(this.InstructLabel);
            this.Controls.Add(this.Char2);
            this.Controls.Add(this.Char1);
            this.Name = "CharacterScreen";
            this.Size = new System.Drawing.Size(1106, 720);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CharacterScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Char1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Char2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Char1;
        private System.Windows.Forms.PictureBox Char2;
        private System.Windows.Forms.Label InstructLabel;
        private System.Windows.Forms.Label p1ReadyLabel;
        private System.Windows.Forms.Label p2ReadyLabel;
    }
}
