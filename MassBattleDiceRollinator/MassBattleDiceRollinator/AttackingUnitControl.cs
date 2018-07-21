using System;
using System.Windows.Forms;

namespace MassBattleDiceRollinator
{
	public partial class AttackingUnitControl : UserControl
	{
		public AttackingUnit AttackingUnit { get; private set; }

		public AttackingUnitControl()
		{
			InitializeComponent();
		}

		public void RegisterUnit(AttackingUnit attackingUnit)
		{
			AttackingUnit = attackingUnit;
			SetupDataBindings();
		}

		private void AttackingUnitControl_Load(object sender, EventArgs e)
		{
			AttackingUnit = new AttackingUnit("<<NAME>>");
			SetupDataBindings();
		}

		private void SetupDataBindings()
		{
			txtAttackBonus.DataBindings.Clear();
			txtAttacks.DataBindings.Clear();
			txtName.DataBindings.Clear();
			txtDiceMultiplier.DataBindings.Clear();
			txtDamageBonus.DataBindings.Clear();
			txtTotalDamageMultiplier.DataBindings.Clear();
			cboDamageDice.DataBindings.Clear();
			chkEnabled.DataBindings.Clear();

			txtName.DataBindings.Add("Text", AttackingUnit, nameof(AttackingUnit.Name), false, DataSourceUpdateMode.OnPropertyChanged);
			txtAttacks.DataBindings.Add("Text", AttackingUnit, nameof(AttackingUnit.Attacks), false, DataSourceUpdateMode.OnPropertyChanged);
			txtAttackBonus.DataBindings.Add("Text", AttackingUnit, nameof(AttackingUnit.AttackBonus), false, DataSourceUpdateMode.OnPropertyChanged);
			txtDamageBonus.DataBindings.Add("Text", AttackingUnit, nameof(AttackingUnit.DamageBonus), false, DataSourceUpdateMode.OnPropertyChanged);
			txtDiceMultiplier.DataBindings.Add("Text", AttackingUnit, nameof(AttackingUnit.DiceMultiplier), false, DataSourceUpdateMode.OnPropertyChanged);
			txtTotalDamageMultiplier.DataBindings.Add("Text", AttackingUnit, nameof(AttackingUnit.TotalDamageMultiplier), false, DataSourceUpdateMode.OnPropertyChanged);
			chkEnabled.DataBindings.Add("Checked", AttackingUnit, nameof(AttackingUnit.Enabled), false, DataSourceUpdateMode.OnPropertyChanged);

			cboDamageDice.DataSource = Enum.GetValues(typeof(DiceType));
			cboDamageDice.DataBindings.Add("SelectedItem", AttackingUnit, nameof(AttackingUnit.DiceType), false, DataSourceUpdateMode.OnPropertyChanged);
		}

		private void chkEnabled_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is CheckBox enabledCheckBox)
			{
				txtName.Enabled = enabledCheckBox.Checked;
				txtAttacks.Enabled = enabledCheckBox.Checked;
				txtAttackBonus.Enabled = enabledCheckBox.Checked;
				txtDamageBonus.Enabled = enabledCheckBox.Checked;
				txtDiceMultiplier.Enabled = enabledCheckBox.Checked;
				txtTotalDamageMultiplier.Enabled = enabledCheckBox.Checked;
				cboDamageDice.Enabled = enabledCheckBox.Checked;
				lblAttacks.Enabled = enabledCheckBox.Checked;
				lblTotalDamageMultiplier.Enabled = enabledCheckBox.Checked;
				lblAttackBonus.Enabled = enabledCheckBox.Checked;
				lblDamageBonus.Enabled = enabledCheckBox.Checked;
				lblDamageDice.Enabled = enabledCheckBox.Checked;
				lblDiceMultiplier.Enabled = enabledCheckBox.Checked;
			}
		}
	}
}
