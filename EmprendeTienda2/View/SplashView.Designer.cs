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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            progressBar = new ProgressBar();
            timer = new System.Windows.Forms.Timer(components);
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
            // progressBar
            // 
            progressBar.BackColor = Color.MediumOrchid;
            progressBar.Location = new Point(101, 368);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(451, 35);
            progressBar.TabIndex = 2;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 200;

            // 
            // SplashView
            // 
            AutoScaleDimensions = new SizeF(31F, 85F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            ClientSize = new Size(632, 415);
            ControlBox = false;
            Controls.Add(progressBar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe Print", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(13, 17, 13, 17);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SplashView";
            ShowInTaskbar = false;
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
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}