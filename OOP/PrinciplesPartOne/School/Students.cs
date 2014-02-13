namespace CreatingSchool
{
    using System;

    public class Student : Person
    {
        // Fields
        public Comment Comments;

        private int uniqueClassNumber;

        // Constructor
        public Student(string name, int uniqueClassNum)
            : base(name)
        {
            this.Comments = new Comment();
            this.UniqueClassNumber = uniqueClassNum;
        }

        // Properties
        public int UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new IndexOutOfRangeException("The unique class number is between 1-100");
                }
                this.uniqueClassNumber = value;
            }
        }
    }
}
