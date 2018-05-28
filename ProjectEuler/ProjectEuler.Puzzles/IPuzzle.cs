namespace ProjectEuler.Puzzles
{
    public interface IPuzzle
    {
        string Title { get; }
        string Summary { get; }
        string Answer { get; }
        void SolvePuzzle();
    }
}