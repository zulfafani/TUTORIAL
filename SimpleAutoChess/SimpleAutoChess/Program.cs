using System;
using System.Numerics;
using SimpleAutoChess;

namespace SimpleAutoChess
{
	public class Program
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
				string input = Console.ReadLine();
				if (int.TryParse(input, out numPlayers) && numPlayers > 1)
				{
					validInput = true;
				}
				else
				{
					Display.InvalidNumberInfo();
				}
			}
			while (!validInput); //repeat the iteration for input number player

			//Input name of players
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

			//input units
			foreach (var entry in gameManager.GetPlayerUnits())
			{
				string playerName = entry.Key;

				Console.WriteLine($"\nPlayer: {playerName}");

				Console.Write("Enter the number of units: ");
				int numUnits;
				bool validUnitInput = false;

				do
				{
					string input = Console.ReadLine();

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

				for (int i = 0; i < numUnits; i++)
				{
					Console.WriteLine("Available Race: Beast, Human, Goblin, Dragon, Dwarf");
					Console.Write($"Enter the Race of unit {i + 1}: ");
					string raceInput = Console.ReadLine();
					Enum.TryParse(raceInput, out Race race);
					IUnit unit = new Unit();
					unit.SetRace(race);

					if (raceInput != race.ToString())
					{
						Display.InvalidUnitInfo();
						i--; // repeat the iteration for incorrect unit index
						continue;
					}
					gameManager.AddUnitForPlayer(playerName, unit);

					//Input Location of Units
					//Console.Write($"Enter the location of the {race.ToString()} on board (row column): ");
					//string locationInput = Console.ReadLine();
					//string[] locationValues = locationInput.Split(' ');
					//int row, column;

					//if (locationValues.Length == 2 && int.TryParse(locationValues[0], out row) && int.TryParse(locationValues[1], out column))
					//{
						//IPosition square = new Position();
						//square.row = row;
						//square.col = column;
						//gameManager.AddUnitOnBoard(playerName, unit, square);

						// Process the row and column values as needed
						// For simplicity, we'll just display them here
						//Console.WriteLine($"Unit {unit.GetRace} added at location: Row {row}, Column {column}");
					//}
					//else
					//{
						//Console.WriteLine("Invalid location input. Please enter valid row and column values.");
						//i--; // Decrement i to repeat the iteration for the same unit index
					//}
				}

			}
			
			//Display.PlayerUnitInfo(playerName, units, _units);
			
			//Display
			//Console.WriteLine("\nPlayer List:");
			//int playerIndex = 1;
			//foreach (var entry in gameManager.GetPlayerUnits())
			//{
				//string playerName = entry.Key;
				//List<IUnit> units = entry.Value;

				//Console.WriteLine($"Player {playerIndex}: {playerName}");

				//Console.WriteLine("Units:");
				//foreach (IUnit unit in units)
				//{
					//Console.WriteLine($"- {unit.GetRace()}");
				//}

				//playerIndex++;
			//}

			//Display.PlayerUnitInfo();
			// Show empty board
			Display.ShowEmptyBoard();
			//Display.ShowBoard(IPosition position, IUnit unit)

			//Invite Players
			//Console.Write("Enter player name: ");
			//string playerName = Console.ReadLine();
			//IPlayer player1 = new Player();
			//player1.SetName(playerName);

			//IPlayer player2 = new Player();
			//player2.SetName("Player 2");

			//gameManager.AddPlayer(player1);
			//gameManager.AddPlayer(player2);

			//Add Unit player1
			//Console.WriteLine("Available Race: Beast, Human, Goblin, Dragon, Dwarf");
			//Console.WriteLine("Enter Race for Units:");
			//string raceInput1 = Console.ReadLine();
			//Enum.TryParse(raceInput1, out Race race1);
			//IUnit unit1 = new Unit();
			//unit1.SetRace(race1);

			//Add Unit player2
			//IUnit unit2 = new Unit();
			//Race race2 = (Race)new Random().Next(Enum.GetValues(typeof(Race)).Length);
			//unit2.SetRace(race2);

			//Players with Units
			//gameManager.AddUnitForPlayer(player1, unit1);
			//gameManager.AddUnitForPlayer(player2, unit2);

			//Add location of Units on Board belum exeption handling
			//Console.WriteLine($"Enter location of unit on the board: ");
			//Console.Write("Enter row: ");
			//string inputRow = Console.ReadLine();
			//int numberRow = int.Parse(inputRow);
			//Console.Write("Enter column: ");
			//string inputCol = Console.ReadLine();
			//int numberCol = int.Parse(inputCol);

			//IPosition square1 = new Position();
			//square1.row = numberRow;
			//square1.col = numberCol;

			//IPosition square2 = new Position();
			//square2.row = 2;
			//square2.col = 3;

			//gameManager.AddUnitOnBoard(player1, unit1, square1);
			//gameManager.AddUnitOnBoard(player2, unit2, square2);

			//display.ShowInfoPlyers(player1);
			//display.ShowInfoUnits(unit1);
			//display.ShowInfoPlyers(player2);
			//display.ShowInfoUnits(unit2);


			//Display.ShowBoard(square1, unit1);
			//Display.ShowBoard(square2, unit2);

			//Action<IUnit> onBattleComplete = (unit) =>
			//{
				//Console.WriteLine("Battle complete!");
				//Console.WriteLine($"Winner is Race {unit.Race}, Class {unit.Class}, Quality {unit.Quality}");
			//};

			//gameManager.Battle2(unit1, unit2, onBattleComplete);

		}

	}
}