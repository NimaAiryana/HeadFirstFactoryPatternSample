using HeadFirstFactoryPatternSample.Abstractions;

namespace HeadFirstFactoryPatternSample.PizzaKinds
{
    public class CheesePizza : Pizza
    {
        public CheesePizza() : base("cheese", "dough", "sauce") { }
    }
}
