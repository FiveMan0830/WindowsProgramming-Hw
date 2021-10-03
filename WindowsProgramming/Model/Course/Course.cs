using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.Model.Course
{
    class Course
    {
        public int courseId
        { 
            get; set;
        }
        public string className 
        { 
            get; set; 
        }
        public int stage 
        { 
            get; set; 
        }
        public float credit 
        { 
            get; set; 
        }
        public int hour 
        { 
            get; set;
        }
        public string necessity 
        { 
            get; set; 
        }
        public string teacher 
        { 
            get; set; 
        }
        public CourseTime classTime 
        {
            get; set; 
        }
        public string classroom 
        { 
            get; set; 
        }
        public int numberOfStudents
        { 
            get; set; 
        }
        public int numberOfDropStudents 
        { 
            get; set; 
        }
        public string teachingAssistant 
        { 
            get; set; 
        }
        public string language 
        { 
            get; set; 
        }
        public string syllabus 
        { 
            get; set;
        }
        public string note 
        { 
            get; set; 
        }
        public string audit 
        { 
            get; set; 
        }
        public string experiment 
        { 
            get; set; 
        }
    }

    enum CourseProperties
    {
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
