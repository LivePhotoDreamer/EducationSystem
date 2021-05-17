using System;
using System.Collections.Generic;
using System.Text;

namespace EducationalSystemTables.Model
{
    class Department_Employee
    {
        public int Id { get; set; }
        public int Professor_Id { get; set; }
        public int Classes_Type_Id { get; set; }
        public int Curriculum_Id { get; set; }
    }
}
