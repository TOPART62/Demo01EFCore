using EFCoreExercice02.Data;
using EFCoreExercice02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice02.Repositories
{
    internal class BookingRepository : IRepository<Booking>
    {
        private readonly ApplicationDbContext _dbContext;

        public BookingRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Booking entity)
        {
            _dbContext.Bookings.Add(entity);
            return (_dbContext.SaveChanges() > 0);
        }

        public Booking? Get(Expression<Func<Booking, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetAll(Expression<Func<Booking, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Booking? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Booking entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Booking entity)
        {
            throw new NotImplementedException();
        }

    }

}
