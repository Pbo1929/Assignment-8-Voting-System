using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8_Voting_System
{
    class Vote
    {
        private string VoterName;
        private string VoterParty;
        private DateTime VoteTime;
        public static int VoteCount;
        

        public Vote(string VoterName, string VoterParty)
        {
            this.VoterName = VoterName;
            this.VoterParty = VoterParty;
            VoteTime = DateTime.Now;
            VoteCount++;
        }

        public int GetVotes()
        {
            return VoteCount;
        }

        public string GetVoterParty()
        {
            return VoterParty;
        }
    }
}
