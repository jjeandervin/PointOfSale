﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Entity
{
    public interface IProductCodeProvider
    {
        int GenerateNew();
    }
}
