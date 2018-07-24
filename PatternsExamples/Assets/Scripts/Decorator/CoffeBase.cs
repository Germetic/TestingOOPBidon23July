using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class CoffeBase : ICoffee
    {

        public string GetDescription()
        {
            return "Espesso";
        }

        public int GetPrice()
        {
            return 12;
        }

    }
}
