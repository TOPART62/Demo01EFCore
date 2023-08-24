using EFCoreExercice02.Data;
using EFCoreExercice02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice02.Repositories
{
    internal class BookingRoomRepository : IRepository<BookingRoom>
    {
        private readonly ApplicationDbContext _dbContext;

        public BookingRoomRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //CREATE
        public bool Add(BookingRoom entity)
        {
            _dbContext.BookingRooms.Add(entity);
            _dbContext.SaveChanges();
            return ((entity.BookingId > 0) && (entity.RoomId > 0));
        }

        //READ
        public BookingRoom? GetById(int id)
        {
            if (id == 0) 
                return null;
            BookingRoom bookingRoom = _dbContext.BookingRooms.Find(id)!;
            return bookingRoom;
        }
        public BookingRoom? Get(Expression<Func<BookingRoom, bool>> predicate)
        {
            if (predicate == null) 
                return null;
            BookingRoom bookingRoom = _dbContext.BookingRooms.FirstOrDefault(predicate)!;
            return bookingRoom;
        }
        public List<BookingRoom> GetAll()
        {
            List<BookingRoom> listBookingRooms = _dbContext.BookingRooms.ToList();
            return listBookingRooms;
        }
        public List<BookingRoom> GetAll(Expression<Func<BookingRoom, bool>> predicate)
        {
            List<BookingRoom> listBookingRooms = _dbContext.BookingRooms.Where(predicate).ToList();
            return listBookingRooms;
        }

        // UPDATE
        public bool Update(BookingRoom entity)
        {
            var bookingRoomToUpdate = GetById(entity.Id);
            if (bookingRoomToUpdate == null) return false;
            _dbContext.BookingRooms.Update(bookingRoomToUpdate);
            return (_dbContext.SaveChanges() > 0);
        }
        //DELETE
        public bool Delete(BookingRoom entity)
        {
            var bookingRoomToDelete = GetById(entity.Id);
            if (bookingRoomToDelete == null) return false;
            _dbContext.BookingRooms.Remove(bookingRoomToDelete);
            return (_dbContext.SaveChanges() > 0);
        }
    }
}