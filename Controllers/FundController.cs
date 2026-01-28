using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers
{
    public class FundController : Controller
    {
        public IActionResult Index()
        {
            var funds = new List<FundModel>
            {
                new FundModel { Id = 1, Name = "Alpha Fund", Category = "Equity", NAV = 100.50M, Description = "A diversified equity fund." },
                new FundModel { Id = 2, Name = "Beta Fund", Category = "Debt", NAV = 45.20M, Description = "Fixed income fund." },
                new FundModel { Id = 3, Name = "Gamma Fund", Category = "Hybrid", NAV = 78.75M, Description = "Balanced fund." }
            };
            return View(funds);
        }

        public IActionResult Details(int id)
        {
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/data/funds.json");
            var json = System.IO.File.ReadAllText(jsonPath);
            var funds = System.Text.Json.JsonSerializer.Deserialize<List<FundModel>>(json);
            var fund = funds?.FirstOrDefault(f => f.Id == id);
            if (fund == null)
            {
                return NotFound();
            }
            return View(fund);
        }

        public IActionResult Error()
        {
            return View();
        }
    }

    public class FundModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal NAV { get; set; }
        public string Description { get; set; }
    }
}