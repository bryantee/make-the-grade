namespace GradeBook
{
    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStats();
        string Name { get; }
        // event GradeAddedDelegate GradeAdded;
        void ShowName();
        void ShowStats();
        void AddLetterGrade(char letter);
        void ShowCategory();
    }
}