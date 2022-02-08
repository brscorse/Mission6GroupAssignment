using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6GroupAssignment.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6GroupAssignment.Controllers
{
    public class HomeController : Controller
    {
        private TaskContext TContext { get; set; }

        public HomeController(TaskContext someName)
        {
            TContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TaskApplication()
        {
            ViewBag.Categories = TContext.Categories.ToList();
            return View(new TaskResponse());
        }

        [HttpPost]
        public IActionResult TaskApplication(TaskResponse tr)
        {
            if (ModelState.IsValid)
            {
                TContext.Add(tr);
                TContext.SaveChanges();
                return View("Confirmation", tr);
            }
            else
            {
                ViewBag.Categories = TContext.Categories.ToList();
                return View();
            }  
        }

        public IActionResult Quadrants()
        {
            var tasks = TContext.TResponses.Include(x => x.Category).ToList();
            return View(tasks);

        }

        [HttpGet]
        public IActionResult Edit(int taskId)
        {
            ViewBag.Categories = TContext.Categories.ToList();
            var taskApp = TContext.TResponses.Single(x => x.TaskId == taskId);

            return View("TaskApplication", taskApp);
        }

        [HttpPost]
        public IActionResult Edit(TaskResponse info)
        {
            TContext.Update(info);
            TContext.SaveChanges();

            return RedirectToAction("Quadrants");
        }

        [HttpGet]
        public IActionResult Delete(int taskid)
        {
            var task = TContext.TResponses.Single(x => x.TaskId == taskid);

            return View(task);
        }

        [HttpPost]
        public IActionResult Delete(TaskResponse tr)
        {
            TContext.TResponses.Remove(tr);
            TContext.SaveChanges();

            return RedirectToAction("Quadrants");
        }
    }
}
