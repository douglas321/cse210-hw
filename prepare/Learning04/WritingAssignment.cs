public class WritingAssignment : Assignment
{
    private int _wordCount;

    public WritingAssignment(string studentName, string topic, int wordCount) : base(studentName, topic)
    {
        _wordCount = wordCount;
    }

    public string GetWritingInformation()
    {
        return $"Word Count: {_wordCount}";
    }
}