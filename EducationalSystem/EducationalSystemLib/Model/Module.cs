using System;
using System.Collections.Generic;
using System.Text;

namespace EducationalSystemTables.Model
{
    class Module
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Hours_Count { set; get; }
        public int Marks_Count { set; get; }
        public int Curriculum_id { set; get; }

    }
}
