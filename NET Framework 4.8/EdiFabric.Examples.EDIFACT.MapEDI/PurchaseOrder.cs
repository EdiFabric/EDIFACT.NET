using System;
using System.Collections.Generic;

namespace EdiFabric.Examples.EDIFACT.MapEDI
{
    public class PurchaseOrder
    {
        public string RefNumber { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string RefNumber { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
    }

    public class OrderLine
    {
        public string LineNumber { get; set; }
        public string UPCNumber { get; set; }
        public decimal Quantity { get; set; }
        public float Price { get; set; }
        public string UOM { get; set; }
    }
}
