﻿/*
 * Jesse Copier
 * TeacherForm
 * 22-5-2024
 */

using Praktijkopdracht_T8.Model;
using System.Windows.Forms;

namespace Praktijkopdracht_T8.View
{
    public partial class FrmTeacherForm : Form
    {
        private TeacherModel teacher;

        public FrmTeacherForm(TeacherModel teacher)
        {
            InitializeComponent();

            this.teacher = teacher;

            if (teacher.Infix == null)
            {
                txtTeacherName.Text = $"{teacher.FirstName} {teacher.Surname}";
            }
            else
            {
                txtTeacherName.Text = $"{teacher.FirstName} {teacher.Infix} {teacher.Surname}";
            }

            if (teacher.Image != null && teacher.Image.Length > 0)
            {
                using (var ms = new MemoryStream(teacher.Image))
                {
                    teacherImage.Image = Image.FromStream(ms);
                }
            }

            // string imagePath = teacher.Image;
            // teacherImage.Image = Image.FromFile(imagePath);
        }
    }
}
