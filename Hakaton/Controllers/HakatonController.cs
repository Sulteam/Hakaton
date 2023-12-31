﻿using Hakaton.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hakaton.Controllers
{
    public class HakatonController : Controller
    {
        [HttpGet]
        public ActionResult EnterScreen()
        {
            List<Survey> Query = new List<Survey>();
            using (var db = new HakatonVEBEntities())

                return View(Query);
        }
        [HttpGet]
        public ActionResult QueryCreate()
        {
            
                //if (ModelState.IsValid)
                //{
                //    using (var context = new HakatonVEBEntities())
                //    {
                //        {                            
                //            context.Survey.Add(NewQuery);                        
                //        }
                //    }                   
                //}
                
                return View();
            
        }
        [HttpPost]
        public ActionResult QueryCreate(Survey NewQuery)
        {
            if (ModelState.IsValid)
            {
                using (var context = new HakatonVEBEntities())
                {

                    {
                        context.Survey.Add(NewQuery);
                        context.SaveChanges();
                    }
                }
                return RedirectToAction("EnterScreen");
            }
            return View(NewQuery);
        }
        public ActionResult QueryEdit()
        {
            return View();

        }
        public ActionResult QueryResults()
        {
            List<Answers> Query = new List<Answers>();
            using (var db = new HakatonVEBEntities())

                return View(Query);
            

        }

        [HttpGet]
        public ActionResult Login()
        {

            return View();

        }

        [HttpGet]
        public ActionResult QuestionCreate()
        {           
            return View();
        }
        [HttpPost]
        public ActionResult QuestionCreate(Questions NewQuestion)
        {
            if (ModelState.IsValid)
            {
                using (var context = new HakatonVEBEntities())
                {

                    {
                        context.Questions.Add(NewQuestion);
                        context.SaveChanges();
                    }
                }
                return RedirectToAction("EnterScreen");
            }
            return View(NewQuestion);
        }

    }
}