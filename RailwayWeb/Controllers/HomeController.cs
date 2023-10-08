using Microsoft.AspNetCore.Mvc;
using IRailway;
using RailwayModel.Models;
using RailwayBusLogic.Manager;

namespace RailwayWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookingManager _bookingManager = new BookingManager();

        public ActionResult Index()
        {
            List<AvailableTicket> tickets = _bookingManager.GetAvailableTickets();
            ViewBag.AvailableTickets = tickets;
            return View();
        }
    }
}
