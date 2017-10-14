/* NSI TAFE St Leonards Cert IV Digital and Interactive Games (Programming) *
 * Learner :        Simon Vannarath                                         *
 * Trainer/Class :  Manny Vaccaro - Object Oriented Programming             *
 *                                                                          *
 * WEEK 1 CHALLENGE - "Inheritance"                                         *
 * Due Date:          17 October 2017                                       *
 */


using System;

namespace Animal_Inheritance
{
	//---- Base Class --------
	class Animal
	{
		protected string greeting;

		static void Main(string[] args)
		{
			Animal cat = new Cat();
			Animal dog = new Dog();
			Animal robin= new Robin();
			Animal sheep = new Sheep();
			Animal pig = new Pig();
			Animal cow = new Cow();
			Animal horse = new Horse();
			Animal gfish = new Goldfish();
			Animal lion = new Lion();
			Animal bee = new Bee();
			Animal frog = new Frog();
			Animal duck = new Duck();
			Animal jfish = new Jellyfish();
			Animal lad = new Lad();
			Animal owen = new Owen();

			Console.WriteLine(cat.Talk());
			Console.WriteLine(dog.Talk());
			Console.WriteLine(robin.Talk());
			Console.WriteLine(sheep.Talk());
			Console.WriteLine(pig.Talk());
			Console.WriteLine(cow.Talk());
			Console.WriteLine(horse.Talk());
			Console.WriteLine(gfish.Talk());
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

//----- 1st Level derived classes (Animal > Vertebrate/Invertebrate)

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
			greeting += " I am an invertebrate.";
		}
	}

//----- 2nd Level derived classes (Animal > Vertebrate/Invertebrate > Mammal/Bird/etc.)

	class Mammal : Vertebrate
	{
		public Mammal(string _greeting) : base(_greeting)
		{
			greeting += " I am a mammal.";
		}
	}

	class Bird : Vertebrate
	{
		public Bird(string _greeting) : base(_greeting)
		{
			greeting += " I am a bird.";
		}
	}

	class Fish : Vertebrate
	{
		public Fish(string _greeting) : base(_greeting)
		{
			greeting += " I am a fish.";
		}
	}

	class Amphibian : Vertebrate
	{
		public Amphibian(string _greeting) : base(_greeting)
		{
			greeting += " I am an amphibian.";
		}
	}

	class Arthropod : Invertebrate
	{
		public Arthropod(string _greeting) : base(_greeting)
		{
			greeting += " I am an arthropod.";
		}
	}

	class Cnidarian : Invertebrate
	{
		public Cnidarian(string _greeting) : base(_greeting)
		{
			greeting += " I am a cnidarian.";
		}
	}

//----- 3rd Level derived classes

	class Cat : Mammal
	{
		public Cat() : base("I am a Cat")
		{
			greeting += " Meow!";
		}
	}

	class Dog : Mammal
	{
		public Dog() : base("I am a Dog")
		{
			greeting += " Bark!";
		}
	}

	class Robin : Bird
	{
		public Robin() : base("I am a Robin")
		{
			greeting += " Cheep!";
		}
	}

	class Sheep : Mammal
	{
		public Sheep() : base("I am a Sheep")
		{
			greeting += " Baa!";
		}
	}

	class Pig : Mammal
	{
		public Pig() : base("I am a Pig")
		{
			greeting += " Oink!";
		}
	}

	class Cow : Mammal
	{
		public Cow() : base("I am a Cow")
		{
			greeting += " Moo!";
		}
	}

	class Horse : Mammal
	{
		public Horse() : base("I am a Horse")
		{
			greeting += " Neigh!";
		}
	}

	class Goldfish : Fish
	{
		public Goldfish() : base("I am a Goldfish")
		{
			greeting += " Bloop!";
		}
	}

	class Lion : Mammal
	{
		public Lion() : base("I am a Lion")
		{
			greeting += " Roar!";
		}
	}

	class Bee : Arthropod
	{
		public Bee() : base("I am a Bee")
		{
			greeting += " Bzzz!";
		}
	}

	class Frog : Amphibian
	{
		public Frog() : base("I am a Frog")
		{
			greeting += " Ribbit!";
		}
	}

	class Duck : Bird
	{
		public Duck() : base("I am a Duck")
		{
			greeting += " Quack!";
		}
	}

	class Jellyfish : Cnidarian
	{
		public Jellyfish() : base("I am a Jellyfish")
		{
			greeting += " ...";
		}
	}

	class Lad : Mammal
	{
		public Lad() : base("I am a Lad")
		{
			greeting += " U wot kient?!";
		}
	}

	class Owen : Mammal
	{
		public Owen() : base("I am Owen")
		{
			greeting += " Waaaaowww!";
		}
	}
}
