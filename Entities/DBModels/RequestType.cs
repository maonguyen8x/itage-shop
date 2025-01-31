﻿using System;
using System.Collections.Generic;

namespace Entities.DBModels
{
    public partial class RequestType
    {
        public RequestType()
        {
            RequestsQueues = new HashSet<RequestsQueue>();
        }

        public int RequestTypeId { get; set; }
        public string RequestTypeName { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<RequestsQueue> RequestsQueues { get; set; }
    }
}
