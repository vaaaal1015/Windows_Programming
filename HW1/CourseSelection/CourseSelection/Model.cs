using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelection
{
    public class Model
    {
        private int _checkedAmount;
        private const string LOCATION = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
        private const string NODE = "//body/table";

        public Model()
        {
            _checkedAmount = 0;
        }

        /// <summary>
        /// 取得網路上的課程資料
        /// </summary>
        /// <returns></returns>
        public List<Course> GetCourseInfo()  
        {
            HtmlWeb webClient = new HtmlWeb();
            webClient.OverrideEncoding = Encoding.Default;
            HtmlDocument document = webClient.Load(LOCATION);
            HtmlNode nodeTable = document.DocumentNode.SelectSingleNode(NODE);
            HtmlNodeCollection nodeTableRow = nodeTable.ChildNodes;
            // 移除 tbody
            nodeTableRow.RemoveAt(0);
            // 移除 <tr>資工三
            nodeTableRow.RemoveAt(0);
            // 移除 table header
            nodeTableRow.RemoveAt(0);
            // 移除 <tr>小計
            nodeTableRow.RemoveAt(nodeTableRow.Count - 1);

            return CourseMapping(nodeTableRow);
        }

        /// <summary>
        /// Mapping爬蟲抓下來的資料
        /// </summary>
        /// <param name="nodeTableRow"></param>
        /// <returns></returns>
        private List<Course> CourseMapping(HtmlNodeCollection nodeTableRow)
        {
            List<Course> courses = new List<Course>();
            foreach (var node in nodeTableRow)
            {
                HtmlNodeCollection nodeTableDatas = node.ChildNodes;
                // 移除 #text
                nodeTableDatas.RemoveAt(0);

                Course course = new Course();
                CourseBasicMapping(nodeTableDatas, course);
                CourseOtherMapping(nodeTableDatas, course);

                courses.Add(course);
            }
            return courses;
        }

        /// <summary>
        /// 將爬蟲抓下來的基本資料Mapping到Course 
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <param name="course"></param>
        private void CourseBasicMapping(HtmlNodeCollection nodeTableDatas, Course course)
        {
            course.Number = nodeTableDatas[(int)CourseNode.Number].InnerText.Trim();
            course.Name = nodeTableDatas[(int)CourseNode.Name].InnerText.Trim();
            course.Stage = nodeTableDatas[(int)CourseNode.Stage].InnerText.Trim();
            course.Credit = nodeTableDatas[(int)CourseNode.Credit].InnerText.Trim();
            course.Hour = nodeTableDatas[(int)CourseNode.Hour].InnerText.Trim();
            course.Type = nodeTableDatas[(int)CourseNode.Type].InnerText.Trim();
            course.Teacher = nodeTableDatas[(int)CourseNode.Teacher].InnerText.Trim();
            CourseClassTimeMapping(nodeTableDatas, course);
            course.Classroom = nodeTableDatas[(int)CourseNode.Classroom].InnerText.Trim();
        }

        /// <summary>
        /// 將爬蟲抓下來的日期資料Mapping到Course 
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <param name="course"></param>
        private void CourseClassTimeMapping(HtmlNodeCollection nodeTableDatas, Course course)
        {
            course.ClassTime = new List<string>
            {
                nodeTableDatas[(int)CourseNode.Sunday].InnerText.Trim(),
                nodeTableDatas[(int)CourseNode.Monday].InnerText.Trim(),
                nodeTableDatas[(int)CourseNode.Tuesday].InnerText.Trim(),
                nodeTableDatas[(int)CourseNode.Wednesday].InnerText.Trim(),
                nodeTableDatas[(int)CourseNode.Thursday].InnerText.Trim(),
                nodeTableDatas[(int)CourseNode.Friday].InnerText.Trim(),
                nodeTableDatas[(int)CourseNode.Saturday].InnerText.Trim()
            };
        }

        /// <summary>
        /// 將爬蟲抓下來的修課相關資料Mapping到Course
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <param name="course"></param>
        private void CourseOtherMapping(HtmlNodeCollection nodeTableDatas, Course course)
        {
            course.NumberOfPeople = nodeTableDatas[(int)CourseNode.NumberOfPeople].InnerText.Trim();
            course.NumberOfDrop = nodeTableDatas[(int)CourseNode.NumberOfDrop].InnerText.Trim();
            course.TeachingAssistant = nodeTableDatas[(int)CourseNode.TeachingAssistant].InnerText.Trim();
            course.Language = nodeTableDatas[(int)CourseNode.Language].InnerText.Trim();
            course.Syllabus = nodeTableDatas[(int)CourseNode.Syllabus].InnerText.Trim();
            course.Note = nodeTableDatas[(int)CourseNode.Note].InnerText.Trim();
            course.Additional = nodeTableDatas[(int)CourseNode.Additional].InnerText.Trim();
            course.Lab = nodeTableDatas[(int)CourseNode.Lab].InnerText.Trim();
        }

        /// <summary>
        /// 紀錄勾選的數量
        /// </summary>
        /// <param name="boolen"></param>
        public void CheckedCounter(bool state)
        {
            if (state)
            {
                _checkedAmount++;
            }
            else if (_checkedAmount > 0)
            {
                _checkedAmount--;
            }
        }

        /// <summary>
        /// 是否有課程被勾選
        /// </summary>
        /// <returns></returns>
        public bool IsChecked()
        {
            return _checkedAmount > 0;
        }

        /// <summary>
        /// 將修課資訊轉換成DataGridView的row
        /// </summary>
        /// <returns></returns>
        //public List<object[]> GetCourseInfoToRows()
        //{
        //    List<Course> courses = GetCourseInfo();
        //    List<object[]> rows = new List<object[]>();
        //    foreach (Course course in courses)
        //    {
        //        rows.Add(new object[]
        //        {
        //            false,
        //            course.Number,
        //            course.Name,
        //            course.Stage,
        //            course.Credit,
        //            course.Hour,
        //            course.Type,
        //            course.Teacher,
        //            course.ClassTime[(int)DayOfWeek.Sunday],
        //            course.ClassTime[(int)DayOfWeek.Monday],
        //            course.ClassTime[(int)DayOfWeek.Tuesday],
        //            course.ClassTime[(int)DayOfWeek.Wednesday],
        //            course.ClassTime[(int)DayOfWeek.Thursday],
        //            course.ClassTime[(int)DayOfWeek.Friday],
        //            course.ClassTime[(int)DayOfWeek.Saturday],
        //            course.Classroom,
        //            course.NumberOfPeople,
        //            course.NumberOfDrop,
        //            course.TeachingAssistant,
        //            course.Language,
        //            course.Syllabus,
        //            course.Note,
        //            course.Additional,
        //            course.Lab
        //        });
        //    }
        //    return rows;
        //}
    }
}
