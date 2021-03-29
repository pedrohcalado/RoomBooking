using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Domain.Contracts.Services
{
    public interface IBookService : IDisposable
    {
        // Orquestra a reserva de uma sala
        // recupera usuário
        // recupera sala
        // tenta efetuar a reserva
        // notifica o usuario
        void PlaceBook(DateTime startDate, DateTime endDate, Guid room);
    }
}
