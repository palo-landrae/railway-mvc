using IRailway;
using RailwayModel.Models;
using RailwayBusLogic.Context;
using RailwayBusLogic.Context.DBModel;

namespace RailwayBusLogic.Manager
{
  public class BookingManager : IBookingManager
  {
    private readonly RailwayDBContext _context;

    public BookingManager()
    {
      _context = new RailwayDBContext();
    }

    public void AddTicket(Ticket ticket)
    {
      DBTicket _newTicket = new DBTicket();
      _newTicket.ticketId = ticket.TicketId;
      _newTicket.trainScheduleId = ticket.TrainScheduleId;
      _newTicket.price = ticket.Price;
      _context.Ticket.Add(_newTicket);
      _context.SaveChanges();
    }

    public List<Ticket> GetTickets()
    {
      List<Ticket> tickets = new List<Ticket>();
      List<DBTicket> dbTickets = _context.Ticket.ToList();
      foreach (var dbTicket in dbTickets)
      {
        Ticket ticket = new Ticket
        {
          TicketId = dbTicket.ticketId,
          Price = (decimal)dbTicket.price,
          TrainScheduleId = dbTicket.trainScheduleId,
          IsValidated = dbTicket.isValidated,
          CreatedAt = dbTicket.createdAt,
        };
        tickets.Add(ticket);
      }
      return tickets;
    }
  }
}
