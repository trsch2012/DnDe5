using System;
using System.Collections.Generic;
using System.Web;

using DnDe5.Web.Models.Encounters;

namespace DnDe5.Web.Helpers
{
    public class SessionStateSink
    {
        private const string sessionEncounterKey = "Encounter";
        public static EncounterModel SessionEncounter
        {
            get
            {
                return (EncounterModel)HttpContext.Current.Session[sessionEncounterKey];
            }
            set
            {
                HttpContext.Current.Session[sessionEncounterKey] = value;
            }
        }

        private const string sessionEncountersKey = "Encounters";
        public static IDictionary<Guid, EncounterModel> SessionEncounters
        {
            get
            {
                return (IDictionary<Guid, EncounterModel>)HttpContext.Current.Session[sessionEncounterKey];
            }
            set
            {
                HttpContext.Current.Session[sessionEncounterKey] = value;
            }
        }
    }
}