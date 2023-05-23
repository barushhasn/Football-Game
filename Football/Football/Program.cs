using Football;

Coach coach = new Coach { Name = "Hristo Stoichkov", Age = 57};

Goalkeeper goalkeeper = new Goalkeeper { Name = "Manuel Neuer", Age = 37, Number = 1, Height = 180 };
Defender defender = new Defender { Name = "Sergio Ramos", Age = 34, Number = 4, Height = 177 };
Midfield midfield = new Midfield { Name = "Andres Iniesta", Age = 39, Number = 8, Height = 171 };
Striker striker = new Striker { Name = "Kylian Mbappe", Age = 24, Number = 29, Height = 178 };

Team team = new Team
{
    Coach = coach,
    Players = new List<Football_Player> { goalkeeper, defender, midfield, striker }
};

Referee referee = new Referee { Name = "Pierluigi Collina", Age = 63 };

AssitantReferee assistantReferee1 = new AssitantReferee { Name = "Assistant Referee 1", Age = 46 };
AssitantReferee assistantReferee2 = new AssitantReferee { Name = "Assistant Referee 2", Age = 40 };

Game game = new Game
{
    Team1 = team,
    Team2 = new Team(),
    Referee = referee,
    AssistantReferee = new List<AssitantReferee> { assistantReferee1, assistantReferee2 },
    Goals = new List<Goal>(),
    Result = " ",
    Winner = null
};