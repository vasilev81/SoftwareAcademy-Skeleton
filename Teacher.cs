

namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Teacher : ITeacher
    {
        private string name;
        private IList<ICourse> listOfCourses;

        public Teacher (string name)
        {
            this.Name = name;
            this.ListOfCourses = new List<ICourse>();           
        }

        public IList<ICourse> ListOfCourses
        {
            get
            {
                return this.listOfCourses;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Value can't be null");
                }
                this.listOfCourses = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value can't be null");
                }
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.ListOfCourses.Add(course);
        }
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append(string.Format(this.GetType().Name + ": Name={0}", this.Name));
            if(this.ListOfCourses.Count > 0)
            {
                builder.Append("Courses=");
                for (int i = 0; i < this.ListOfCourses.Count-1; i++)
                {
                    builder.Append(this.ListOfCourses[i] + ", ");
                }
                builder.Append(this.ListOfCourses[this.ListOfCourses.Count - 1] + "]");
            }

            return builder.ToString();
        }
    }
}
