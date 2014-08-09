using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using DnDe5.Web.Helpers;
using DnDe5.Web.Models.Encounters;

namespace DnDe5.Web.Controllers
{
    public class EncountersController : Controller
    {
        public ActionResult Index()
        {
            return View(SessionStateSink.SessionEncounters);
        }

        [HttpGet]
        public ActionResult EncounterCreate()
        {
            if (SessionStateSink.SessionEncounter == null)
            { 
                SessionStateSink.SessionEncounter = new EncounterModel();
            }
            return View(SessionStateSink.SessionEncounter);
        }

        [HttpGet]
        public ActionResult EncounterEdit(Guid id)
        {
            SessionStateSink.SessionEncounter = SessionStateSink.SessionEncounters[id];
            
            return View("EncounterCreate", SessionStateSink.SessionEncounter);
        }

        [HttpPost]
        public ActionResult EncounterCreate(EncounterModel model)
        {
            if (SessionStateSink.SessionEncounters == null)
            {
                SessionStateSink.SessionEncounters = new Dictionary<Guid, EncounterModel>();
            }
            model.Id = Guid.NewGuid();
            model.Monsters = new List<Monster>();
            
            SessionStateSink.SessionEncounters.Add(model.Id, model);

            return View(SessionStateSink.SessionEncounter);
        }

        [HttpPost]
        public ActionResult MonsterCreate(Monster monster, Guid encounterId)
        {
            SessionStateSink.SessionEncounters[encounterId].Monsters.Add(monster);
            return RedirectToAction("EncounterCreate", new RouteValueDictionary(new Dictionary<string, object> { { "id", encounterId }}));
        }
    }
}