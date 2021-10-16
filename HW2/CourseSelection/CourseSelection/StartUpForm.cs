using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSelection.Model;

namespace CourseSelection
{
    public partial class StartUpForm : Form
    {
        private StartUpFormPresentationModel _presentationModel;

        public StartUpForm(StartUpFormPresentationModel startUpFormPresentationModel)
        {
            InitializeComponent();
            _presentationModel = startUpFormPresentationModel;
            _presentationModel.ModelChanged += UpdateView;
        }

        /// <summary>
        /// 按下Exit按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickExitButton(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 按下CourseManagementSystem按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCourseManagementSystemButton(object sender, EventArgs e)
        {
            CourseManagementForm courseManagementForm = new CourseManagementForm();
            courseManagementForm.FormClosed += ClosedCourseManagementForm;
            courseManagementForm.Show();

            _presentationModel.SetManagementDisable();
        }

        /// <summary>
        /// 當CourseManagementForm被關閉時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosedCourseManagementForm(object sender, FormClosedEventArgs e)
        {
            _presentationModel.SetManagementEnable();
        }

        /// <summary>
        /// 按下CourseManagementSystem按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCourseSelectingSystemButton(object sender, EventArgs e)
        {
            CourseSelectingForm selectingForm = new CourseSelectingForm();
            selectingForm.FormClosed += ClosedCourseSelectingForm;
            selectingForm.Show();

            _presentationModel.SetSelectingDisable();
        }

        /// <summary>
        /// 當CourseManagementForm被關閉時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosedCourseSelectingForm(object sender, FormClosedEventArgs e)
        {
            _presentationModel.SetSelectingEnable();
        }

        /// <summary>
        /// 跟新View
        /// </summary>
        private void UpdateView()
        {
            this._courseManagementSystemButton.Enabled = _presentationModel.IsManagementEnable();
            this._courseSelectingSystemButton.Enabled = _presentationModel.IsSeletingEnable();
        }
    }
}
