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
    internal class ClientRepository : IRepository<Client>
    {
        private readonly ApplicationDbContext _dbContext;

        public ClientRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //CREATE
        public bool Add(Client entity)
        {
            _dbContext.Clients.Add(entity);
            int nb =  _dbContext.SaveChanges();
            return (nb > 0);    
        }

        //READ
        public Client? Get(int id)
        {
            if (id == 0) return null;
            Client client = _dbContext.Clients.Find(id)!;
            return client; 
        }
        public Client? Get(Expression<Func<Client, bool>> predicate)
        {
            if (predicate == null) return null;
            Client client = _dbContext.Clients.FirstOrDefault(predicate)!;
            return client;
        }
        public List<Client> GetAll()
        {
            List<Client> listClients = _dbContext.Clients.ToList();
            return listClients;
        }
        public List<Client> GetAll(Expression<Func<Client, bool>> predicate)
        {
            List<Client> listClients = _dbContext.Clients.Where(predicate).ToList();
            return listClients;
        }

        // UPDATE
        public bool Update(Client entity)
        {
            var clientToUpdate = Get(entity.Id); 
            if (clientToUpdate == null) return false;
            _dbContext.Clients.Update(clientToUpdate);
            return (_dbContext.SaveChanges() > 0);
        }
        //DELETE
        public bool Delete(Client entity)
        {
            var clientToDelete = Get(entity.Id);
            if (clientToDelete == null) return false;
            _dbContext.Clients.Remove(clientToDelete);  
            return (_dbContext.SaveChanges() > 0);    
        }

    }
}
