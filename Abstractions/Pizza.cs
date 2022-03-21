namespace HeadFirstFactoryPatternSample.Abstractions
{
    public abstract class Pizza
    {
        private readonly string _name;
        private readonly string _dough;
        private readonly string _sauce;

        public Pizza(string name, string dough, string sauce)
        {
            _name = name;
            _dough = dough;
            _sauce = sauce;
        }

        public string GetName() => _name;

        public void Prepare()
        {
            Console.WriteLine($"Preparing {_name}");
            Console.WriteLine($"Tossing {_dough}");
            Console.WriteLine($"Adding {_sauce}");
        }

        public void Bake() => Console.WriteLine("Pizza Baked");

        public void Cut() => Console.WriteLine("Pizza Cuted");

        public void Box() => Console.WriteLine("Pizza Boxed");
    }
}
