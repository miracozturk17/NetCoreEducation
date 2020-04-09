using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEducation.Model
{
    public class Course
    {
        public int CourseId { get; set; }

        public int TeacherId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsPublish { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
