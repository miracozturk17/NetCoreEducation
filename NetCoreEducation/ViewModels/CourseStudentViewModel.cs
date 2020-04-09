using NetCoreEducation.Model;
using System.Collections.Generic;

namespace NetCoreEducation.ViewModels
{
    public class CourseStudentViewModel
    {
        public Course Courses { get; set; }

        public Student Students { get; set; }

        public List<Category> Categories { get; set; }
    }
}
