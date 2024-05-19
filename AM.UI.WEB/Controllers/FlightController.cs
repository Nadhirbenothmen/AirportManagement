using AM.ApplicationCore.domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AM.UI.WEB.Controllers
{
    public class FlightController : Controller

    {

        IServiceFlight serviceFlight;
        IServicePlane servicePlane;
        public FlightController (IServiceFlight flightService , IServicePlane servicePlane)
        {
            serviceFlight = flightService;
            this.servicePlane = servicePlane;
        }


        public ActionResult Sort()
        {
            return View("Index", serviceFlight.SortFlights());
        }


        /* GET: FlightController
        public ActionResult Index()
        {
            return View(serviceFlight.GetAll().ToList());
        }
        */
        // GET: FlightController
        public ActionResult Index(DateTime ? dateDepart)
        {
            if (dateDepart == null)
                return View(serviceFlight.GetAll().ToList());
            else
                return View(serviceFlight.GetMany(f => f.FlightDate.Date.Equals(dateDepart)).ToList());
        }
        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {
            ViewBag.Planes = new SelectList(servicePlane.GetAll() , "PlaneId", "PlaneId");
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight flight , IFormFile PilotImage)
        {
            try
            {   
                if(PilotImage != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", PilotImage.FileName);
                    Stream stream = new FileStream(path, FileMode.Create);
                    PilotImage.CopyTo(stream);
                    flight.Pilot = PilotImage.FileName;
                }
                serviceFlight .Add(flight);
                serviceFlight.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
