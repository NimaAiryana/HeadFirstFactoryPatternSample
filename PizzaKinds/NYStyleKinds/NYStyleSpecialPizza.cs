using HeadFirstFactoryPatternSample.Abstractions;

namespace HeadFirstFactoryPatternSample.PizzaKinds.NYStyleKinds
{
    public class NYStyleSpecialPizza : Pizza
    {
        public NYStyleSpecialPizza() : base("NY style special", "dough", "sauce") { }
    }
}
