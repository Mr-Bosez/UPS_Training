using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1.Day1
{
    internal class VotingEligibility
    {
        public  void votingEligibility(int age) {
            Console.WriteLine((age > 18) ? "Eligible to vote" : "Not Eligible to vote");
        }
    }
}
