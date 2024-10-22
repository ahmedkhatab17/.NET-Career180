
//namespace:
///logical grouping for related Dt with each other
///to achieve identity

namespace BookRead
{
Dt Book
{
    Isbn
    name
    author
    date
}
}

namespace BookTicket
{
DT Book
{
    TicketNo
    PassengerName
    From
    To
}
}

using namespace BookRead;
entrypoint()
{
    Book b1;
    Book b11;
    Book b111;
    Book b11111;
    Book b111111;
    BookTicket.Book b2;
}


