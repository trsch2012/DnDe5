using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnDe5.Web.Models.Encounters
{
    public class EncounterModel
    {
        public EncounterModel()
        {

        }

        public Guid Id { get; set; }
        public string EncounterName { get; set; }
        public List<Monster> Monsters { get; set; }
    }
}