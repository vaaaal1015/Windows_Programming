
namespace CourseSelection
{
    partial class SelectCourseForm
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
            this._courseGrid = new System.Windows.Forms.DataGridView();
            this._checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._stageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._creditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._hourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._teacherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sundayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mondayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tuesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._wednesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._thursdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fridayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._saturdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._classroomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numberOfPeopleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numberOfDropColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._teachingAssistantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._languageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._syllabusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._noteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._labColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._resultButton = new System.Windows.Forms.Button();
            this._submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _courseGrid
            // 
            this._courseGrid.AllowUserToAddRows = false;
            this._courseGrid.AllowUserToDeleteRows = false;
            this._courseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._courseGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this._courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._checkBoxColumn,
            this._numberColumn,
            this._courseColumn,
            this._stageColumn,
            this._creditColumn,
            this._hourColumn,
            this._typeColumn,
            this._teacherColumn,
            this._sundayColumn,
            this._mondayColumn,
            this._tuesdayColumn,
            this._wednesdayColumn,
            this._thursdayColumn,
            this._fridayColumn,
            this._saturdayColumn,
            this._classroomColumn,
            this._numberOfPeopleColumn,
            this._numberOfDropColumn,
            this._teachingAssistantColumn,
            this._languageColumn,
            this._syllabusColumn,
            this._noteColumn,
            this._additionalColumn,
            this._labColumn});
            this._courseGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this._courseGrid.Location = new System.Drawing.Point(0, 0);
            this._courseGrid.Margin = new System.Windows.Forms.Padding(0);
            this._courseGrid.Name = "_courseGrid";
            this._courseGrid.RowHeadersVisible = false;
            this._courseGrid.RowTemplate.Height = 24;
            this._courseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._courseGrid.Size = new System.Drawing.Size(1584, 644);
            this._courseGrid.TabIndex = 0;
            this._courseGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SetCellMouseUp);
            this._courseGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SetCellValueChanged);
            // 
            // _checkBoxColumn
            // 
            this._checkBoxColumn.HeaderText = "選";
            this._checkBoxColumn.Name = "_checkBoxColumn";
            this._checkBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._checkBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._checkBoxColumn.Width = 42;
            // 
            // _numberColumn
            // 
            this._numberColumn.HeaderText = "課號";
            this._numberColumn.Name = "_numberColumn";
            this._numberColumn.ReadOnly = true;
            this._numberColumn.Width = 51;
            // 
            // _courseColumn
            // 
            this._courseColumn.HeaderText = "課程名稱";
            this._courseColumn.Name = "_courseColumn";
            this._courseColumn.Width = 61;
            // 
            // _stageColumn
            // 
            this._stageColumn.HeaderText = "階段";
            this._stageColumn.Name = "_stageColumn";
            this._stageColumn.Width = 51;
            // 
            // _creditColumn
            // 
            this._creditColumn.HeaderText = "學分";
            this._creditColumn.Name = "_creditColumn";
            this._creditColumn.Width = 51;
            // 
            // _hourColumn
            // 
            this._hourColumn.HeaderText = "時數";
            this._hourColumn.Name = "_hourColumn";
            this._hourColumn.Width = 51;
            // 
            // _typeColumn
            // 
            this._typeColumn.HeaderText = "修";
            this._typeColumn.Name = "_typeColumn";
            this._typeColumn.Width = 42;
            // 
            // _teacherColumn
            // 
            this._teacherColumn.HeaderText = "教師";
            this._teacherColumn.Name = "_teacherColumn";
            this._teacherColumn.Width = 51;
            // 
            // _sundayColumn
            // 
            this._sundayColumn.HeaderText = "日";
            this._sundayColumn.Name = "_sundayColumn";
            this._sundayColumn.Width = 42;
            // 
            // _mondayColumn
            // 
            this._mondayColumn.HeaderText = "一";
            this._mondayColumn.Name = "_mondayColumn";
            this._mondayColumn.Width = 42;
            // 
            // _tuesdayColumn
            // 
            this._tuesdayColumn.HeaderText = "二";
            this._tuesdayColumn.Name = "_tuesdayColumn";
            this._tuesdayColumn.Width = 42;
            // 
            // _wednesdayColumn
            // 
            this._wednesdayColumn.HeaderText = "三";
            this._wednesdayColumn.Name = "_wednesdayColumn";
            this._wednesdayColumn.Width = 42;
            // 
            // _thursdayColumn
            // 
            this._thursdayColumn.HeaderText = "四";
            this._thursdayColumn.Name = "_thursdayColumn";
            this._thursdayColumn.Width = 42;
            // 
            // _fridayColumn
            // 
            this._fridayColumn.HeaderText = "五";
            this._fridayColumn.Name = "_fridayColumn";
            this._fridayColumn.Width = 42;
            // 
            // _saturdayColumn
            // 
            this._saturdayColumn.HeaderText = "六";
            this._saturdayColumn.Name = "_saturdayColumn";
            this._saturdayColumn.Width = 42;
            // 
            // _classroomColumn
            // 
            this._classroomColumn.HeaderText = "教室";
            this._classroomColumn.Name = "_classroomColumn";
            this._classroomColumn.Width = 51;
            // 
            // _numberOfPeopleColumn
            // 
            this._numberOfPeopleColumn.HeaderText = "人";
            this._numberOfPeopleColumn.Name = "_numberOfPeopleColumn";
            this._numberOfPeopleColumn.Width = 42;
            // 
            // _numberOfDropColumn
            // 
            this._numberOfDropColumn.HeaderText = "撤";
            this._numberOfDropColumn.Name = "_numberOfDropColumn";
            this._numberOfDropColumn.ReadOnly = true;
            this._numberOfDropColumn.Width = 42;
            // 
            // _teachingAssistantColumn
            // 
            this._teachingAssistantColumn.HeaderText = "教學助理";
            this._teachingAssistantColumn.Name = "_teachingAssistantColumn";
            this._teachingAssistantColumn.ReadOnly = true;
            this._teachingAssistantColumn.Width = 61;
            // 
            // _languageColumn
            // 
            this._languageColumn.HeaderText = "授課語言";
            this._languageColumn.Name = "_languageColumn";
            this._languageColumn.ReadOnly = true;
            this._languageColumn.Width = 61;
            // 
            // _syllabusColumn
            // 
            this._syllabusColumn.HeaderText = "教學大綱與進度表";
            this._syllabusColumn.Name = "_syllabusColumn";
            this._syllabusColumn.ReadOnly = true;
            this._syllabusColumn.Width = 83;
            // 
            // _noteColumn
            // 
            this._noteColumn.HeaderText = "備註";
            this._noteColumn.Name = "_noteColumn";
            this._noteColumn.ReadOnly = true;
            this._noteColumn.Width = 51;
            // 
            // _additionalColumn
            // 
            this._additionalColumn.HeaderText = "隨班附讀";
            this._additionalColumn.Name = "_additionalColumn";
            this._additionalColumn.ReadOnly = true;
            this._additionalColumn.Width = 61;
            // 
            // _labColumn
            // 
            this._labColumn.HeaderText = "實驗實習";
            this._labColumn.Name = "_labColumn";
            this._labColumn.ReadOnly = true;
            this._labColumn.Width = 61;
            // 
            // _resultButton
            // 
            this._resultButton.Enabled = false;
            this._resultButton.Location = new System.Drawing.Point(1342, 647);
            this._resultButton.Name = "_resultButton";
            this._resultButton.Size = new System.Drawing.Size(230, 70);
            this._resultButton.TabIndex = 1;
            this._resultButton.Text = "查看選課結果";
            this._resultButton.UseVisualStyleBackColor = true;
            // 
            // _submitButton
            // 
            this._submitButton.Enabled = false;
            this._submitButton.Location = new System.Drawing.Point(1106, 647);
            this._submitButton.Name = "_submitButton";
            this._submitButton.Size = new System.Drawing.Size(230, 70);
            this._submitButton.TabIndex = 2;
            this._submitButton.Text = "確認送出";
            this._submitButton.UseVisualStyleBackColor = true;
            // 
            // SelectCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 729);
            this.Controls.Add(this._submitButton);
            this.Controls.Add(this._resultButton);
            this.Controls.Add(this._courseGrid);
            this.Name = "SelectCourseForm";
            this.Text = "選課";
            ((System.ComponentModel.ISupportInitialize)(this._courseGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _courseGrid;
        private System.Windows.Forms.Button _resultButton;
        private System.Windows.Forms.Button _submitButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _checkBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _stageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _creditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _hourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _teacherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _sundayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mondayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tuesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _wednesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _thursdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fridayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _saturdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _classroomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numberOfPeopleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numberOfDropColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _teachingAssistantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _languageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _syllabusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _noteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _additionalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _labColumn;
    }
}