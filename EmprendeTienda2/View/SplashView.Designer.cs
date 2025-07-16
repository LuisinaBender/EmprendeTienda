namespace EmprendeTiendaDesktop.View
{
    partial class SplashView
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(121, 9);
            label1.Margin = new Padding(13, 0, 13, 0);
            label1.Name = "label1";
            label1.Size = new Size(371, 65);
            label1.TabIndex = 0;
            label1.Text = "EmprenderApp";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._;
            pictureBox1.Location = new Point(65, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 271);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.MediumOrchid;
            progressBar1.Location = new Point(101, 368);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(451, 35);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // SplashView
            // 
            AutoScaleDimensions = new SizeF(31F, 85F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            ClientSize = new Size(632, 415);
            ControlBox = false;
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe Print", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(13, 17, 13, 17);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SplashView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashView";
            TopMost = true;
            Activated += SplashView_Activated;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
    }
}