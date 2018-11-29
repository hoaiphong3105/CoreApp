﻿using System;
using System.Collections.Generic;
using System.Text;
using CoreApp.Data.Entities;
using CoreApp.Infrastructure.Interfaces;

namespace CoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
