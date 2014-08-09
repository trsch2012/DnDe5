using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc.Html;
using System.Web.UI.WebControls;

namespace DnDe5.Web.Models.Encounters
{
    public class Monster
    {
        public string Name { get; set; }

        public int Speed { get; set; }

        public int AC { get; set; }

        public int STR { get; set; }

        public int DEX { get; set; }

        public int CON { get; set; }

        public int INT { get; set; }

        public int WIS { get; set; }

        public int CHA { get; set; }

        public string Alignment { get; set; }

        public int XP { get; set; }

        public string Traits { get; set; }
        public string Actions { get; set; }
        public int HP { get; set; }
        public string Loot { get; set; }
        public string Sense_Immunities { get; set; }
        public string Notes { get; set; }
    }
}
