﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Form selectCourseForm = new SelectCourseForm();
            Application.Run(selectCourseForm);
        }
    }
}
