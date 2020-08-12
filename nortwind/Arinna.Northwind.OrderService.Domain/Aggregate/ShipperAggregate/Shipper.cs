using Arinna.Data;
using Arinna.DDD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Domain.Aggregate.ShipperAggregate
{
    public class Shipper : Entity<int>, IAggregateRoot, IDeletableEntity
    {
        public Shipper() { }
        public Shipper(int id, string companyName, string phone)
        {
            Id = id;
            CompanyName = companyName;
            Phone = phone;
        }

        public string CompanyName { get; private set; }
        public string Phone { get; private set; }
        public bool IsDeleted { get; set; }

        public Shipper UpdateShipper(string companyName, string phone)
        {
            CompanyName = companyName;
            Phone = phone;

            return this;
        }
    }
}
