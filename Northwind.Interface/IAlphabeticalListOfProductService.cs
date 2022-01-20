﻿using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IAlphabeticalListOfProductService : IGenericService<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>
    {
        IQueryable AlphabeticalListOfProductReport();
    }
}