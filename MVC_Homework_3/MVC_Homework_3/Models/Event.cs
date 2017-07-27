
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Homework_2.Models
{
    public class Event
    {
     

        [Key]
        public int EventId { get; set; }
        
        //public Image Image { get; set; }

        // [DisplayName("Title")]
        public string Title { get; set; }
        // [DisplayName("Details")]
        public string Details { get; set; }
        // [DisplayName("Location")]
        public string Location { get; set; }
        // [DisplayName("DateAndTime")]
        public DateTime DateAndTime { get; set; }

        public bool IsSubscribed { get; set; }

        public virtual List<Comment> Comments { get; set; }

        //////////////////////////////////////////////

        public string ApplicationUserId { get; set; }

       public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual List<ApplicationUser> Subscribers { get; set; }

    }
}