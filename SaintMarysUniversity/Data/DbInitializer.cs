using SaintMarysUniversity.Models;
using System;
using System.Linq;

namespace SaintMarysUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"), Anumber="A75869446"},
            new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01"), Anumber="A36475890"},
            new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01"), Anumber="A00784637"},
            new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01"), Anumber="A08980990"},
            new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01"), Anumber="A87300989"},
            new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01"), Anumber="A12345678"},
            new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01"), Anumber="A88889089"},
            new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01"), Anumber="A46377789"}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseNumber=1050,CRN=8900},
            new Course{CourseNumber=4022,CRN = 8901},
            new Course{CourseNumber=4041,CRN = 8902},
            new Course{CourseNumber=1045,CRN = 8903},
            new Course{CourseNumber=3141,CRN = 8904},
            new Course{CourseNumber=2021,CRN = 8905},
            new Course{CourseNumber=2042,CRN = 8906}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseNumber=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseNumber=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseNumber=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseNumber=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseNumber=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseNumber=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseNumber=1050},
            new Enrollment{StudentID=4,CourseNumber=1050},
            new Enrollment{StudentID=4,CourseNumber=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseNumber=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseNumber=1045},
            new Enrollment{StudentID=7,CourseNumber=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}