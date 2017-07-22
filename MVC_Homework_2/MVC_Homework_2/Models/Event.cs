
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Homework_2.Models
{
    public class Event
    {
        public Event()
        {
            this.DateAndTime = DateTime.Now;
        }

        [Key]
        public int EventId { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Location { get; set; }
        public DateTime DateAndTime { get; set; }


        public virtual List<Comment> Comments { get; set; }


        //////////////////////////////////////////////


        public string AppliactionUserId { get; set; }

        /// <summary>
        ///       un drop down
        ///        
        /// </summary>
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}