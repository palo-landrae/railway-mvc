using Microsoft.AspNetCore.Mvc;
using RailwayModel.Models;
using IRailway;
using RailwayBusLogic;

namespace RailwayWeb.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BookTicket(Ticket ticket)
        {
            IBookingManager bookingManager = new BookingManager();
            bookingManager.BookTicket(ticket);
            return View(bookingManager.GetTickets());
        }
    }
}
