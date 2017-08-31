using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.Entities
{
    public class TimeEntry : IEntity
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int Slot { get; set; }
        public string Time { get; set; }
        public string Information { get; set; }
        public string Person { get; set; }
    }
}