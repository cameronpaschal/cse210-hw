

using System;
using System.Threading;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        MathAssignment mAssignment = new MathAssignment("james", "math", "6.2","10-18");

        mAssignment.GetSummary();
        mAssignment.GetHomeworkList();

        WritingAssignment wAssignment = new WritingAssignment("jane", "writing", "AI powered shopping carts");
        wAssignment.GetSummary();
        wAssignment.GetWritingInformation();

    }

    
}
