﻿using System;
using System.Collections.Generic;

namespace Entities.DBModels
{
    public partial class ProductsTagsMapping
    {
        public int ProductTagMappingId { get; set; }
        public int ProductId { get; set; }
        public int TagId { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Tag Tag { get; set; } = null!;
    }
}
