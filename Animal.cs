using System;

namespace Animal_Inheritance
{
	class Animal
	{
		protected string greeting;

		static void Main(string[] args)
		{
			Animal cat = new Cat();
			Console.WriteLine(cat.Talk());
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


}
