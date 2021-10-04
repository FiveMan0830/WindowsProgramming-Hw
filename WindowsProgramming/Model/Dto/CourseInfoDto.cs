﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CourseApplication.Model;

namespace CourseApplication.Model.Dto
{
    public class CourseInfoDto
    {
        public CourseInfoDto(Course course, bool isCourseSelected = false)
        {
            IsCourseSelected = isCourseSelected;
            Course = course;
        }

        public bool IsCourseSelected
        {
            get; set;
        }

        public Course Course
        {
            get;
        }
    }
}
