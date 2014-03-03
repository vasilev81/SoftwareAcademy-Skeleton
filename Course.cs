

namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        private IList<string> courseProgram;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.CourseProgram = new List<string>();
            this.Teacher = teacher;

        }

        public IList<string> CourseProgram
        {
            get
            {
                return this.courseProgram;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value can't be null");
                }
                this.courseProgram = value;
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

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            this.CourseProgram.Add(topic);
        }
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append(string.Format(this.GetType().Name + ": " + "Name={0}; Teacher={1};", this.Name,this.Teacher));
            if(this.CourseProgram.Count > 0)
            {
                builder.Append("Topics=[");
                for (int i = 0; i < this.CourseProgram.Count-1; i++)
                {
                    builder.Append(this.CourseProgram[i] + ", ");
                }
                builder.Append(this.CourseProgram[this.CourseProgram.Count - 1] + "]");
            }

            return builder.ToString();
        }
    }
}
