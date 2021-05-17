using System;
using System.Collections.Generic;
using System.Text;

namespace EducationalSystemTables.Model
{
    class Student_Assessment
    {
        public int Id { get; set; }
        public int Module_Id { get; set; }
        public int Student_Id { get; set; }
        public int Mark { get; set; }
        public int Assesment_Type_Id { get; set; }
    }
}
