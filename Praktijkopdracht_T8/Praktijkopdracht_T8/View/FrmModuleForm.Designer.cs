﻿namespace Praktijkopdracht_T8.View
{
    partial class FrmModuleForm
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
            moduleListView = new ListView();
            teacher = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 40);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 1;
            label1.Text = "Module's";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // moduleListView
            // 
            moduleListView.Location = new Point(12, 125);
            moduleListView.Name = "moduleListView";
            moduleListView.Size = new Size(524, 213);
            moduleListView.TabIndex = 2;
            moduleListView.UseCompatibleStateImageBehavior = false;
            // 
            // teacher
            // 
            teacher.Location = new Point(434, 96);
            teacher.Name = "teacher";
            teacher.Size = new Size(102, 23);
            teacher.TabIndex = 3;
            teacher.Text = "Docent inzien";
            teacher.UseVisualStyleBackColor = true;
            teacher.Click += teacher_Click;
            // 
            // FrmModuleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 378);
            Controls.Add(teacher);
            Controls.Add(moduleListView);
            Controls.Add(label1);
            Name = "FrmModuleForm";
            Text = "FrmModuleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView moduleListView;
        private Button teacher;
    }
}