using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage?");
        int grade = int.Parse(Console.ReadLine());
        String letterGrade;
        bool passedClass;

        if (grade >= 90){
            letterGrade = "A";
            passedClass = true;
        }
        else if (grade >= 80 && grade < 90) {
            letterGrade = "B";
            passedClass = true;
        }
        else if (grade >= 70 && grade < 80) {
            letterGrade = "C";
            passedClass = true;
        }
        else if (grade >=60 && grade < 70) {
            letterGrade = "D";
            passedClass = false;
        }
        else{
            letterGrade = "F";
            passedClass = false;
        }

        if (passedClass) {
            Console.WriteLine("Your final grade is " + letterGrade + "! You passed the class!");
        }
        else{
            Console.WriteLine("Your final grade is " + letterGrade + "! You did not pass the class, better luck next time!");
        }



    }
}