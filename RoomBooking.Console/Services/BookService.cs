using RoomBooking.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Console.Services
{
    // Orquestra a reserva de uma sala
    // recupera sala
    // tenta efetuar a reserva
    // notifica o usuario
    public class BookService : IBookService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void PlaceBook(DateTime startDate, DateTime endDate, Guid room)
        {
            
        }
    }
}
