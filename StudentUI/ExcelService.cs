// ExcelService.cs
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace StudentUI
{
    public class ExcelService
    {
        public byte[] GenerateExcelFile(List<Student> students)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Students");

                // Add headers
                worksheet.Cells[1, 1].Value = "Student ID";
                worksheet.Cells[1, 2].Value = "Gender";
                worksheet.Cells[1, 3].Value = "Nationality";
                worksheet.Cells[1, 4].Value = "Place of Birth";
                worksheet.Cells[1, 5].Value = "Stage ID";
                worksheet.Cells[1, 6].Value = "Grade ID";
                worksheet.Cells[1, 7].Value = "Section ID";
                worksheet.Cells[1, 8].Value = "Topic";
                worksheet.Cells[1, 9].Value = "Semester";
                worksheet.Cells[1, 10].Value = "Relation";
                worksheet.Cells[1, 11].Value = "Raised Hands";
                worksheet.Cells[1, 12].Value = "Visited Resources";
                worksheet.Cells[1, 13].Value = "Announcements View";
                worksheet.Cells[1, 14].Value = "Discussion";
                worksheet.Cells[1, 15].Value = "Parent Answering Survey";
                worksheet.Cells[1, 16].Value = "Parent School Satisfaction";
                worksheet.Cells[1, 17].Value = "Student Absence Days";
                worksheet.Cells[1, 18].Value = "Student Marks";
                worksheet.Cells[1, 19].Value = "Class";

                // Add data rows
                int row = 2;
                foreach (var student in students)
                {
                    worksheet.Cells[row, 1].Value = student.Student_ID;
                    worksheet.Cells[row, 2].Value = student.Gender;
                    worksheet.Cells[row, 3].Value = student.NationalIty;
                    worksheet.Cells[row, 4].Value = student.PlaceofBirth;
                    worksheet.Cells[row, 5].Value = student.StageId;
                    worksheet.Cells[row, 6].Value = student.GradeId;
                    worksheet.Cells[row, 7].Value = student.SectionId;
                    worksheet.Cells[row, 8].Value = student.Topic;
                    worksheet.Cells[row, 9].Value = student.Semester;
                    worksheet.Cells[row, 10].Value = student.Relation;
                    worksheet.Cells[row, 11].Value = student.Raisedhands;
                    worksheet.Cells[row, 12].Value = student.VisItedResources;
                    worksheet.Cells[row, 13].Value = student.AnnouncementsView;
                    worksheet.Cells[row, 14].Value = student.Discussion;
                    worksheet.Cells[row, 15].Value = student.ParentAnsweringSurvey;
                    worksheet.Cells[row, 16].Value = student.ParentschoolSatisfaction;
                    worksheet.Cells[row, 17].Value = student.StudentAbsenceDays;
                    worksheet.Cells[row, 18].Value = student.Student_Marks;
                    worksheet.Cells[row, 19].Value = student.Class;

                    row++;
                }

            

            return package.GetAsByteArray();
            }
        }
    }
}
