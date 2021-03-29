using RoomBooking.Console.Repositories;
using RoomBooking.Console.Services;
using RoomBooking.Domain.Contracts.Repositories;
using RoomBooking.Domain.Contracts.Services;
using RoomBooking.Domain.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using Unity;
using Unity.Lifetime;

namespace RoomBooking.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //UnityContainer container = new UnityContainer();
            //container.RegisterType<IBookRepository, BookRepository>(new HierarchicalLifetimeManager());
            //container.RegisterType<IBookService, BookService>(new HierarchicalLifetimeManager());

            //var bookRepository = container.Resolve<IBookRepository>();
            //var bookService = container.Resolve<IBookService>();

            //var room = new Room(DateTime.Now, DateTime.Now.AddHours(8), "Sala 1");
            //// roomRepository.Get... ou vinda da tela do MVC

            //bookService.PlaceBook(DateTime.Now, DateTime.Now.AddHours(8), room.Id);

            
            //var book = new Book(room, DateTime.Now.AddHours(1), DateTime.Now.AddHours(2));

            //book.Cancel();

            // criar uma sala 
            var room = new Room(DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), "Sala 1");
            System.Console.WriteLine("Criando uma reserva");

            // iniciar uma reserva
            var book = new Book(room, DateTime.Now.AddHours(4), DateTime.Now.AddHours(4));
            System.Console.WriteLine("Iniciando uma reserva");

            // confirmar a reserva
            book.Confirm(new List<DateTime>(), new List<DateTime>());
            System.Console.WriteLine("Status da reserva: " + book.Status);

            // marcar como em progresso, o usuario chegou para usar a sala
            book.MarkAsInProgress();
            System.Console.WriteLine("Status da reserva: " + book.Status);

            // marca como completa, o usuario saiu da sala
            book.MarkAsCompleted();
            System.Console.WriteLine("Status da reserva: " + book.Status);
        }
    }
}
