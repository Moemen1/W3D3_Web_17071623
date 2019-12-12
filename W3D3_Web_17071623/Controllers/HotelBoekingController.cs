using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using W3D3_Web_17071623.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace W3D3_Web_17071623.Controllers
{   

    public class HotelBoekingController : Controller
    {
        public static List<HotelBoeking> BoekingsList = new List<HotelBoeking>();

        // GET: /<controller>/
        public IActionResult Index()
        {   
            return View(BoekingsList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HotelBoeking boeking)
        {
            if(!BoekingsList.Contains(boeking))
            {
                BoekingsList.Add(boeking);
            }

            return View("Details", boeking);
        }
        

        public IActionResult Details(int id)
        { 
            return View(BoekingsList[id]);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(BoekingsList[id]);
        }

        [HttpPost]
        public IActionResult Edit(int id, HotelBoeking nieuweBoeking)
        {
            if (BoekingsList[id] != null)
            {
                BoekingsList[id].Aankomst = nieuweBoeking.Aankomst;
                BoekingsList[id].Vertrek = nieuweBoeking.Vertrek;
            }

            return RedirectToAction("Index");
        }

    }
}
