using HeadFirstFactoryPatternSample.PizzaFactories;

namespace HeadFirstFactoryPatternSample.Abstractions
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string whatKindOfPizza)
        {
            Pizza pizza;

            pizza = CreatePizza(whatKindOfPizza);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string whatKindOfPizza);
    }
}
