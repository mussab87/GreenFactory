using System;
using System.Collections.Generic;

#nullable disable

namespace Service.DataLayer.ModelsNew
{
    public partial class ProductTbl
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public DateTime? CreatedStamp { get; set; }
        public string CreatedBy { get; set; }
    }
}
