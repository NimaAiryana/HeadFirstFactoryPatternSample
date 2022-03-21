using HeadFirstFactoryPatternSample.Abstractions;
using HeadFirstFactoryPatternSample.PizzaKinds.NYStyleKinds;

namespace HeadFirstFactoryPatternSample.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string whatKindOfPizza) =>
            whatKindOfPizza switch
            {
                "Cheese" => new ChicagoStyleCheesePizza(),

                "Pepperoni" => new ChicagoStylePepperoniPizza(),

                _ => new ChicagoStyleSpecialPizza()
            };
    }
}
