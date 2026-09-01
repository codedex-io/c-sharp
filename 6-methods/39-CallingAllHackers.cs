// Calling All Hackers 💻
// Codédex

using System;

class CallingAllHackers
{
  static void Main()
  {
    string eventName = "Boba and Booleans";
    int attendees = 24;
    int teamSize = 4;
    int startHour = 6;
    int endHour = 12;

    int teams = CalculateTeams(attendees, teamSize);
    int hours = CalculateHours(startHour, endHour);
    string invite = CreateInvite(eventName, teams, hours);

    Console.WriteLine(invite);
  }

  static int CalculateTeams(int attendees, int teamSize)
  {
    return attendees / teamSize;
  }

  static int CalculateHours(int startHour, int endHour)
  {
    return endHour - startHour;
  }

  static string CreateInvite(string eventName, int teams, int hours)
  {
    return "💻 " + eventName + " starts at 6 PM! "
      + "We'll hack for " + hours + " hours in "
      + teams + " teams. See you there! 🧋";
  }
}