using Arinna.DDD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Domain.Aggregate.OrderAggregate
{
    public class OrderShipDetail : ValueObject
    {
        public OrderShipDetail() { }

        public OrderShipDetail(string shipName, string shipAddress, string shipCity, string shipRegion, string shipPostalCode, string shipCountry)
        {
            ShipName = shipName;
            ShipAddress = shipAddress;
            ShipCity = shipCity;
            ShipRegion = shipRegion;
            ShipPostalCode = ShipPostalCode;
            ShipCountry = shipCountry;
        }

        public string ShipName { get; private set; }
        public string ShipAddress { get; private set; }
        public string ShipCity { get; private set; }
        public string ShipRegion { get; private set; }
        public string ShipPostalCode { get; private set; }
        public string ShipCountry { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return ShipName;
            yield return ShipAddress;
            yield return ShipCity;
            yield return ShipRegion;
            yield return ShipPostalCode;
            yield return ShipCountry;
        }
    }
}
