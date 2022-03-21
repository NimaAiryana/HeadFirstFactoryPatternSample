using HeadFirstFactoryPatternSample.Abstractions;

namespace HeadFirstFactoryPatternSample.PizzaKinds.NYStyleKinds
{
    public class ChicagoStyleSpecialPizza : Pizza
    {
        public ChicagoStyleSpecialPizza() : base("chicago style special", "dough", "sauce") { }
    }
}
