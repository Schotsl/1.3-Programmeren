using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            Team team = new Team();

            team.AddProgrammer(new Programmer("Barjan", Specialty.Java));
            team.AddProgrammer(new Programmer("Twan", Specialty.C));
            team.AddProgrammer(new Programmer("Owen", Specialty.HTML));
            team.AddProgrammer(new Programmer("Sjors", Specialty.PHP));
            team.AddProgrammer(new Programmer("Bjorn"));

            team.PrintAllTeamMembers();

            Console.ReadKey();
        }
    }
}
