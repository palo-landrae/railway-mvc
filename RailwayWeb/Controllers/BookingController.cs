using Microsoft.AspNetCore.Mvc;
using IRailway;
using RailwayModel.Models;
using RailwayBusLogic.Manager;

namespace RailwayWeb.Controllers
{
  public class BookingController : Controller
  {
    public IActionResult Index()
    {
      IBookingManager bookingManager = new BookingManager();
      return View();
    }

    [HttpPost]
    public ActionResult AddTicket(Ticket ticket)
    {
      IBookingManager bookingManager = new BookingManager();
      bookingManager.AddTicket(ticket);
      return View(bookingManager.GetTickets());
    }
  }
}
