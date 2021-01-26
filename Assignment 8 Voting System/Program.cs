using System;

namespace Assignment_8_Voting_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Vote[] Votes = new Vote[5000];
            Votes[0] = new Vote("Bob", "Communists");
            Votes[1] = new Vote("John", "Communists");
            Votes[2] = new Vote("Sam", "Communists");
            Votes[3] = new Vote("Ankit", "Democrats");
            

        }
        static void CastVote(Vote[] Votes)
        {
            {
                int End = 1;
                while(End == 1)
                {
                    Console.WriteLine("VOTE FOR YOUR PARTY...");
                    int x;
                    Console.WriteLine("1 = COMMUNISTS, 2 = DEMOCRATS, 3 = FASCISTS");
                    x = Console.Read();
                    if 
                    if ( x == 1 )
                    {

                    }
                    if ( x == 2 )
                    {

                    }
                    if ( x == 3)
                    {

                    }
                }
                
            }
        }
    }
}
