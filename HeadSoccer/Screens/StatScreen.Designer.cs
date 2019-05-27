namespace HeadSoccer.Screens
{
    partial class StatScreen
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
            this.MainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainButton
            // 
            this.MainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.MainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton.Font = new System.Drawing.Font("Machine BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButton.Location = new System.Drawing.Point(16, 634);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(173, 66);
            this.MainButton.TabIndex = 1;
            this.MainButton.Text = "Main Menu";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            this.MainButton.Enter += new System.EventHandler(this.MainButton_Enter);
            this.MainButton.Leave += new System.EventHandler(this.MainButton_Leave);
            // 
            // StatScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.MainButton);
            this.Name = "StatScreen";
            this.Size = new System.Drawing.Size(1106, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainButton;
    }
}
