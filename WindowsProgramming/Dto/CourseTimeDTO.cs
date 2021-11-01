using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.Dto
{
    public class CourseTimeDTO
    {
        /// <summary>
        /// 取得時間加總
        /// </summary>
        /// <returns></returns>
        public int GetHour()
        {
            int hour = 0;
            if (Sunday == true)
                hour++;
            if (Monday == true)
                hour++;
            if (Tuesday == true)
                hour++;
            if (Wednesday == true)
                hour++;
            if (Thursday == true)
                hour++;
            if (Friday == true)
                hour++;
            if (Saturday == true)
                hour++;
            return hour;
        }

        public CourseTimeDTO(int index)
        {
            Index = index;
            Sunday = Monday = Tuesday = Wednesday = Thursday = Friday = Saturday = false;
        }

        public int Index
        {
            get; set;
        }

        public bool Sunday
        {
            get; set;
        }

        public bool Monday
        {
            get; set;
        }

        public bool Tuesday
        {
            get; set;
        }

        public bool Wednesday
        {
            get; set;
        }

        public bool Thursday
        {
            get; set;
        }

        public bool Friday
        {
            get; set;
        }

        public bool Saturday
        {
            get; set;
        }
    }
}
