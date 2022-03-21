using HeadFirstFactoryPatternSample.Abstractions;

namespace HeadFirstFactoryPatternSample.PizzaKinds.NYStyleKinds
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza() : base("NY style sauce and Cheese Pizza", "Thin Crust Dough", "Marinara sauce") { }
    }
}
