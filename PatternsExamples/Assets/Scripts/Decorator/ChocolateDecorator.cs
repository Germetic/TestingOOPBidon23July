using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class ChocolateDecorator : CoffeDecorator
    {
        public ChocolateDecorator(ICoffee coffee) : base(coffee)
        {
            _description = "Chocolate";
            _price = 5;
        }
    }
}
