namespace Tyuiu.SanzyapovOD.Sprint7.Project.V7
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            textBoxInfo_SOD = new TextBox();
            textBoxInfo2_SOD = new TextBox();
            pictureBox_SOD = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SOD).BeginInit();
            SuspendLayout();
            // 
            // textBoxInfo_SOD
            // 
            textBoxInfo_SOD.BackColor = SystemColors.ControlLight;
            textBoxInfo_SOD.BorderStyle = BorderStyle.None;
            textBoxInfo_SOD.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInfo_SOD.Location = new Point(12, 12);
            textBoxInfo_SOD.Multiline = true;
            textBoxInfo_SOD.Name = "textBoxInfo_SOD";
            textBoxInfo_SOD.ReadOnly = true;
            textBoxInfo_SOD.Size = new Size(438, 393);
            textBoxInfo_SOD.TabIndex = 1;
            textBoxInfo_SOD.TabStop = false;
            textBoxInfo_SOD.Text = resources.GetString("textBoxInfo_SOD.Text");
            // 
            // textBoxInfo2_SOD
            // 
            textBoxInfo2_SOD.BackColor = SystemColors.ControlLight;
            textBoxInfo2_SOD.BorderStyle = BorderStyle.None;
            textBoxInfo2_SOD.Font = new Font("Arial", 12F);
            textBoxInfo2_SOD.Location = new Point(12, 601);
            textBoxInfo2_SOD.Multiline = true;
            textBoxInfo2_SOD.Name = "textBoxInfo2_SOD";
            textBoxInfo2_SOD.ReadOnly = true;
            textBoxInfo2_SOD.Size = new Size(438, 136);
            textBoxInfo2_SOD.TabIndex = 2;
            textBoxInfo2_SOD.TabStop = false;
            textBoxInfo2_SOD.Text = resources.GetString("textBoxInfo2_SOD.Text");
            // 
            // pictureBox_SOD
            // 
            pictureBox_SOD.BackgroundImage = (Image)resources.GetObject("pictureBox_SOD.BackgroundImage");
            pictureBox_SOD.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_SOD.Location = new Point(12, 398);
            pictureBox_SOD.Name = "pictureBox_SOD";
            pictureBox_SOD.Size = new Size(438, 197);
            pictureBox_SOD.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_SOD.TabIndex = 3;
            pictureBox_SOD.TabStop = false;
            // 
            // FormHelp
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(462, 723);
            Controls.Add(pictureBox_SOD);
            Controls.Add(textBoxInfo2_SOD);
            Controls.Add(textBoxInfo_SOD);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHelp";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_SOD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInfo_SOD;
        private System.Windows.Forms.TextBox textBoxInfo2_SOD;
        private System.Windows.Forms.PictureBox pictureBox_SOD;
    }
}