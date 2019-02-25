using System;

namespace hockey_team_c_sharp_json
{
    public class HockeyTeam
    {
        public string location { get; set; }
        public string name { get; set; }
        public string division { get; set; }
        public string conference { get; set; }

        public HockeyTeam(string loc="", string teamname = "", string div="", string conf="") {
            this.location = loc;
            this.name = teamname;
            this.division = div;
            this.conference = conf;
        }

        public override string ToString() {
            return this.location + " " + this.name;
        }
    }
}