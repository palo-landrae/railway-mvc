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
            DBTicket _newTicket = new DBTicket
            {
                ticketId = ticket.TicketId,
                trainScheduleId = ticket.TrainScheduleId,
                price = ticket.Price
            };
            _context.Ticket.Add(_newTicket);
            _context.SaveChanges();
        }

        public List<AvailableTicket> GetAvailableTickets()
        {
            List<AvailableTicket> tickets = new List<AvailableTicket>();
            List<DBAvailableTicket> dbAvailableTickets = _context.AvailableTicketsView.ToList();
            foreach (var dbTicket in dbAvailableTickets)
            {
                AvailableTicket ticket = new AvailableTicket
                {
                    TicketId = dbTicket.ticketId,
                    Price = (decimal)dbTicket.price,
                    TrainName = dbTicket.trainName,
                    Line = dbTicket.line,
                    DepartureStation = dbTicket.departureStation,
                    ArrivalStation = dbTicket.arrivalStation,
                    DepartureTime = dbTicket.departureTime,
                    ArrivalTime = dbTicket.arrivalTime,
                };
                tickets.Add(ticket);
            }
            return tickets;
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
