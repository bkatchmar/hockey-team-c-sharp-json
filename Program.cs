using JsonConvert = Newtonsoft.Json.JsonConvert;
using System;
using System.Collections.Generic;
using StreamReader = System.IO.StreamReader;

namespace hockey_team_c_sharp_json
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("hockey-teams.json")) {
                string json = reader.ReadToEnd();
                List<HockeyTeam> items = JsonConvert.DeserializeObject<List<HockeyTeam>>(json);

                foreach (HockeyTeam ht in items) {
                    Console.WriteLine(ht.ToString());
                }
            }
        }
    }
}