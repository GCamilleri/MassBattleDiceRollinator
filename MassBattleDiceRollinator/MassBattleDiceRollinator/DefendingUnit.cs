using System.Collections.Generic;
using System.Linq;

namespace MassBattleDiceRollinator
{
	public class DefendingUnit : Unit
	{
		private int _Size;
		private int _ArmourClass;
		private bool _Character;
		private int _DamageThreshold;
		private int _HitPoints;
		private string _SkirmishReport;

		public DefendingUnit(string name) : base(name)
		{
		}

		public int Size
		{
			get { return _Size; }
			set
			{
				_Size = value;
				OnPropertyChanged(nameof(Size));
			}
		}

		public int ArmourClass
		{
			get { return _ArmourClass; }
			set
			{
				_ArmourClass = value;
				OnPropertyChanged(nameof(ArmourClass));
			}
		}

		public bool Character
		{
			get { return _Character; }
			set
			{
				_Character = value;
				OnPropertyChanged(nameof(Character));
			}
		}

		public int DamageThreshold
		{
			get { return _DamageThreshold; }
			set
			{
				_DamageThreshold = value;
				OnPropertyChanged(nameof(DamageThreshold));
			}
		}

		public int HitPoints
		{
			get { return _HitPoints; }
			set
			{
				_HitPoints = value;
				OnPropertyChanged(nameof(HitPoints));
			}
		}

		public string SkirmishReport
		{
			get { return _SkirmishReport; }
			set
			{
				_SkirmishReport = value;
				OnPropertyChanged(nameof(SkirmishReport));
			}
		}

		public int DamageTaken { get; set; }

		public List<Casualty> Casualties { get; set; } = new List<Casualty>();

		public int TotalHitsTaken => HitsTakenFromAttackers.Sum(h => h.Value);

		public Dictionary<AttackingUnit, int> HitsTakenFromAttackers { get; set; } = new Dictionary<AttackingUnit, int>();
	}
}
