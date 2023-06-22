﻿using System;
using SimpleAutoChess;

namespace SimpleAutoChess
{
	public static class Program
	{
		public static void Main()
		{
			GameManager gameManager = new GameManager();

			//Input number of players
			int numPlayers;
			bool validInput = false;
			do
			{
				Console.Write("Enter the number of players: ");
				string? input = Console.ReadLine();
				if (int.TryParse(input, out numPlayers) && numPlayers > 1 && numPlayers <= 8)
				{
					validInput = true;
				}
				else
				{
					Display.InvalidNumberInfo();
				}
			}
			while (!validInput); //repeat the iteration for input number player

			//Input name of players -> AddPlayer method
			for (int i = 0; i < numPlayers; i++)
			{
				Console.Write($"Enter the name of player {i + 1}: ");
				string? playerName = Console.ReadLine();

				IPlayer player = new Player();
				player.SetName(playerName);

				if (gameManager.PlayerExists(player))
				{
					Display.InvalidPlayerNameInfo();
					i--; // repeat the iteration for the same player index
					continue;
				}
				gameManager.AddPlayer(player);
			}

			//input number of units
			foreach (var entry in gameManager.GetPlayerUnits())
			{
				string playerName = entry.Key;

				Console.WriteLine($"\nPlayer: {playerName}");

				Console.Write("Enter the number of units: ");
				int numUnits;
				bool validUnitInput = false;

				do
				{
					string? input = Console.ReadLine();

					if (int.TryParse(input, out numUnits) && numUnits > 0)
					{
						validUnitInput = true;
					}
					else
					{
						Display.InvalidNumberInfo();
					}
				}
				while (!validUnitInput); //repeat the iteration for input number unit

				//input units name -> AddUnitForPlayer method
				for (int i = 0; i < numUnits; i++)
				{
					List<UnitName> unitNames = gameManager.GetAllUnitNames();
					Console.WriteLine("Available units: ");
					foreach (UnitName unitName in unitNames)
					{
						Console.WriteLine($"- {unitName}");
					}

					Console.Write($"Choose a unit name: {i + 1}: ");
					string? unitInput = Console.ReadLine();
					Enum.TryParse(unitInput, out UnitName selectedUnitName);
					IUnit unit = new Unit();

					bool containsUnit = unitNames.Any(unit => unitInput.Contains(unit.ToString()));

					if (!containsUnit)
					{
						Console.WriteLine("Invalid unit name. Please try again.");
						i--; // repeat the iteration for incorrect unit index
						continue;
					}
					else
					{
						gameManager.AddUnitForPlayer(playerName, selectedUnitName);
					}
				}
			}
			//Display information of player and unit
			Display.PlayerUnitInfo(gameManager.GetPlayerUnits(), gameManager);

			// Input size of Board
			int boardSize;
			bool validSizeInput = false;
			Console.WriteLine("\n--AutoChess Board--");
			do
			{
				Console.Write("Enter the size of Board (8 - 12):");
				string? inputSize = Console.ReadLine();
				if (int.TryParse(inputSize, out boardSize) & boardSize >= 8 && boardSize <= 12)
				{
					validSizeInput = true;
				}
				else
				{
					Display.InvalidNumberInfo();
				}
			}
			while (!validSizeInput); //repeat the iteration for input size board

			string[,] board = new string[boardSize, boardSize];

			// Initialize the board with empty spaces
			for (int i = 0; i < boardSize; i++)
			{
				for (int j = 0; j < boardSize; j++)
				{
					board[i, j] = "[     ]";
					Console.Write(board[i, j]);
				}
				Console.WriteLine();
			}

			// Place the units name on the board
			foreach (var entry in gameManager.GetPlayerUnits())
			{
				List<UnitName> units = entry.Value;

				foreach (UnitName unit in units)
				{
					//unit.GetUnitName() ada 3
					IPosition position = new Position();
					//position.row;

					Console.Write($"Enter the location of {unit} for {entry.Key} (row column): ");
					string? locationInput = Console.ReadLine();
					string[] locationValues = locationInput.Split(' ');
					int row, column;

					if (locationValues.Length == 2 && int.TryParse(locationValues[0], out row) && int.TryParse(locationValues[1], out column))
					{
						if (row >= 0 && row < boardSize && column >= 0 && column < boardSize)
						{
							board[row, column] = $"[{unit}]";
							Console.WriteLine($"Unit {unit} added at location: Row {row}, Column {column}");
							gameManager.AddUnitOnBoard(entry.Key, unit, row, column);
						}
						else
						{
							Console.WriteLine("Invalid location input. Skipping unit placement.");
							//method untuk random placement units
						}
					}
					else
					{
						Console.WriteLine("Invalid location input. Skipping unit placement.");
						//method untuk random placement units
					}
				}
			}
			// Print the board
			for (int i = 0; i < boardSize; i++)
			{
				for (int j = 0; j < boardSize; j++)
				{
					Console.Write(board[i, j]);
				}
				Console.WriteLine();
			}
			//Action<IUnit> onBattleComplete = (unit) =>
			//{
			//Console.WriteLine("Battle complete!");
			//Console.WriteLine($"Winner is Race {unit.Race}, Class {unit.Class}, Quality {unit.Quality}");
			//};

			//gameManager.Battle2(unit1, unit2, onBattleComplete);

		
		
		}
	}
}