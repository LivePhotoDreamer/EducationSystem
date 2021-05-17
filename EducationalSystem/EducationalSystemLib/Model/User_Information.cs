using System;
using System.Collections.Generic;
using System.Text;

namespace EducationalSystemTablesTables.Model
{
    class User_Information
    {
        public int Id { get; set; }
        public int User_Type_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middle_Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
