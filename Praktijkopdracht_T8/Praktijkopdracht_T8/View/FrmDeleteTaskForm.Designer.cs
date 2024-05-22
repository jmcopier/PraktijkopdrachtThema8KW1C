namespace Praktijkopdracht_T8.View
{
    partial class FrmDeleteTaskForm
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
            deleteTask = new Button();
            close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 50);
            label1.Name = "label1";
            label1.Size = new Size(450, 30);
            label1.TabIndex = 0;
            label1.Text = "Weet je zeker dat je deze taak wilt verwijderen?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteTask
            // 
            deleteTask.Location = new Point(140, 137);
            deleteTask.Name = "deleteTask";
            deleteTask.Size = new Size(75, 23);
            deleteTask.TabIndex = 1;
            deleteTask.Text = "Ja";
            deleteTask.UseVisualStyleBackColor = true;
            deleteTask.Click += deleteTask_Click;
            // 
            // close
            // 
            close.Location = new Point(292, 137);
            close.Name = "close";
            close.Size = new Size(75, 23);
            close.TabIndex = 2;
            close.Text = "Nee";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // FrmDeleteTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 225);
            Controls.Add(close);
            Controls.Add(deleteTask);
            Controls.Add(label1);
            Name = "FrmDeleteTaskForm";
            Text = "FrmDeleteTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button deleteTask;
        private Button close;
    }
}