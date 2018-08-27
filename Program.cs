using System;

namespace Blitzkreig
{
    class Program
    {
        static void Main(string[] args)
        {
        Cohort cohort26 = new Cohort();

        Instructor steve = new Instructor("Steve","Brownlee");

        Student brett = new Student("Brett","Shearin");
        Student austin = new Student("Austin", "Gorman");

        cohort26.InstructorList.Add(steve);
        cohort26.StudentList.Add(brett);

        Exercise chick = new Exercise();
        chick.Name = "ChickenMonkey";
        chick.Language = "JavaScript";
        chick.GithubURL = "www.github.com/ChickenMonkey";

        Exercise bleh = new Exercise();
        bleh.Name = "Bleeeh";
        bleh.Language = "C#";
        bleh.GithubURL= "www.github.com/Bleeeh";

        
        steve.AssignExercise(brett,bleh);
        steve.AssignExercise(brett,chick);
        steve.AssignExercise(austin,bleh);

        foreach (Exercise exercise in brett.AssignedExercises)
        {
            Console.WriteLine($"{brett.Name}: {exercise.Name}");
            Console.WriteLine($"{austin.Name}: {exercise.Name}");

        }
        }
    }
}
