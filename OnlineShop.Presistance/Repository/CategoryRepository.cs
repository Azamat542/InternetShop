﻿using OnlineShop.Application.Interfaces;
using OnlineShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Presistance.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(Category category)
        {
            _appDbContext.Categories.Add(category);
            _appDbContext.SaveChanges();
        }
    }
}
