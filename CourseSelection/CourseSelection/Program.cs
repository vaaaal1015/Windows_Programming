using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            Form selectCourseForm = new SelectCourseForm(model);
            Application.Run(selectCourseForm);
        }
    }
}
