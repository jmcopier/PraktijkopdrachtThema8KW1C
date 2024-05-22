namespace Praktijkopdracht_T8.View
{
    partial class FrmAddTaksForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtStartdate = new DateTimePicker();
            txtDueDate = new DateTimePicker();
            statusCombo = new ComboBox();
            moduleCombo = new ComboBox();
            addTask = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Naam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 70);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Omschrijving";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 110);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Startdatum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 150);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 3;
            label4.Text = "Inleverdatum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 190);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 230);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "Module";
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(140, 23);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(139, 67);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(245, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtStartdate
            // 
            txtStartdate.Location = new Point(139, 107);
            txtStartdate.Name = "txtStartdate";
            txtStartdate.Size = new Size(200, 23);
            txtStartdate.TabIndex = 8;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(139, 147);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.Size = new Size(200, 23);
            txtDueDate.TabIndex = 9;
            // 
            // statusCombo
            // 
            statusCombo.FormattingEnabled = true;
            statusCombo.Location = new Point(139, 187);
            statusCombo.Name = "statusCombo";
            statusCombo.Size = new Size(121, 23);
            statusCombo.TabIndex = 10;
            // 
            // moduleCombo
            // 
            moduleCombo.FormattingEnabled = true;
            moduleCombo.Location = new Point(139, 227);
            moduleCombo.Name = "moduleCombo";
            moduleCombo.Size = new Size(245, 23);
            moduleCombo.TabIndex = 11;
            // 
            // addTask
            // 
            addTask.Location = new Point(38, 292);
            addTask.Name = "addTask";
            addTask.Size = new Size(222, 23);
            addTask.TabIndex = 12;
            addTask.Text = "Toevoegen";
            addTask.UseVisualStyleBackColor = true;
            addTask.Click += addTask_Click;
            // 
            // FrmAddTaksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 367);
            Controls.Add(addTask);
            Controls.Add(moduleCombo);
            Controls.Add(statusCombo);
            Controls.Add(txtDueDate);
            Controls.Add(txtStartdate);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddTaksForm";
            Text = "FrmAddTaksForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtDescription;
        private DateTimePicker txtStartdate;
        private DateTimePicker txtDueDate;
        private ComboBox statusCombo;
        private ComboBox moduleCombo;
        private Button addTask;
    }
}