using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    // enum for day type
    enum DayType
    {
        Weekday,
        Weekend
    }

    // record for book
    public record Book(string Title, string Author, double Price);
}
