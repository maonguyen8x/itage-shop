﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CommonModels.SalesModule
{
    public class OrderVariantDetail
    {


        public int OrderAttributeMappingID { get; set; }
        public int ProductAttributeID { get; set; } 
        public int OrderItemID { get; set; }
        public int PrimaryKeyValue { get; set; }
        public string? PrimaryKeyDisplayText { get; set; }
        public string? AttributeDisplayName { get; set; }
        public string? AttributeSqlTableName { get; set; }

        public int TotalRecords { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }

        public int? DataExportType { get; set; }
        public int PageNo { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int? LoginUserId { get; set; }
    }
}
