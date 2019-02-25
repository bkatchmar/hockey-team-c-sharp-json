using System;

namespace hockey_team_c_sharp_json
{
    class Program
    {
        static void Main(string[] args)
        {
            HockeyTeam ht = new HockeyTeam(loc:"New York",teamname:"Rangers",div:"Metropolitan",conf:"Eastern");
            Console.WriteLine(ht.ToString());
        }
    }
}