using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Homework.Models
{
    public class Event
    {

        public int EventId{ get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Location { get; set; }
        public string DateAndTime { get; set; }
    }
}