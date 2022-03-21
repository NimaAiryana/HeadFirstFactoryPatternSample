using HeadFirstFactoryPatternSample.Abstractions;

namespace HeadFirstFactoryPatternSample.PizzaKinds.NYStyleKinds
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza() : base("chicago style pepperoni", "dough", "sauce") { }
    }
}
