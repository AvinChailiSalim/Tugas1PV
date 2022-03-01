/*
 * Created by SharpDevelop.
 * User: XTS
 * Date: 3/1/2022
 * Time: 10:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tugas1._
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Nama kamu siapa?");
			
			string nama = Console.ReadLine();
			Console.WriteLine("Nama kamu "+nama);
		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}