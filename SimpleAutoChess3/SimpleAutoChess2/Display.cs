using System;
using SimpleAutoChess;

namespace SimpleAutoChess
{
	public static class Display
	{
		public static void InvalidNumberInfo()
		{
			Console.WriteLine("Invalid input. Please enter a valid number.");
		}
		public static void InvalidPlayerNameInfo()
		{
			Console.WriteLine("Name already exists. Please enter a different name.");
		}
		public static void InvalidUnitInfo()
		{
			Console.WriteLine("Race of unit not exists. Please enter the correct Race.");
		}

        public static void PlayerUnitInfo(Dictionary<string, List<UnitName>> playerUnits2, GameManager gameManager)
        {
            Console.WriteLine("\n--Player List--");
            int playerIndex = 1;
            foreach (var entry in playerUnits2)
            {
                string playerName = entry.Key;
                List<UnitName> units = entry.Value;

                Console.WriteLine($"Player {playerIndex}: {playerName}");
                Console.WriteLine($"Player ID: {gameManager.GenerateRandomId()}");

                Console.WriteLine("Units:");
                foreach (UnitName unit in units)
                {
                    Console.WriteLine($"Unit name: {unit}, ");
                }
                playerIndex++;
            }
        }
    }
}