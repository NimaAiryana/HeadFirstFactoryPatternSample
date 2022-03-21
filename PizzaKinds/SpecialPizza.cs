using HeadFirstFactoryPatternSample.Abstractions;

namespace HeadFirstFactoryPatternSample.PizzaKinds
{
    public class SpecialPizza : Pizza
    {
        public SpecialPizza() : base("special", "dough", "sauce") { }
    }
}
