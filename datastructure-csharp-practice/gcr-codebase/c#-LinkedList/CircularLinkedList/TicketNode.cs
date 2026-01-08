using System;

class TicketNode
{
    public int ticketId;
    public string customerName;
    public string movieName;
    public int seatNumber;
    public string bookingTime;

    public TicketNode next;
}

class TicketReservation
{
    TicketNode head;

    // Add ticket at end
    public void AddTicket(int ticketId, string customerName, string movieName,
                          int seatNumber, string bookingTime)
    {
        TicketNode newTicket = new TicketNode();
        newTicket.ticketId = ticketId;
        newTicket.customerName = customerName;
        newTicket.movieName = movieName;
        newTicket.seatNumber = seatNumber;
        newTicket.bookingTime = bookingTime;

        if (head == null)
        {
            head = newTicket;
            newTicket.next = head;
            return;
        }

        TicketNode temp = head;
        while (temp.next != head)
            temp = temp.next;

        temp.next = newTicket;
        newTicket.next = head;
    }

    // Remove ticket by ID
    public void RemoveTicket(int ticketId)
    {
        if (head == null) return;

        TicketNode curr = head;
        TicketNode prev = null;

        do
        {
            if (curr.ticketId == ticketId)
            {
                if (prev != null)
                    prev.next = curr.next;
                else
                {
                    // deleting head
                    TicketNode last = head;
                    while (last.next != head)
                        last = last.next;

                    head = head.next;
                    last.next = head;
                }
                return;
            }

            prev = curr;
            curr = curr.next;
        }
        while (curr != head);
    }

    // Search by customer name
    public void SearchByCustomer(string customerName)
    {
        if (head == null) return;

        TicketNode temp = head;
        do
        {
            if (temp.customerName == customerName)
                DisplayTicket(temp);

            temp = temp.next;
        }
        while (temp != head);
    }

    // Search by movie name
    public void SearchByMovie(string movieName)
    {
        if (head == null) return;

        TicketNode temp = head;
        do
        {
            if (temp.movieName == movieName)
                DisplayTicket(temp);

            temp = temp.next;
        }
        while (temp != head);
    }

    // Display all tickets
    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked");
            return;
        }

        TicketNode temp = head;
        do
        {
            DisplayTicket(temp);
            temp = temp.next;
        }
        while (temp != head);
    }

    // Count total tickets
    public int GetTotalTickets()
    {
        if (head == null) return 0;

        int count = 0;
        TicketNode temp = head;
        do
        {
            count++;
            temp = temp.next;
        }
        while (temp != head);

        return count;
    }

    void DisplayTicket(TicketNode t)
    {
        Console.WriteLine(
            t.ticketId + " " +
            t.customerName + " " +
            t.movieName + " Seat:" +
            t.seatNumber + " Time:" +
            t.bookingTime
        );
    }
}

class Program
{
    static void Main()
    {
        TicketReservation system = new TicketReservation();

        system.AddTicket(1, "Aman", "Inception", 12, "10:00 AM");
        system.AddTicket(2, "Ravi", "Avatar", 15, "10:15 AM");
        system.AddTicket(3, "Neha", "Inception", 18, "10:30 AM");

        Console.WriteLine("All Tickets:");
        system.DisplayTickets();

        Console.WriteLine("Search by Movie:");
        system.SearchByMovie("Inception");

        system.RemoveTicket(2);

        Console.WriteLine("After Removal:");
        system.DisplayTickets();

        Console.WriteLine("Total Tickets: " + system.GetTotalTickets());
    }
}
