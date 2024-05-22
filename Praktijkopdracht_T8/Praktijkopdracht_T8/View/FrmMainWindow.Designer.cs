namespace Praktijkopdracht_T8
{
    partial class FrmMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainWindow));
            pictureBox1 = new PictureBox();
            taskBtn = new Button();
            themeBtn = new Button();
            moduleBtn = new Button();
            closeApp = new Button();
            mainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // taskBtn
            // 
            taskBtn.Location = new Point(50, 200);
            taskBtn.Name = "taskBtn";
            taskBtn.Size = new Size(130, 23);
            taskBtn.TabIndex = 1;
            taskBtn.Text = "Taken";
            taskBtn.UseVisualStyleBackColor = true;
            taskBtn.Click += taskBtn_Click;
            // 
            // themeBtn
            // 
            themeBtn.Location = new Point(50, 241);
            themeBtn.Name = "themeBtn";
            themeBtn.Size = new Size(130, 23);
            themeBtn.TabIndex = 2;
            themeBtn.Text = "Thema's";
            themeBtn.UseVisualStyleBackColor = true;
            themeBtn.Click += themeBtn_Click;
            // 
            // moduleBtn
            // 
            moduleBtn.Location = new Point(50, 282);
            moduleBtn.Name = "moduleBtn";
            moduleBtn.Size = new Size(130, 23);
            moduleBtn.TabIndex = 3;
            moduleBtn.Text = "Module's";
            moduleBtn.UseVisualStyleBackColor = true;
            moduleBtn.Click += moduleBtn_Click;
            // 
            // closeApp
            // 
            closeApp.Location = new Point(52, 390);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(130, 23);
            closeApp.TabIndex = 4;
            closeApp.Text = "Afsluiten";
            closeApp.UseVisualStyleBackColor = true;
            closeApp.Click += closeApp_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(224, 21);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(564, 417);
            mainPanel.TabIndex = 5;
            // 
            // FrmMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Controls.Add(closeApp);
            Controls.Add(moduleBtn);
            Controls.Add(themeBtn);
            Controls.Add(taskBtn);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "FrmMainWindow";
            Text = "Planning";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button taskBtn;
        private Button themeBtn;
        private Button moduleBtn;
        private Button closeApp;
        private Panel mainPanel;
    }
}
