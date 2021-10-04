using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public CourseTime CourseTime
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
        SelectOptionsLocation,
        CourseIdLocation,
        CourseNameLocation,
        StageLocation,
        CreditLocation,
        HourLocation,
        NecessityLocation,
        TeacherLocation,
        SundayLocation,
        MondayLocation,
        TuesdayLocation,
        WednesdayLocation,
        ThursdayLocation,
        FridayLocation,
        SaturdayLocation,
        ClassroomLocation,
        NumberOfStudentsLocation,
        NumberOfDropStudentsLocation,
        TeachingAssistantLocation,
        LanguageLocation,
        SyllabusLocation,
        NoteLocation,
        AuditLocation,
        ExperimentLocation
    }
}
