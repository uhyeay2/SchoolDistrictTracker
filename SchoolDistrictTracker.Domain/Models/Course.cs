using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDistrictTracker.Domain.Models
{
    public class Course
    {
        public School School { get; set; } = null!;
        public int SchoolId { get; set; }
    }
}
