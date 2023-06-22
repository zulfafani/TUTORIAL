using System;
using System.Collections.Generic;
using SimpleAutoChess;

namespace SimpleAutoChess
{
	public class GameManager
	{
		private Dictionary<IPosition, List<UnitName>> _board;
		private Dictionary<string, List<UnitName>> _unitsName;
		//private Action<List<UnitName>> _onBattleComplete;

		public GameManager()
		{
			_board = new Dictionary<IPosition, List<UnitName>>();
			_unitsName = new Dictionary<string, List<UnitName>>();
			//_onBattleComplete = new Action<List<UnitName>>(_onBattleComplete);
		}

		public Dictionary<string, List<UnitName>> GetPlayerUnits()
		{
			return _unitsName;
		}

		public List<UnitName> GetAllUnitNames()
		{
			List<UnitName> unitNames = new List<UnitName>();
			foreach (UnitName unitName in Enum.GetValues(typeof(UnitName)))
			{
				unitNames.Add(unitName);
			}
			return unitNames;
		}

		public string GenerateRandomId()
		{
			Random random = new Random();
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			char[] idChars = new char[6];

			for (int i = 0; i < idChars.Length; i++)
			{
				idChars[i] = chars[random.Next(chars.Length)];
			}
			//_id = idChars.ToString(); will print out "System.Char[]" because calling ToString on a T array in .NET will always return "T[]".
			return new string(idChars);
		}

		public void AddPlayer(IPlayer player)
		{
			_unitsName.Add(player.GetName(), new List<UnitName>());
		}
		
		public bool PlayerExists(IPlayer player)
		{
			return _unitsName.ContainsKey(player.GetName());
		}

		public void AddUnitForPlayer(string playerName, UnitName unitName)
		{
			if (_unitsName.ContainsKey(playerName))
			{
				_unitsName[playerName].Add(unitName);
			}
		}

		public void AddUnitOnBoard(string playerName, UnitName unitName, int row, int col)
		{
			//if (!_board.ContainsKey(row))
				//_board[square] = new List<IUnit>();

			//_units[player].Add(unit);
			//_board[square].Add(unit);
		}
		public void RemoveUnit(IPlayer player, IUnit unit, IPosition square)
		{
			if (_board.ContainsKey(square))
			{
				//_board[square].Remove(unit);
				// _units[player].Remove(unit);
			}
		}

		private bool IsBattleOngoing(List<UnitName> units)
		{
			int numberUnits = units.Count;
			return units.Count > 1;
		}
		
		
		
		
		//public void Battle(IUnit unit1, IUnit unit2, Action<IUnit> onBattleComplete)
		//{
		//while (((IHealth)unit1).GetHealth() > 0 && (((IHealth)unit2).GetHealth() > 0))
		//{
		//Console.WriteLine("Battle");
		//((IHealth)unit2).ModifyHealth(-((IAttack)unit1).GetAttack());
		//((IHealth)unit1).ModifyHealth(-((IAttack)unit2).GetAttack());
		//}
		//onBattleComplete?.Invoke(((IHealth)unit1).GetHealth() <= 0 ? unit1 : unit2);
		//}

	}

}