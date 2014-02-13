namespace CreatingSchool
{
    using System;
    using System.Collections.Generic;

    class Teacher : Person
    {
        // Fields
        public Comment Comments;

        private List<Discipline> disciplinesToTeach;

        // Constructor
        public Teacher(string name, params Discipline[] disciplines)
            : base(name)
        {
            this.Comments = new Comment();
            this.disciplinesToTeach = new List<Discipline>(disciplines);
        }

        // Properties
        public List<Discipline> DisciplinesToTeach
        {
            get { return new List<Discipline>(this.disciplinesToTeach); }
        }

        // Methods
        public void AddDiscipline(Discipline disciplineToAdd)
        {
            this.disciplinesToTeach.Add(disciplineToAdd);
        }

        public void RemoveDiscipline(Discipline disciplineToRemove)
        {
            this.disciplinesToTeach.Remove(disciplineToRemove);
        }
    }
}
