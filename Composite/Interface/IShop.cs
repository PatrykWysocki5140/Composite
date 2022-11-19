﻿using Composite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Interface
{
    public interface IShopFunctions
    {
        void Add(ShopMain gift);
        void Remove(ShopMain gift);
    }
}
