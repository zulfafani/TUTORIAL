//For choose between different OS

#define WINDOWS

class Program {
	static void Main() {
		#if WINDOWS
		Console.WriteLine("Windows.");
		#elif LINUX
		Console.WriteLine("Linux.");
		#else
		Console.WriteLine("Not anything.");
		#endif
	}
}
