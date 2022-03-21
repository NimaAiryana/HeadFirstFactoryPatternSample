using HeadFirstFactoryPatternSample.Abstractions;
using HeadFirstFactoryPatternSample.PizzaKinds.NYStyleKinds;

namespace HeadFirstFactoryPatternSample.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string whatKindOfPizza) =>
            whatKindOfPizza switch
            {
                "Cheese" => new NYStyleCheesePizza(),

                "Pepperoni" => new NYStylePepperoniPizza(),

                _ => new NYStyleSpecialPizza()
            };

    }
}
