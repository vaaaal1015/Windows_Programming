using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSelection.Model
{   
    public class StartUpFormPresentationModel
    {
        public event ModelChangedEventHandler ModelChanged;
        public delegate void ModelChangedEventHandler();
        private bool _isManagementEnable;
        private bool _isSeletingEnable;
        
        public StartUpFormPresentationModel()
        {
            _isManagementEnable = true;
            _isSeletingEnable = true;
        }

        /// <summary>
        /// 關閉Management按鈕
        /// </summary>
        public void SetManagementDisable()
        {
            _isManagementEnable = false;
            NotifyObserver();
        }

        /// <summary>
        /// 開啟Management按鈕
        /// </summary>
        public void SetManagementEnable()
        {
            _isManagementEnable = true;
            NotifyObserver();
        }

        /// <summary>
        /// 關閉Selecting按鈕
        /// </summary>
        public void SetSelectingDisable()
        {
            _isSeletingEnable = false;
            NotifyObserver();
        }

        /// <summary>
        /// 開啟Selecting按鈕
        /// </summary>
        public void SetSelectingEnable()
        {
            _isSeletingEnable = true;
            NotifyObserver();
        }

        /// <summary>
        /// Management按鈕是否開啟
        /// </summary>
        /// <returns></returns>
        public bool IsManagementEnable()
        {
            return _isManagementEnable;
        }

        /// <summary>
        /// Seleting按鈕是否開啟
        /// </summary>
        /// <returns></returns>
        public bool IsSeletingEnable()
        {
            return _isSeletingEnable;
        }

        /// <summary>
        /// Observer Patten
        /// </summary>
        void NotifyObserver()
        {
            if (ModelChanged != null)
                ModelChanged();
        }
    }
}
