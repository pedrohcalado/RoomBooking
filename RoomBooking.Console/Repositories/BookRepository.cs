using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomBooking.Domain.Contracts.Repositories;
using RoomBooking.Domain.Entities;

namespace RoomBooking.Console.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IList<Book> GetBooksByDateRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
