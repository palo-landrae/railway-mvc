using RailwayModel.Models;

namespace IRailway
{
  public interface IBookingManager
  {
    public List<Ticket> GetTickets();
    public void BookTicket(Ticket ticket);
  }
}
