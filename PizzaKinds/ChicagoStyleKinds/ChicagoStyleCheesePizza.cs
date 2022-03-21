using HeadFirstFactoryPatternSample.Abstractions;

namespace HeadFirstFactoryPatternSample.PizzaKinds.NYStyleKinds
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza() : base("Chicago style sauce and Cheese Pizza", "Thin Crust Dough", "Marinara sauce") { }
    }
}
