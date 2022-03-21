using HeadFirstFactoryPatternSample.Abstractions;

namespace HeadFirstFactoryPatternSample.PizzaKinds.NYStyleKinds
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza() : base("NY style pepperoni", "dough", "sauce") { }
    }
}
