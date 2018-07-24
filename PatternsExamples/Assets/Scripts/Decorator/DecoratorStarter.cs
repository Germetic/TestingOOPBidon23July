using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class DecoratorStarter : MonoBehaviour
    {

        public bool IsShowOnStart;
        ICoffee _coffeeWithMilkAndChocolate = new ChocolateDecorator(new MilkDecorator(new CoffeBase()));
        ICoffee _coffeeWithMilk = new MilkDecorator(new CoffeBase());

        private void Start()
        {
            if (!IsShowOnStart) return;

            Debug.Log("<color=brown><b> DECORATOR START </b></color>");

            Debug.Log(_coffeeWithMilkAndChocolate.GetDescription() + "| price : " +
            _coffeeWithMilkAndChocolate.GetPrice());



            Debug.Log(_coffeeWithMilk.GetDescription() + "| price : " +
            _coffeeWithMilk.GetPrice());

            Debug.Log("<color=brown><b> DECORATOR FINISH </b></color>");
        }

    }
}
