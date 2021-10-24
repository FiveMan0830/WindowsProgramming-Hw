using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model.CourseParts;

namespace CourseApplication.Model
{
    public class Course
    {
        public string CourseId
        { 
            get; set;
        }
        public string CourseName 
        { 
            get; set; 
        }
        public string Stage 
        { 
            get; set; 
        }
        public string Credit 
        { 
            get; set; 
        }
        public string Hour 
        { 
            get; set;
        }
        public string Necessity 
        { 
            get; set; 
        }
        public string Teacher 
        { 
            get; set; 
        }
        public string Sunday
        {
            get; set;
        }
        public string Monday
        {
            get; set;
        }
        public string Tuesday
        {
            get; set;
        }
        public string Wednesday
        {
            get; set;
        }
        public string Thursday
        {
            get; set;
        }
        public string Friday
        {
            get; set;
        }
        public string Saturday
        {
            get; set;
        }
        public string Classroom 
        { 
            get; set; 
        }
        public string NumberOfStudents
        { 
            get; set; 
        }
        public string NumberOfDropStudents 
        { 
            get; set; 
        }
        public string TeachingAssistant 
        { 
            get; set; 
        }
        public string Language 
        { 
            get; set; 
        }
        public string Syllabus 
        { 
            get; set;
        }
        public string Note 
        { 
            get; set; 
        }
        public string Audit 
        { 
            get; set; 
        }
        public string Experiment 
        { 
            get; set; 
        }
    }

    public enum CourseProperties
    {
        CourseIdIndex,
        CourseNameIndex,
        StageIndex,
        CreditIndex,
        HourIndex,
        NecessityIndex,
        TeacherIndex,
        SundayIndex,
        MondayIndex,
        TuesdayIndex,
        WednesdayIndex,
        ThursdayIndex,
        FridayIndex,
        SaturdayIndex,
        ClassroomIndex,
        NumberOfStudentsIndex,
        NumberOfDropStudentsIndex,
        TeachingAssistantIndex,
        LanguageIndex,
        SyllabusIndex,
        NoteIndex,
        AuditIndex,
        ExperimentIndex
    }
}
