﻿namespace AssignmentDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football football1 = new Football() { Id = 1,FootballName="Adidas1", Location=new Location() };

            Player p1_1 = new Player { Name = "Ahmed", Team = "Team1", Number = 10 };
            Player p1_2 = new Player { Name = "Ali", Team = "Team1", Number = 11 };
            Player p1_3 = new Player { Name = "Osama", Team = "Team1", Number = 12 };
            Player p1_4 = new Player { Name = "Khattab", Team = "Team1", Number = 13 };

            Player p2_1 = new Player { Name = "Saeed", Team = "Team2", Number = 10 };
            Player p2_2 = new Player { Name = "Ibra", Team = "Team2", Number = 11 };
            Player p2_3 = new Player { Name = "Marwan", Team = "Team2", Number = 12 };
            Player p2_4 = new Player { Name = "Ziad", Team = "Team2", Number = 13 };

            Referee referee1 = new Referee();

            football1.FootballLocatonChanged += p1_1.Run;
            football1.FootballLocatonChanged += p1_2.Run;
            football1.FootballLocatonChanged += p1_3.Run;
            football1.FootballLocatonChanged += p2_1.Run;
            football1.FootballLocatonChanged += p2_2.Run;
            football1.FootballLocatonChanged += p2_3.Run;

            football1.FootballLocatonChanged += referee1.Observe;
            football1.FootballLocatonChanged += (Location loc) => Console.WriteLine("Start!!");

            football1.Location = new Location { X = 40, Y = 50, Z = 60 };


            football1.FootballLocatonChanged -= p1_1.Run;
            football1.FootballLocatonChanged -= p2_1.Run;
            //add another subsribers
            football1.FootballLocatonChanged += p1_4.Run;
            football1.FootballLocatonChanged += p2_4.Run;

            //
            football1.Location = new Location { X = 80, Y = 90, Z = 100 };
        }

        
    }
}
