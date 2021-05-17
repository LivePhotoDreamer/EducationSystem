using System;
using System.Collections.Generic;
using System.Text;

namespace EducationalSystemTables.Model
{
    class Message
    {
        public int Id { set; get; }
        public DateTime Time { set; get; }
        public int Seen { set; get; }
        public int Chat_id { set; get; }
        public int User_information_id { set; get; }
    }
}
