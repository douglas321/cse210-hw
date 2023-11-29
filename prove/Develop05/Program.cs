using System;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        string response = "";
        List<Goal> goals = new List<Goal>();

        while(response != "6")
        {
            //Display menu
            System.Console.WriteLine();
            System.Console.WriteLine($"You have {totalPoints} points.");
            System.Console.WriteLine();
            System.Console.WriteLine("Menu Options:");
            System.Console.WriteLine("\t1. Create New Goal");
            System.Console.WriteLine("\t2. List Goals");
            System.Console.WriteLine("\t3. Save Goals");
            System.Console.WriteLine("\t4. Load Goals");
            System.Console.WriteLine("\t5. Record Event");
            System.Console.WriteLine("\t6. Quit");
            System.Console.Write("Select a choice from the menu: ");
            response = Console.ReadLine();
            
            //Create a new goal
            if(response == "1")
            {
                Console.Clear();
                System.Console.WriteLine("The type of goals are:");
                System.Console.WriteLine("\t1. Simple Goal");
                System.Console.WriteLine("\t2. Eternal Goal");
                System.Console.WriteLine("\t3. Checklist Goal");
                System.Console.Write("Which type of goal would you like to create? ");
                string goalResponse = Console.ReadLine();

                string title = "";
                string description = "";
                int points = 0;
                int milestone = 0;
                int milestonePoints = 0;
                if(goalResponse == "1" || goalResponse == "2" || goalResponse == "3")
                {
                    System.Console.Write("What is the name of your goal? ");
                    title = Console.ReadLine();
                    System.Console.Write("Write a short description of your goal? ");
                    description = Console.ReadLine();
                    System.Console.Write("What is the amount of points associated with this goal? ");
                    points = int.Parse(Console.ReadLine());
                }
                if (goalResponse == "1")
                {
                    var simpleGoal = new SimpleGoal(title,description,points);
                    goals.Add(simpleGoal);
                }
                if (goalResponse == "2")
                {
                    var eternalGoal = new EternalGoal(title,description,points);
                    goals.Add(eternalGoal);
                }
                if (goalResponse == "3")
                {
                    System.Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    milestone = int.Parse(Console.ReadLine());
                    System.Console.Write("How many bonus points are to be awarded? ");
                    milestonePoints = int.Parse(Console.ReadLine());
                    var checklistGoal = new ChecklistGoal(title, description, points, milestone, milestonePoints);
                    goals.Add(checklistGoal);
                }
                    
            }

            //display goals
            else if(response == "2")
            {
               Console.Clear();
                System.Console.WriteLine("The goals are:");
                int count = 1;
                foreach (var goal in goals)
                {
                    System.Console.WriteLine($"\t{count}. {goal.GetTitle()}");
                    count += 1;
                }
            }

            //save goals
            else if(response == "3")
            {
                Console.Clear();
                System.Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    
                    outputFile.WriteLine(totalPoints);
                    foreach (var goal in goals)
                    {
                        outputFile.WriteLine(goal.GetGoalAsString());
                    }
                }

            }
            //load goals
            else if(response == "4")
            {
                Console.Clear();
                System.Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(fileName);

        
                totalPoints = int.Parse(lines[0]);
                for (int i =1; i < lines.Length; i++)
                {
                    string[] goalType = lines[i].Split(":");
                    string[] goalParts = goalType[1].Split(",");
                    string title = goalParts[0];
                    string description = goalParts[1];
                    int points = int.Parse(goalParts[2]);

                    if(goalType[0] == "SimpleGoal")
                    {
                        bool done = Convert.ToBoolean(goalParts[3]);
                        var simpleGoal = new SimpleGoal(title, description, points);
                        simpleGoal.SetDone(done);
                        goals.Add(simpleGoal);
                    }
                    if(goalType[0] == "EternalGoal")
                    {
                        int timesCompleted = int.Parse(goalParts[3]);
                        var eternalGoal = new EternalGoal(title, description, points);
                        eternalGoal.SetTimesCompleted(timesCompleted);
                        goals.Add(eternalGoal);
                    }
                    if(goalType[0] == "CheckListGoal")
                    {
                        bool done = Convert.ToBoolean(goalParts[3]);
                        int milestonePoints = int.Parse(goalParts[4]);
                        int milestone = int.Parse(goalParts[5]);
                        int timesCompleted = int.Parse(goalParts[6]);
                        var checklistGoal = new ChecklistGoal(title, description, points, milestone, milestonePoints);
                        checklistGoal.SetDone(done);
                        checklistGoal.SetTimesCompleted(timesCompleted);
                        goals.Add(checklistGoal);
                    }
                }
            }
            //record event
            else if(response == "5")
            {
                Console.Clear();
                System.Console.WriteLine("The goals are:");
                int count = 1;
                foreach (var goal in goals)
                {
                    System.Console.WriteLine($"\t{count}. {goal.GetTitle()}");
                    count += 1;
                }
                System.Console.Write("What goal did you accomplish? ");
                int recordResponse = int.Parse(Console.ReadLine());
                int newPoints =+ goals[recordResponse-1].RecordGoal();
                System.Console.WriteLine($"Congratulations! You have earned {newPoints} points!");
                totalPoints += newPoints;
                System.Console.WriteLine($"\nYou now have {totalPoints} points.\n");
            }
        }
    }
}