﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Abstract
{
   public interface IDisplayEntity
    {
        public int DisplayOrder { get; set; }
        public bool IsDisplay { get; set; }
    }
}