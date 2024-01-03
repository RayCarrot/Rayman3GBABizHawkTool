namespace Rayman3GBABizHawkTool
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
            this.SwitchFrameButton = new System.Windows.Forms.Button();
            this.FramesListBox = new System.Windows.Forms.ListBox();
            this.GamesComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SwitchFrameButton
            // 
            this.SwitchFrameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SwitchFrameButton.Enabled = false;
            this.SwitchFrameButton.Location = new System.Drawing.Point(6, 299);
            this.SwitchFrameButton.Name = "SwitchFrameButton";
            this.SwitchFrameButton.Size = new System.Drawing.Size(403, 23);
            this.SwitchFrameButton.TabIndex = 0;
            this.SwitchFrameButton.Text = "Switch frame";
            this.SwitchFrameButton.UseVisualStyleBackColor = true;
            this.SwitchFrameButton.Click += new System.EventHandler(this.SwitchFrameButton_Click);
            // 
            // FramesListBox
            // 
            this.FramesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FramesListBox.FormattingEnabled = true;
            this.FramesListBox.ItemHeight = 16;
            this.FramesListBox.Location = new System.Drawing.Point(6, 17);
            this.FramesListBox.Name = "FramesListBox";
            this.FramesListBox.Size = new System.Drawing.Size(403, 276);
            this.FramesListBox.TabIndex = 1;
            this.FramesListBox.SelectedIndexChanged += new System.EventHandler(this.FramesListBox_SelectedIndexChanged);
            // 
            // GamesComboBox
            // 
            this.GamesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamesComboBox.DisplayMember = "Name";
            this.GamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GamesComboBox.FormattingEnabled = true;
            this.GamesComboBox.Location = new System.Drawing.Point(12, 12);
            this.GamesComboBox.Name = "GamesComboBox";
            this.GamesComboBox.Size = new System.Drawing.Size(415, 24);
            this.GamesComboBox.TabIndex = 2;
            this.GamesComboBox.SelectedIndexChanged += new System.EventHandler(this.GamesComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.FramesListBox);
            this.groupBox1.Controls.Add(this.SwitchFrameButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 340);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GamesComboBox);
            this.Name = "MainForm";
            this.Text = "Rayman 3 GBA Tool";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SwitchFrameButton;
        private System.Windows.Forms.ListBox FramesListBox;
        private System.Windows.Forms.ComboBox GamesComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}