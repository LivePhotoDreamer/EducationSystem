using System;
using System.Collections.Generic;
using System.Text;

namespace EducationalSystemTables.Model
{
    class Curriculum
    {
        public int Id { get; set; }
        public int Subject_Id { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        public int Credits { get; set; }
        public int Hours_Count { get; set; }
    }
}
