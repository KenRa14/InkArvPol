using InkArvPol.Arv;
using InkArvPol.Inkapsling;
using InkArvPol.Polymorfism;

namespace InkArvPol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            3.3) Arv
              13. Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
                  attribute, i vilken klass bör vi lägga det?
      
                  Bird class.

              14. Om alla djur behöver det nya attributet, vart skulle man lägga det då?
        
                  Animal class.

            3.4) Mer polymorfism
              9. Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
      
                 A Horse can't be converted to a Dog. It's a horse, not a dog. Although both inherit from Animal,
                 Dog could've added a lot more, which Horse may or may not have.

              10. Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
        
                  That depends. is it about the recently created classes or any class? if It's the first one,
                  Animal. If it's the second one, Object.

              13. Förklara vad det är som händer
        
                  Every subclas calls the base class Stats method first to get all of the inherited properties as string and
                  append the new properties, if any, to the end of the string.

              16. Kommer du åt den metoden från Animals listan? Varför inte?
                  
                  No. In no place inside Animal was declared that an animal could do such a thing.
                  Even if we are sure that that animal is a dog, the compiler doesn't known. It would be
                  necessary to tell it that the animal is a dog through casting.
            */

            /*Inkapsling()  writes nothing to console*/
            //Inkapsling();

            //Polymorfism();

            /*Arv() is empty*/
            //Arv();

            MerPolymorfism();
        }

        static void Inkapsling()
        {
            //try
            //{
            //    Person person = new("Via", "Num");
            //    person.Age = 20;

            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            PersonHandler handler = new PersonHandler();
            Person person = handler.CreatePerson(10, "via", "Num", 20, 30);
        }

        static void Polymorfism()
        {
            //List<UserError> list = new() { new NumericInputError(), new TextInputError(), new TextInputError(), new TextInputError(),
            //                                new NumericInputError(), new TextInputError(), new TextInputError(), new NumericInputError(),
            //                                new NumericInputError(), new NumericInputError(), new TextInputError(), new TextInputError(),
            //                                new NumericInputError(), new NumericInputError(), new NumericInputError(), new TextInputError(),
            //                                new NumericInputError(), new NumericInputError(), new TextInputError(), new NumericInputError(),
            //                                new TextInputError(), new NumericInputError(), new TextInputError(), new NumericInputError(),
            //                                new NumericInputError() };

            //foreach (var userError in list)
            //{
            //    Console.WriteLine(userError.UEMessage());
            //}

            List<UserError> list = new() { new DateInputError(), new NegativeNumericInputError(), new DateInputError(), new DateInputError(),
                                            new NegativeNumericInputError(), new NegativeNumericInputError(), new EmailInputError(), new DateInputError(),
                                            new NegativeNumericInputError(), new NegativeNumericInputError(), new EmailInputError(), new EmailInputError(),
                                            new DateInputError(), new EmailInputError(), new EmailInputError(), new DateInputError(),
                                            new NegativeNumericInputError(), new NegativeNumericInputError(), new NegativeNumericInputError(), new EmailInputError(),
                                            new DateInputError(), new DateInputError(), new EmailInputError(), new NegativeNumericInputError(),
                                            new DateInputError(), new DateInputError(), new DateInputError(), new DateInputError(),
                                            new DateInputError(), new DateInputError(), new NegativeNumericInputError(), new NegativeNumericInputError(),
                                            new DateInputError(), new DateInputError(), new NegativeNumericInputError(), new DateInputError() };

            foreach (var userError in list)
            {
                Console.WriteLine(userError.UEMessage());
            }
        }

        static void Arv()
        {
            throw new NotImplementedException("No implementation requested for Program class in Övning 3a");
        }

        static void MerPolymorfism()
        {
            Console.WriteLine("Animals:");
            List<Animal> animals = GetAnimalList();

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"  {animal.GetType().Name}");
                Console.Write("    sound: ");
                animal.DoSound();
                if (animal is IPerson person)
                {
                    Console.Write("    Talk: ");
                    person.Talk();
                }
                //Console.WriteLine($"    Stats: {animal.Stats()}");
                if (animal is Dog dog)
                {
                    Console.WriteLine($"    Stats: {animal.Stats()}");
                    Console.WriteLine($"    {dog.Name}.{nameof(dog.WriteNovel)}(): {dog.WriteNovel()}");
                }
            }

            List<Dog> dogs = new();
            //dogs.Add(new Horse() { Name = "Vanechka", Age = 43, Weight = 173.06F, CoatColor = "Brown" });
        }

        //1 of each. 30 Animals including a wolfman
        static List<Animal> GetAnimalList()
        {
            return new() { new Swan(){ Name = "Porteur", Age = 30, Weight = 119.45F, WingSpan = 18.69F, SwanProperty = "Random 84" },
                            new Pelican(){ Name = "Pavel", Age = 2, Weight = 144.03F, WingSpan = 1.70F, PelicanProperty = "Random 44" },
                            new Pelican(){ Name = "Rosenda", Age = 23, Weight = 208.80F, WingSpan = 19.32F, PelicanProperty = "Random 62" },
                            new Swan(){ Name = "Salvador", Age = 22, Weight = 138.39F, WingSpan = 11.59F, SwanProperty = "Random 97" },
                            new Horse(){ Name = "Sofía", Age = 6, Weight = 161.44F, CoatColor = "Black" },
                            new Bird(){ Name = "Hernán", Age = 14, Weight = 36.63F, WingSpan = 3.10F },
                            new Wolfman(){ Name = "Paulino", Age = 45, Weight = 48.65F, EmotionalState = "aesthetic experience" },
                            new Bird(){ Name = "Saeth", Age = 10, Weight = 46.24F, WingSpan = 1.61F },
                            new Horse(){ Name = "Aristóteles", Age = 33, Weight = 120.70F, CoatColor = "Chestnut" },
                            new Flamingo(){ Name = "Irupé", Age = 28, Weight = 68.67F, WingSpan = 9.88F, FlamingoPropery = "Random 15" },
                            new Dog(){ Name = "Delicia", Age = 35, Weight = 91.07F, HasBasicComputerSkills = false },
                            new Hedgehog(){ Name = "Fiore", Age = 10, Weight = 60.91F, NrOfSpikes = 40 },
                            new Dog(){ Name = "Esterina", Age = 4, Weight = 47.41F, HasBasicComputerSkills = true },
                            new Dog(){ Name = "Flavio", Age = 28, Weight = 124.19F, HasBasicComputerSkills = false },
                            new Bird(){ Name = "Teodomira", Age = 38, Weight = 46.36F, WingSpan = 3.52F },
                            new Bird(){ Name = "Roquelia", Age = 49, Weight = 77.45F, WingSpan = 8.95F },
                            new Bird(){ Name = "Fedya", Age = 21, Weight = 103.01F, WingSpan = 16.95F },
                            new Dog(){ Name = "Celia", Age = 36, Weight = 129.80F, HasBasicComputerSkills = false },
                            new Pelican(){ Name = "Fedora", Age = 48, Weight = 140.61F, WingSpan = 11.33F, PelicanProperty = "Random 2" },
                            new Pelican(){ Name = "Octavia", Age = 41, Weight = 118.23F, WingSpan = 13.37F, PelicanProperty = "Random 35" },
                            new Pelican(){ Name = "Porter", Age = 8, Weight = 104.38F, WingSpan = 9.68F, PelicanProperty = "Random 15" },
                            new Dog(){ Name = "Eleonor", Age = 11, Weight = 179.06F, HasBasicComputerSkills = false },
                            new Worm(){ Name = "Adiv", Age = 40, Weight = 202.45F, IsPoisonous = true },
                            new Hedgehog(){ Name = "Haji", Age = 6, Weight = 101.15F, NrOfSpikes = 31 },
                            new Horse(){ Name = "Sonya", Age = 15, Weight = 101.96F, CoatColor = "Bay" },
                            new Flamingo(){ Name = "Etaina", Age = 42, Weight = 82.78F, WingSpan = 2.35F, FlamingoPropery = "Random 92" },
                            new Horse(){ Name = "Lisa", Age = 20, Weight = 51.62F, CoatColor = "Brown" },
                            new Wolf(){ Name = "Vanessa", Age = 5, Weight = 74.27F, EmotionalState = "jealousy" },
                            new Swan(){ Name = "Uzziel", Age = 30, Weight = 109.87F, WingSpan = 15.83F, SwanProperty = "Random 87" },
                            new Hedgehog(){ Name = "Najor", Age = 30, Weight = 122.43F, NrOfSpikes = 47 } };
        }
    }
}