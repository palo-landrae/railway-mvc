using IRailway;
using RailwayModel.Models;

namespace RailwayBusLogic
{
  public class BookingManager : IBookingManager
  {
    public BookingManager() { }

    private List<Ticket> tickets = new List<Ticket>();

    public void BookTicket(Ticket ticket)
    {
      tickets.Add(ticket);
    }

    public List<Ticket> GetTickets()
    {
      return tickets;
    }
  }
}
