﻿using STutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTutorial.Model
{
    public class DefaultPriceCalculator : IPriceCalculator
    {
        private readonly List<IPriceStrategy> _pricingRules;

        public DefaultPriceCalculator()
        {
            _pricingRules = new List<IPriceStrategy>();
            _pricingRules.Add(new PricePerKilogramStrategy());
            _pricingRules.Add(new PricePerUnitStrategy());
            _pricingRules.Add(new SpecialPriceStrategy());
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return _pricingRules.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}
