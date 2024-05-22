namespace Praktijkopdracht_T8.View
{
    partial class FrmThemeForm
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
            themeListView = new Label();
            themeList = new ListView();
            SuspendLayout();
            // 
            // themeListView
            // 
            themeListView.AutoSize = true;
            themeListView.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            themeListView.Location = new Point(247, 40);
            themeListView.Name = "themeListView";
            themeListView.Size = new Size(93, 30);
            themeListView.TabIndex = 1;
            themeListView.Text = "Thema's";
            themeListView.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // themeList
            // 
            themeList.Location = new Point(12, 125);
            themeList.Name = "themeList";
            themeList.Size = new Size(524, 213);
            themeList.TabIndex = 2;
            themeList.UseCompatibleStateImageBehavior = false;
            // 
            // FrmThemeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 378);
            Controls.Add(themeList);
            Controls.Add(themeListView);
            Name = "FrmThemeForm";
            Text = "FrmThemeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label themeListView;
        private ListView themeList;
    }
}