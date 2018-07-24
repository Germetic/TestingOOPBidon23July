using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class MilkDecorator : CoffeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
            _description = "Milk";
            _price = 4;
        }
    }
}
