using System;

namespace Animal_Inheritance
{
	class Animal
	{
		protected string greeting;

		static void Main(string[] args)
		{
			Animal cat = new Cat();
			Animal dog = new Dog();
			Animal bird = new Bird();
			Animal sheep = new Sheep();
			Animal pig = new Pig();
			Animal cow = new Cow();
			Animal horse = new Horse();
			Animal fish = new Fish();
			Animal lion = new Lion();
			Animal bee = new Bee();
			Animal frog = new Frog();
			Animal duck = new Duck();
			Animal jfish = new Jellyfish();
			Animal lad = new Lad();
			Animal owen = new Owen();

			Console.WriteLine(cat.Talk());
			Console.WriteLine(dog.Talk());
			Console.WriteLine(bird.Talk());
			Console.WriteLine(sheep.Talk());
			Console.WriteLine(pig.Talk());
			Console.WriteLine(cow.Talk());
			Console.WriteLine(horse.Talk());
			Console.WriteLine(fish.Talk());
			Console.WriteLine(lion.Talk());
			Console.WriteLine(bee.Talk());
			Console.WriteLine(frog.Talk());
			Console.WriteLine(duck.Talk());
			Console.WriteLine(jfish.Talk());
			Console.WriteLine(lad.Talk());
			Console.WriteLine(owen.Talk());

			Console.ReadLine();
		}

		public Animal()
		{
			greeting = "I am an Animal";
		}

		public Animal(string _greeting)
		{
			greeting = _greeting;
		}

		public string Talk()
		{
			return greeting;
		}
	}

	class Vertebrate : Animal
	{
		public Vertebrate(string _greeting) : base(_greeting)
		{
			greeting += " I am a vertebrate.";
		}
	}

	class Invertebrate : Animal
	{
		public Invertebrate(string _greeting) : base(_greeting)
		{
			greeting += " I am an invertebrate. ";
		}
	}

	class Cat : Vertebrate
	{
		public Cat() : base("I am a Cat")
		{
			greeting += " Meow!";
		}
	}

	class Dog : Vertebrate
	{
		public Dog() : base("I am a Dog")
		{
			greeting += " Bark!";
		}
	}

	class Bird : Vertebrate
	{
		public Bird() : base("I am a Bird")
		{
			greeting += " Chirp!";
		}
	}

	class Sheep : Vertebrate
	{
		public Sheep() : base("I am a Sheep")
		{
			greeting += " Baa!";
		}
	}

	class Pig : Vertebrate
	{
		public Pig() : base("I am a Pig")
		{
			greeting += " Oink!";
		}
	}

	class Cow : Vertebrate
	{
		public Cow() : base("I am a Cow")
		{
			greeting += " Moo!";
		}
	}

	class Horse : Vertebrate
	{
		public Horse() : base("I am a Horse")
		{
			greeting += " Neigh!";
		}
	}

	class Fish : Vertebrate
	{
		public Fish() : base("I am a Fish")
		{
			greeting += " Bloop!";
		}
	}

	class Lion : Vertebrate
	{
		public Lion() : base("I am a Lion")
		{
			greeting += " Roar!";
		}
	}

	class Bee : Invertebrate
	{
		public Bee() : base("I am a Bee")
		{
			greeting += " Bzzz!";
		}
	}

	class Frog : Vertebrate
	{
		public Frog() : base("I am a Frog")
		{
			greeting += " Ribbit!";
		}
	}

	class Duck : Vertebrate
	{
		public Duck() : base("I am a Duck")
		{
			greeting += " Quack!";
		}
	}

	class Jellyfish : Invertebrate
	{
		public Jellyfish() : base("I am a Jellyfish")
		{
			greeting += " ...";
		}
	}

	class Lad : Invertebrate
	{
		public Lad() : base("I am a Lad")
		{
			greeting += " U wot kient?!";
		}
	}

	class Owen : Vertebrate
	{
		public Owen() : base("I am Owen")
		{
			greeting += " Waaaaowww!";
		}
	}
}
