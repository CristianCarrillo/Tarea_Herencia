using System;

namespace ClasesHeredadas
{
	public class Padre
	{
		 string ojos;
	


	public Padre(string ojos){
			this.ojos = ojos;
			}


	 void Ojos (){
			Hijo hijo = new Hijo ("verdes");
			hijo.Ojos ();
		}
		
		
			
		
		

public static void Main (string[] args)
		{
			Padre padre= new Padre("verdes");
			padre.Ojos ();
			Console.Read();
		}
	}
}
