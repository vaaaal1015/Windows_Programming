using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CourseSelection
{
    public partial class SelectCourseForm : Form
    {

        private Model _model;
        private DataGridView _currentCourseGrid;

        public SelectCourseForm(Model model)
        {
            InitializeComponent();
            this._model = model;
            this._currentCourseGrid = this._courseGrid;
            AddDataGridViewRow();
        }

        /// <summary>
        /// DataGridView 變更資料事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (_model != null)
                {
                    _model.CheckedCounter((bool)_currentCourseGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    _resultButton.Enabled = _model.IsChecked();
                }
            }
        }

        /// <summary>
        /// DataGridView 放開滑鼠事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                _currentCourseGrid.EndEdit();
            }
        }

        /// <summary>
        /// 將課程資料加入DataGrideView
        /// </summary>
        /// <param name="dataGridView"></param>
        private void AddDataGridViewRow()
        {
            List<Course> courses = _model.GetCourseInfo();
            foreach (Course course in courses)
            {
                _currentCourseGrid.Rows.Add(
                new object[]
                {
                    false,
                    course.Number,
                    course.Name,
                    course.Stage,
                    course.Credit,
                    course.Hour,
                    course.Type,
                    course.Teacher,
                    course.ClassTime[(int)DayOfWeek.Sunday],
                    course.ClassTime[(int)DayOfWeek.Monday],
                    course.ClassTime[(int)DayOfWeek.Tuesday],
                    course.ClassTime[(int)DayOfWeek.Wednesday],
                    course.ClassTime[(int)DayOfWeek.Thursday],
                    course.ClassTime[(int)DayOfWeek.Friday],
                    course.ClassTime[(int)DayOfWeek.Saturday],
                    course.Classroom,
                    course.NumberOfPeople,
                    course.NumberOfDrop,
                    course.TeachingAssistant,
                    course.Language,
                    course.Syllabus,
                    course.Note,
                    course.Additional,
                    course.Lab
                });
            }
        }
    }
}
