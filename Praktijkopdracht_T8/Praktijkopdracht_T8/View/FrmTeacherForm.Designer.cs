namespace Praktijkopdracht_T8.View
{
    partial class FrmTeacherForm
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
            txtTeacherName = new Label();
            teacherImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)teacherImage).BeginInit();
            SuspendLayout();
            // 
            // txtTeacherName
            // 
            txtTeacherName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTeacherName.Location = new Point(12, 25);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(458, 33);
            txtTeacherName.TabIndex = 0;
            txtTeacherName.Text = "label1";
            txtTeacherName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // teacherImage
            // 
            teacherImage.Location = new Point(12, 88);
            teacherImage.Name = "teacherImage";
            teacherImage.Size = new Size(458, 229);
            teacherImage.SizeMode = PictureBoxSizeMode.Zoom;
            teacherImage.TabIndex = 1;
            teacherImage.TabStop = false;
            // 
            // FrmTeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 329);
            Controls.Add(teacherImage);
            Controls.Add(txtTeacherName);
            MaximizeBox = false;
            Name = "FrmTeacherForm";
            Text = "FrmTeacherForm";
            ((System.ComponentModel.ISupportInitialize)teacherImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label txtTeacherName;
        private PictureBox teacherImage;
    }
}