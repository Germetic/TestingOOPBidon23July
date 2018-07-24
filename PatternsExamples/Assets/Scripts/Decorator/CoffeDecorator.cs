using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class CoffeDecorator : ICoffee
    {
        ICoffee _coffee;
        protected int _price;
        protected string _description;

        public string GetDescription()
        {
            return _coffee.GetDescription() + " , " + _description;
        }

        public int GetPrice()
        {
            return _coffee.GetPrice() + _price;
        }
        public CoffeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }
    }
}
