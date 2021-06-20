using System;

namespace Practica
{
	/// <summary>
	/// Description of Comparable.
	/// </summary>
	public interface Comparable
	{
		bool sosIgual(Comparable obj);
		
		bool sosMenor(Comparable obj);
		
		bool sosMayor(Comparable obj);
		
		string informar();
	}
	
}
