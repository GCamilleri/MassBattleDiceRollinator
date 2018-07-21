namespace MassBattleDiceRollinator
{
	public class AttackingUnit : Unit
	{
		public AttackingUnit(string name) : base(name)
		{
		}

		public int _Attacks;
		public int _AttackBonus;
		public int _DiceMultiplier;
		public int _DamageBonus;
		public decimal _TotalDamageMultiplier;
		public DiceType _DiceType;

		public int Attacks
		{
			get { return _Attacks; }
			set
			{
				_Attacks = value;
				OnPropertyChanged(nameof(Attacks));
			}
		}

		public int AttackBonus
		{
			get { return _AttackBonus; }
			set
			{
				_AttackBonus = value;
				OnPropertyChanged(nameof(AttackBonus));
			}
		}

		public int DiceMultiplier
		{
			get { return _DiceMultiplier; }
			set
			{
				_DiceMultiplier = value;
				OnPropertyChanged(nameof(DiceMultiplier));
			}
		}

		public int DamageBonus
		{
			get { return _DamageBonus; }
			set
			{
				_DamageBonus = value;
				OnPropertyChanged(nameof(DamageBonus));
			}
		}

		public decimal TotalDamageMultiplier
		{
			get { return _TotalDamageMultiplier; }
			set
			{
				_TotalDamageMultiplier = value;
				OnPropertyChanged(nameof(TotalDamageMultiplier));
			}
		}

		public DiceType DiceType
		{
			get { return _DiceType; }
			set
			{
				_DiceType = value;
				OnPropertyChanged(nameof(DiceType));
			}
		}
	}
}
