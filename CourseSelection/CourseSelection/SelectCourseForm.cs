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
            DataGridView dataGridView = CreateDataGridView();
            dataGridView.Parent = this;
        }

        private DataGridView CreateDataGridView()
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

            DataGridView recordDataGridView = new DataGridView
            {
                AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill,
                ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                Name = "recordDGV",
                ReadOnly = true,
                RowHeadersVisible = false,
                Dock = System.Windows.Forms.DockStyle.Top,
                SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            };

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = columnNames.FirstOrDefault(),
                Name = columnNames.FirstOrDefault()
            };
            recordDataGridView.Columns.Add(checkBoxColumn);

            for (int i = 1; i < columnNames.Count; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                {
                    HeaderText = columnNames[i],
                    Name = columnNames[i]
                };
                recordDataGridView.Columns.Add(column);
            }

            return recordDataGridView;
        }
    }
}
