class calculator
{
	static void Main(string[] args)
	{
		int a = 10;
            int b = 6;

            Console.WriteLine("hasil penambahan" + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            

            Console.WriteLine("\ntekan sembarang key untuk keluar");
            Console.ReadKey();
	}
	
	static int penambahan(int a, int b)
	{
		return a + b;
	}
	
	static int pengurangan(int a, int b)
	{
		return a - b;
	}
	
	
}