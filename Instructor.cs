using System;
using System.Collections.Generic;

namespace Blitzkreig{

public class Instructor{
private string _firstName;
private string _lastName;

public string Name {get => $"{_firstName} {_lastName}";}

        public Instructor(string firstName, string lastName){
            _firstName =firstName;
            _lastName = lastName;
        }
public void AssignExercise(Student student, Exercise exercise){
student.AssignedExercises.Add(exercise);
}



}
}