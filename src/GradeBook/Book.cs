namespace GradeBook
{
    public abstract class Book : NamedObject, IBook
    {
        protected Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
        public virtual Statistics GetStats()
        {
            throw new System.NotImplementedException();
        }
    }
}