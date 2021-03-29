using RoomBooking.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Domain.Entities
{
    public class Room
    {
        public Room(DateTime startDate, DateTime endDate, string title)
        {
            AssertionConcern.AssertArgumentNotNull(startDate, "Horário de início inválido");
            AssertionConcern.AssertArgumentNotNull(endDate, "Horário de término inválido");
            AssertionConcern.AssertArgumentLength(title, 3, 40, "O nome da sala deve conter entre 3 e 40 caracteres");

            Id = Guid.NewGuid();
            StartDate = startDate;
            EndDate = endDate;
            Title = title;
        }
        public Guid Id { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Title { get; private set; }
    }
}
