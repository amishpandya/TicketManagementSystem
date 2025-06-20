﻿using Domain.Repository;
using Infrastructure.Data;
using System.Collections;

namespace Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext context;
        private Hashtable repositories;

        public ITicketRepository TicketRepository { get; }
        public IDiscussionRepository DiscussionRepository { get; }

        public UnitOfWork(AppDBContext context, ITicketRepository ticketRepository, IDiscussionRepository discussionRepository)
        {
            this.context = context;
            TicketRepository = ticketRepository;
            DiscussionRepository = discussionRepository;
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
        public async Task<bool> SaveChangesReturnBool()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (repositories == null) repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), context);

                repositories.Add(type, repositoryInstance);
            }

            return (IGenericRepository<TEntity>)repositories[type];
        }
    }
}
