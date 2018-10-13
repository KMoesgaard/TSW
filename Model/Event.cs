using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model
{
    public class Event
    {
        public string EventName { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
