namespace MassBattleDiceRollinator
{
	public class DefendingUnit : Unit
	{
		public int _Size;
		public int _ArmourClass;
		public bool _Character;
		public int _DamageThreshold;
		public int _HitPoints;

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
	}
}
