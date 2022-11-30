using SaintMarysUniversity.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaintMarysUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public int CourseNumber { get; set; }
        public int CRN { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}