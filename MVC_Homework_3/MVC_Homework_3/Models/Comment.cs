using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Homework_2.Models
{
    public class Comment
    {
        public Comment()
        {
            this.Date = DateTime.Now;
        }

     
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        
        public virtual Event Event { get; set; }
        public int EventId { get; set; }

    }
}