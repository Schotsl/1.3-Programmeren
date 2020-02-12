using System.Collections.Generic;

namespace Opdracht_1
{
    class Team
    {
        private List<Programmer> team;

        public Team()
        {
            team = new List<Programmer>();
        }

        public void PrintAllTeamMembers()
        {
            foreach (Programmer programmer in team)
            {
                programmer.Print();
            }
        }

        public void AddProgrammer(Programmer programmer)
        {
            team.Add(programmer);
        }
    }
}
