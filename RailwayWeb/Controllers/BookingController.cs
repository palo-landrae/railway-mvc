using Microsoft.AspNetCore.Mvc;
using IRailway;
using RailwayModel.Models;
using RailwayBusLogic.Manager;

namespace RailwayWeb.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingManager _bookingManager = new BookingManager();

        public ActionResult Index()
        {
            List<Ticket> tickets = _bookingManager.GetTickets();
            ViewBag.Tickets = tickets;
            return View();
        }

        [HttpPost]
        public ActionResult AddTicket(Ticket ticket)
        {
            _bookingManager.AddTicket(ticket);
            return RedirectToAction("Index");
        }
    }
}
