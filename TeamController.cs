using Microsoft.AspNetCore.Mvc;
using CodersCollab.Models;
using CodersCollab.Data;

namespace CodersCollab.Controllers
{
    public class TeamController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TeamController(ApplicationDbContext context) => _context = context;

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(Team team)
        {
            if (ModelState.IsValid)
            {
                _context.Teams.Add(team);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(team);
        }
    }
}