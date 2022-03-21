using HeadFirstFactoryPatternSample.Abstractions;

namespace HeadFirstFactoryPatternSample.PizzaKinds
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza() : base("pepperoni", "dough", "sauce") { }
    }
}
