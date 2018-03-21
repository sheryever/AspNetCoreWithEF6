using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeopleData;

namespace AspNetCoreWithEF6.Controllers
{
    public class PeopleController : Controller
    {
        private PeopleEntities peopleEntities;

        public PeopleController(PeopleEntities entities)
        {

            peopleEntities = entities;
        }

        public IActionResult Index()
        {
            return View(peopleEntities.People.ToList());
        }
    }
}