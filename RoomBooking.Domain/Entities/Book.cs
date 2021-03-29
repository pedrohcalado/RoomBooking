using RoomBooking.Domain.Enums;
using RoomBooking.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Domain.Entities
{
    public class Book
    {
        public Book(
            Room room,
            DateTime startTime,
            DateTime endDate)
        {
            Room = room;
            StartTime = startTime;
            EndDate = endDate;
        }
        public Guid Id { get; set; }
        public Room Room { get; set; }
        public EBookStatus Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndDate { get; set; }

        public void Confirm(IList<DateTime> holidays, IList<DateTime> booksForThisPeriod)
        {
            // Verificar se data inicio está na lista de feriados
            // Verificar se data início está na lista de reservas
            //if (Status != EBookStatus.InProgress)
            //    throw new Exception("Erro");

            Status = EBookStatus.Reserved;
        }

        public void MarkAsInProgress()
        {
            Status = EBookStatus.InUse;
        }

        public void Cancel()
        {
            if ((StartTime - DateTime.Now).Hours < 2)
                throw new Exception("Error");

            Status = EBookStatus.Canceled;
        }

        public void MarkAsCompleted()
        {
            Status = EBookStatus.Completed;
        }

    }  
}
