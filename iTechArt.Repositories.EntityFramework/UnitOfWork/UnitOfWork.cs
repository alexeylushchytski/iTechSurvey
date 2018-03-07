﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTechArt.Repositories.EntityFramework.Interfaces;
using iTechArt.Repositories.EntityFramework.Repository;
using iTechArt.Repositories.Interfaces;

namespace iTechArt.Repositories.EntityFramework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _dbContext;


        public UnitOfWork(IDbContext dbConnection)
        {
            _dbContext = dbConnection;
        }


        public UnitOfWork() { }


        public async Task<int>  CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }


        public void Dispose()
        {
            _dbContext.Dispose();
        }


        public virtual IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(_dbContext);
        }
    }
}