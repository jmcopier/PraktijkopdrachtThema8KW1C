namespace Praktijkopdracht_T8.View
{
    partial class FrmTaskForm
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
            taskListView = new ListView();
            addTask = new Button();
            deleteTask = new Button();
            exportTask = new Button();
            taskComboBox = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 0;
            label1.Text = "Taken";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taskListView
            // 
            taskListView.Location = new Point(12, 125);
            taskListView.Name = "taskListView";
            taskListView.Size = new Size(524, 241);
            taskListView.TabIndex = 1;
            taskListView.UseCompatibleStateImageBehavior = false;
            // 
            // addTask
            // 
            addTask.Location = new Point(218, 86);
            addTask.Name = "addTask";
            addTask.Size = new Size(103, 23);
            addTask.TabIndex = 2;
            addTask.Text = "Toevoegen";
            addTask.UseVisualStyleBackColor = true;
            addTask.Click += addTask_Click;
            // 
            // deleteTask
            // 
            deleteTask.Location = new Point(327, 87);
            deleteTask.Name = "deleteTask";
            deleteTask.Size = new Size(103, 23);
            deleteTask.TabIndex = 3;
            deleteTask.Text = "Verwijderen";
            deleteTask.UseVisualStyleBackColor = true;
            // 
            // exportTask
            // 
            exportTask.Location = new Point(436, 87);
            exportTask.Name = "exportTask";
            exportTask.Size = new Size(103, 23);
            exportTask.TabIndex = 4;
            exportTask.Text = "Exporteren";
            exportTask.UseVisualStyleBackColor = true;
            // 
            // taskComboBox
            // 
            taskComboBox.FormattingEnabled = true;
            taskComboBox.Location = new Point(72, 87);
            taskComboBox.Name = "taskComboBox";
            taskComboBox.Size = new Size(121, 23);
            taskComboBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 91);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Toon:";
            // 
            // FrmTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 378);
            Controls.Add(label2);
            Controls.Add(taskComboBox);
            Controls.Add(exportTask);
            Controls.Add(deleteTask);
            Controls.Add(addTask);
            Controls.Add(taskListView);
            Controls.Add(label1);
            Name = "FrmTaskForm";
            Text = "FrmTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView taskListView;
        private Button addTask;
        private Button deleteTask;
        private Button exportTask;
        private ComboBox taskComboBox;
        private Label label2;
    }
}