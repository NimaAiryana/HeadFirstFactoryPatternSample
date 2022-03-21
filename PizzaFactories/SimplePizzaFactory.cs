using HeadFirstFactoryPatternSample.Abstractions;
using HeadFirstFactoryPatternSample.PizzaKinds;

namespace HeadFirstFactoryPatternSample.PizzaFactories
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string whatKindOfPizza) =>
            whatKindOfPizza switch
            {
                "Cheese" => new CheesePizza(),

                "Pepperoni" => new PepperoniPizza(),

                _ => new SpecialPizza()
            };
    }
}
