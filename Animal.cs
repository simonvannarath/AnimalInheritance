using System;

namespace Animal_Inheritance
{
	class Animal
	{
		protected string greeting;

		static void Main(string[] args)
		{
			Animal newAnimal = new Animal();
			Console.WriteLine(newAnimal.Talk());
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

}
