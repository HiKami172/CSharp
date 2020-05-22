using System.Collections;
using System;
using System.Security;

namespace SharpLab3
{
    class SpecialStudent : Student
    {
        private string speciality;
        private string group;
        private int course = 1;
        public delegate void StateHandler(string message);
        StateHandler del;

        public void RegisterHandler(StateHandler del)
        {
            this.del = del;
        }

        public SpecialStudent(string speciality,int course, Form form, string name, string surname, int age, string UniverName) : base(name, surname, age, UniverName, form)
        {
            this.speciality = speciality;
            this.course = course;
        }

        public SpecialStudent(Student student, string Speciality) : base(student)
        {
            speciality = Speciality;
        }

        public SpecialStudent(Student student, string Speciality, int Course) : base(student)
        {
            speciality = Speciality;
            course = Course;
        }

        public class CompareCourse : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                SpecialStudent stud1 = (SpecialStudent)obj1;
                SpecialStudent stud2 = (SpecialStudent)obj2;
                if (stud1.course == stud2.course)
                    return 0;
                return (stud1.course > stud2.course) ? 1 : -1;
            }
        }
        public void SetGroup(string group)
        {
            this.group = group;
        }

        public void GetSpecInfo()
        {
            GetInfo();
            Console.Write("Speciality: {0}\nCourse: {1}\n", speciality, course);
            if (group != null)
                Console.WriteLine("Group: " + group);

            del?.Invoke(GetHobbies());
        }

    }
}
