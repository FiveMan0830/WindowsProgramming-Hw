using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.Model.Dto
{
    class CourseInfoDto
    {
        public CourseInfoDto(string number, string name, string stage, string credit, string hour,
            string requiredOrElective, string teacher, string sunday, string monday, string tuesday, string wednesday, string thursday, string friday, string saturday, string classroom,
            string numberOfStudent, string numberOfDropStudent, string teachingAssistant, string language,
            string note, string syllabus, string audit, string experiment)
        {
            this.Number = number;
            this.Name = name;
            this.Stage = stage;
            this.Credit = credit;
            this.Hour = hour;
            this.RequiredOrElective = requiredOrElective;
            this.Teacher = teacher;
            this.Sunday = sunday;
            this.Monday = monday;
            this.Tuesday = tuesday;
            this.Wednesday = wednesday;
            this.Thursday = thursday;
            this.Friday = friday;
            this.Saturday = saturday;
            this.Classroom = classroom;
            this.NumberOfStudent = numberOfStudent;
            this.NumberOfDropStudent = numberOfDropStudent;
            this.TeachingAssistant = teachingAssistant;
            this.Language = language;
            this.Syllabus = syllabus;
            this.Note = note;
            this.Audit = audit;
            this.Experiment = experiment;
        }

        public string Number
        {
            get; set;
        }

        public string Name
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

        public string NumberOfStudent
        {
            get; set;
        }

        public string Note
        {
            get; set;
        }

        public string NumberOfDropStudent
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

        public string Audit
        {
            get; set;
        }

        public string Experiment
        {
            get; set;
        }

        public string RequiredOrElective
        {
            get; set;
        }
    }
}
