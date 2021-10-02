using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class SelectCourseForm : Form
    {
        public SelectCourseForm()
        {
            InitializeComponent();
            DataGridView recordDataGridView = new DataGridView();
            recordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn col2 = new DataGridViewCheckBoxColumn();

            col1.HeaderText = "Column1";
            col2.HeaderText = "Column2";

            recordDataGridView.Columns.AddRange(new DataGridViewColumn[] { col1, col2 });


            //recordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]{col1, col2});
            recordDataGridView.Name = "recordDGV";
            recordDataGridView.ReadOnly = true;
            recordDataGridView.RowHeadersVisible = true;
            recordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            recordDataGridView.Parent = this;
        }

    }
}
