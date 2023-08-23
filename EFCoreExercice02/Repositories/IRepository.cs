using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice02.Repositories
{
    /// <summary>
    /// Interface de définition des méthodes de repository pour une entité
    /// </summary>
    /// <typeparam name="TEntity">Type de l'entité BD sur laquelle on appliquera le CRUD</typeparam>
    internal interface IRepository<TEntity>
    {
        //CREATE
        /// <summary>
        /// ajout d'une entitée en BD
        /// </summary>
        /// <param name="entity">Entité à modifier</param>
        /// <returns>bool vrai ou faux si insertion de l'entité OK</returns>
        bool Add(TEntity entity);

        //READ
        TEntity? Get(int id);
        TEntity? Get(Expression<Func<TEntity, bool>> predicate);//repository.Get(e => e.qqch == "qqch"
        List<TEntity> GetAll(); 
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);

        //UPDATE
        /// <summary>
        /// modif d'une entité en BD
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>bool vrai ou faux si mise à jour OK</returns>
        //bool Update(int IdEntity, TEntity entity); // Autre signature possible 
        bool Update(TEntity entity);    
        
        //DELETE
        /// <summary>
        /// suppression de l'entité
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>bool vrai ou faux si suppression de l'entité OK</returns>
        bool Delete(TEntity entity);    
    }
}
