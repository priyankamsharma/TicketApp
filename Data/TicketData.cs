using System.Collections.Generic;
using TicketApp.Models;

namespace TicketApp.Data
{
    public class TicketData
    {
        public static List<Ticket> tickets = new List<Ticket>();

        public static void Add(Ticket ticketObject)
        {
            tickets.Add(ticketObject);
        }
    }
}
