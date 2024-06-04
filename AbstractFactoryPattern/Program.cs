namespace AbstractFactoryPattern
{
    public class Program
    {
        abstract class Burger { }
        abstract class Dessert { }
        abstract class RecipeFactory
        {
             public abstract Burger CreateBurger();
            public abstract Dessert CreateDesert();
        }
        class SteakBurger : Burger { }
        class CreamBluer : Dessert { }
        class AdultCuisineFactory : RecipeFactory
        {
            public override Burger CreateBurger()
            {
               return new SteakBurger();
            }

            public override Dessert CreateDesert()
            {
                return new CreamBluer();
            }
        }
        class KidBurger: Burger { }
        class IceCream: Dessert { }
        class KidCuisineFactory : RecipeFactory
        {
            public override Burger CreateBurger()
            {
                return new KidBurger();
            }

            public override Dessert CreateDesert()
            {
               return new IceCream();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("who are you!");
            Console.WriteLine("A ADULT");
            Console.WriteLine("K KID");
            char resul= Console.ReadKey().KeyChar;
            RecipeFactory factory = new AdultCuisineFactory();
            switch(resul)
            {
                case 'A':
                    factory = new AdultCuisineFactory();
                    break;
                case 'K':
                    break;
                default:
                    break;
            }
            var burger = factory.CreateBurger();
            var desert = factory.CreateDesert();
            Console.WriteLine("");
            Console.WriteLine("Burger: "+ burger.GetType().Name);
            Console.WriteLine("Dessert: "+ desert.GetType().Name);

        }
    }

}
