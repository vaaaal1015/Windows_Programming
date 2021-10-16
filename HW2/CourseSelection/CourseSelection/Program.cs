using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSelection.Model;

namespace CourseSelection
{
    class Program
    {
        /// <summary>
        /// 程式進入點
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StartUpForm startUpForm = new StartUpForm(new StartUpFormPresentationModel());
            Application.Run(startUpForm);
        }
    }
}
