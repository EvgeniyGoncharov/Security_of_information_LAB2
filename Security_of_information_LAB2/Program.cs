using System;
using System.IO;
using System.Numerics;
using System.Text;

namespace LAB2
{
	class Program
	{
		static void Main(string[] args)
		{
			var rand = new Random();
			int p = 13;
			int q = 17;
			int n = p * q;
			int f = (p - 1) * (q - 1);
			int e = 23;
			int k = 1;
			double d0 = 0;
			int d = 0;

			while (true)
			{
				d0 = ((double) k * f + 1) / (double) e;
				Console.WriteLine("d0= " + d0);
				if ( d0 == (int) d0)
				{
					d = (int) d0;
					break;
				}
				k++;
			}
			Console.WriteLine("char(8): " + (char)56);
			Console.WriteLine("p= " + p);
			Console.WriteLine("q= " + q);
			Console.WriteLine("n= " + n);
			Console.WriteLine("f= " + f);
			Console.WriteLine("e= " + e);
			Console.WriteLine("k= " + k);
			Console.WriteLine("d= " + d);
			Console.WriteLine("(k * f + 1) / e = " + (k * f + 1) / e);

			Console.WriteLine("Введите шифруемое сообщение: ");
			string message = Console.ReadLine();

			BigInteger[] int_message = new BigInteger[message.Length];
			BigInteger[] int_coded_message = new BigInteger[message.Length];
			BigInteger[] int_uncoded_message = new BigInteger[message.Length];


			for (int i = 0; i < message.Length; i++)
			{
				int_message[i] = message[i] - '0';
				int_coded_message[i] = BigInteger.Pow(int_message[i],e) % n;
				int_uncoded_message[i] = BigInteger.Pow(int_coded_message[i], d) % n;
				Console.WriteLine(message[i] + " - " + int_message[i] + " - " + int_coded_message[i] + " - " + Convert.ToChar((int)int_uncoded_message[i] + '0'));
			}

		}
	}
}