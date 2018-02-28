﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T>
        where T : IEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        T Get(Expression<Func<T, bool>> filter);
        ICollection<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
