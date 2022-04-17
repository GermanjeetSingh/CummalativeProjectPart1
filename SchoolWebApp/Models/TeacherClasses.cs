using System.Collections.Generic;

namespace SchoolWebApp.Models
{
    public class TeacherClasses
    {
        public Teacher teacher { get; set; }
        public IEnumerable<Class> classes { get; set; }
        public TeacherClasses(Teacher teacher, IEnumerable<Class> classes)
        {
            this.teacher = teacher;
            this.classes = classes;
        }
    }
}
