﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTutorial
{
    public interface IProductRepository
    {
        IEnumerable<Product> FindAll();
    }
}
