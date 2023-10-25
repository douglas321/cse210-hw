using System;

class Program
{
    static void Main(string[] args)
    {
    
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", 7);
        string mathSummary = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathSummary);
        Console.WriteLine(homeworkList);

        WritingAssignment writingAssignment = new WritingAssignment("Alice Johnson", "Essay 1", 1500);
        string writingSummary = writingAssignment.GetSummary();
        string writingInfo = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingSummary);
        Console.WriteLine(writingInfo);
    

    }
}