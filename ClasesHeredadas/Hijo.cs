using System;

namespace ClasesHeredadas
{
	public class Hijo : Padre
	{
		public Hijo (string ojos)
			:base(ojos)
		{
		}
		public  void Ojos(){
			Console.WriteLine ("Los ojos son verdes");
		}
	}
}

