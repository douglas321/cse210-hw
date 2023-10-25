public class MathAssignment : Assignment
{
    private int _problems;

    public MathAssignment(string studentName, string topic, int problems) : base(studentName, topic)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_problems} Problems 8-19";
    }
}