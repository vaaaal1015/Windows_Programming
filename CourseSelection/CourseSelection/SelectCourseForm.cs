using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSelection
{
    public partial class SelectCourseForm : Form
    {

        private Model model;
        public SelectCourseForm(Model model)
        {
            InitializeComponent();
            this.model = model;
            SetDataGridView(this.dataGridView1);
            AddDataGridViewRow(this.dataGridView1);
        }

        /// <summary>
        /// 自訂DataGrideView
        /// </summary>
        /// <param name="dataGridView"></param>
        private void SetDataGridView(DataGridView dataGridView)
        {

            List<String> columnNames = new List<string>
            {
                "選",
                "課號",
                "課程名稱",
                "階段",
                "學分",
                "時數",
                "修",
                "教師",
                "日",
                "一",
                "二",
                "三",
                "四",
                "五",
                "六",
                "教室",
                "人",
                "撤",
                "教學助理",
                "授課語言",
                "教學大綱與進度表",
                "備註",
                "隨班附讀",
                "實驗實習"
            };

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = columnNames.FirstOrDefault(),
                Name = columnNames.FirstOrDefault(),
            };
            dataGridView.Columns.Add(checkBoxColumn);

            for (int i = 1; i < columnNames.Count; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                {
                    HeaderText = columnNames[i],
                    Name = columnNames[i]
                };
                dataGridView.Columns.Add(column);
                dataGridView.Columns[i].ReadOnly = true;
            }

            dataGridView.CellValueChanged += CellValueChanged;
            dataGridView.CellMouseUp += OnMouseUp;
        }

        private void CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                model.checkedCounter((bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                button1.Enabled = model.IsChecked();
            }
        }

        private void OnMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                dataGridView1.EndEdit();
            }
        }

        private void AddDataGridViewRow(DataGridView dataGridView)
        {
            List<Course> courses = model.GetCourseInfo();
            foreach(Course course in courses)
            {
                dataGridView.Rows.Add(
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
                    course.ClassTime[0],
                    course.ClassTime[1],
                    course.ClassTime[2],
                    course.ClassTime[3],
                    course.ClassTime[4],
                    course.ClassTime[5],
                    course.ClassTime[6],
                    course.Classroom,
                    course.NumberOfPeople,
                    course.NumberOfDrop,
                    course.TA,
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
