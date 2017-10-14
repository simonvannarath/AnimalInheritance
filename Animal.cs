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

			Console.WriteLine("A cat says: " + cat.Talk());
			Console.WriteLine("A dog says: " + dog.Talk());

			Console.ReadLine();
		}

		public Animal()
		{
			greeting = "Hello!";
		}

		public string Talk()
		{
			return greeting;
		}
	}

	class Cat : Animal
	{
		public Cat()
		{
			greeting = "Meow!";
		}
	}

	class Dog : Animal
	{
		public Dog()
		{
			greeting = "Bark!";
		}
	}

	class Bird : Animal
	{
		public Bird()
		{
			greeting = "Chirp!";
		}
	}

	class Sheep : Animal
	{
		public Sheep()
		{
			greeting = "Baa!";
		}
	}

	class Pig : Animal
	{
		public Pig()
		{
			greeting = "Oink!";
		}
	}

	class Cow : Animal
	{
		public Cow()
		{
			greeting = "Moo!";
		}
	}

	class Horse : Animal
	{
		public Horse()
		{
			greeting = "Neigh!";
		}
	}

	class Fish : Animal
	{
		public Fish()
		{
			greeting = "Bloop!";
		}
	}

	class Lion : Animal
	{
		public Lion()
		{
			greeting = "Roar!";
		}
	}

	class Bee : Animal
	{
		public Bee()
		{
			greeting = "Bzzz!";
		}
	}

	class Frog : Animal
	{
		public Frog()
		{
			greeting = "Ribbit!";
		}
	}

	class Duck : Animal
	{
		public Duck()
		{
			greeting = "Quack!";
		}
	}

	class Jellyfish : Animal
	{
		public Jellyfish()
		{
			greeting = "...";
		}
	}

	class Lad : Animal
	{
		public Lad()
		{
			greeting = "U wot kient?!";
		}
	}

	class Owen : Animal
	{
		public Owen()
		{
			greeting = "Waaaaowww!";
		}
	}
}
