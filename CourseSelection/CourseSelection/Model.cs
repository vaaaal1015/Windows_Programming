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
        public Model()
        {
            //GetCourseInfo();
        }
        public List<Course> GetCourseInfo()  
        {
            HtmlWeb webClient = new HtmlWeb();
            webClient.OverrideEncoding = Encoding.Default;
            HtmlDocument doc = webClient.Load("https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433");
            //List<Course> courses = new List<Course>();
            HtmlNode nodeTable = doc.DocumentNode.SelectSingleNode("//body/table");
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

        private List<Course> CourseMapping(HtmlNodeCollection nodeTableRow)
        {
            List<Course> courses = new List<Course>();
            foreach (var node in nodeTableRow)
            {
                HtmlNodeCollection nodeTableDatas = node.ChildNodes;
                // 移除 #text
                nodeTableDatas.RemoveAt(0);

                Course course = new Course();
                course.Number = nodeTableDatas[0].InnerText.Trim();
                course.Name = nodeTableDatas[1].InnerText.Trim();
                course.Stage = nodeTableDatas[2].InnerText.Trim();
                course.Credit = nodeTableDatas[3].InnerText.Trim();
                course.Hour = nodeTableDatas[4].InnerText.Trim();
                course.Type = nodeTableDatas[5].InnerText.Trim();
                course.Teacher = nodeTableDatas[6].InnerText.Trim();
                course.ClassTime = new List<string>
                {
                    nodeTableDatas[7].InnerText.Trim(),
                    nodeTableDatas[8].InnerText.Trim(),
                    nodeTableDatas[9].InnerText.Trim(),
                    nodeTableDatas[10].InnerText.Trim(),
                    nodeTableDatas[11].InnerText.Trim(),
                    nodeTableDatas[12].InnerText.Trim(),
                    nodeTableDatas[13].InnerText.Trim()
                };
                course.Classroom = nodeTableDatas[14].InnerText.Trim();
                course.NumberOfPeople = nodeTableDatas[15].InnerText.Trim();
                course.NumberOfDrop = nodeTableDatas[16].InnerText.Trim();
                course.TA = nodeTableDatas[17].InnerText.Trim();
                course.Language = nodeTableDatas[18].InnerText.Trim();
                course.Syllabus = nodeTableDatas[19].InnerText.Trim();
                course.Note = nodeTableDatas[20].InnerText.Trim();
                course.Additional = nodeTableDatas[21].InnerText.Trim();
                course.Lab = nodeTableDatas[22].InnerText.Trim();

                courses.Add(course);
            }
            return courses;
        }
    }
}
