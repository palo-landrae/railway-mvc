using RailwayModel.Models;

namespace IRailway
{
  public interface IBookingManager
  {
    public List<Ticket> GetTickets();
    public void AddTicket(Ticket ticket);
    public List<AvailableTicket> GetAvailableTickets();
  }
}
