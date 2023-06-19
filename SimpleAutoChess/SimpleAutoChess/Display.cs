using System;
using System.Numerics;
using SimpleAutoChess;

namespace SimpleAutoChess
{
	public class Display
	{
		public static void ShowEmptyBoard()
		{
			Console.WriteLine("\nAutoChess Board:");
			const int boardSize = 8;
			string[,] board = new string[boardSize, boardSize];

			//Initialize the board with empty spaces
			for (int i = 0; i < boardSize; i++)
			{
				for (int j = 0; j < boardSize; j++)
				{
					board[i, j] = "[    ]";
				}
			}
		}

		public static void ShowBoard(IPosition position, IUnit unit)
		{
			Console.WriteLine("\nAutoChess Board:");
			const int boardSize = 8;
			string[,] board = new string[boardSize, boardSize];

			//place units
			for (int i = 0; i < boardSize; i++)
			{
				for (int j = 0; j < boardSize; j++)
				{
					if (i == position.row && j == position.col)
					{
						board[i, j] = $"[{unit.Race}]";
					}
					else if (i == 6 && j == 8)
					{
						board[i, j] = $"[{unit.Race}]";
					}
					else
					{
						board[i, j] = "[     ]";
					}
				}
			}
			//Print Board
			for (int i = 0; i < boardSize; i++)
			{
				for (int j = 0; j < boardSize; j++)
				{
					Console.Write(board[i, j]);
				}
				Console.WriteLine();
			}
		}
		public static void ShowInfoPlyers(IPlayer player)
		{
			Console.WriteLine($"Player ID: {player.GenerateRandomId()}");
			Console.WriteLine($"Player Name: {player.name}");
		}
		public static void ShowInfoUnits(IUnit unit)
		{
			Console.WriteLine($"Race: {unit.Race}");
			Console.WriteLine($"Class: {unit.GetClass()}");
			Console.WriteLine($"Quality: {unit.GetQuality()}");
		}

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
		public static void PlayerUnitInfo(Dictionary<string, List<IUnit>> playerUnits)
		{
			Console.WriteLine("\nPlayer List:");
			int playerIndex = 1;
			foreach (var entry in playerUnits)
			{
				string playerName = entry.Key;
				List<IUnit> units = entry.Value;

				Console.WriteLine($"Player {playerIndex}: {playerName}");
				Console.WriteLine($"Player ID: {player.GenerateRandomId()()}");

				Console.WriteLine("Units:");
				foreach (IUnit unit in units)
				{
					Console.WriteLine($"- {unit.GetRace()}");
					Console.WriteLine($"Class: {unit.GetClass()}");
					Console.WriteLine($"Quality: {unit.GetQuality()}");
				}

				playerIndex++;
			}
		}
	}
}
