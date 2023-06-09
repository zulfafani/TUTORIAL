//Jika dirun pasti akan ke Debug
//dotnet build -c Release

#define PRODUCTION
class Program {
	static void Main() {
		#if (DEBUG)
		Console.WriteLine("Mode debug diaktifkan.");
		#elif (PRODUCTION)
		Console.WriteLine("Production mode aktif");
		#endif

		Console.WriteLine("Program berjalan...");
	}
}
