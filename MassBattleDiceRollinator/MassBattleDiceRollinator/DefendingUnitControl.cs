using System;
using System.Windows.Forms;

namespace MassBattleDiceRollinator
{
	public partial class DefendingUnitControl : UserControl
	{
		public DefendingUnit DefendingUnit { get; private set; }

		public DefendingUnitControl()
		{
			InitializeComponent();
		}

		public void RegisterUnit(DefendingUnit defendingUnit)
		{
			DefendingUnit = defendingUnit;
			SetupDataBindings();
		}

		private void DefendingUnitControl_Load(object sender, EventArgs e)
		{
			DefendingUnit = new DefendingUnit("<<NAME>>");
			SetupDataBindings();
		}

		private void SetupDataBindings()
		{
			txtName.DataBindings.Clear();
			txtArmourClass.DataBindings.Clear();
			txtDamageThreshold.DataBindings.Clear();
			txtHitPoints.DataBindings.Clear();
			txtSize.DataBindings.Clear();
			chkCharacter.DataBindings.Clear();
			chkEnabled.DataBindings.Clear();

			txtName.DataBindings.Add("Text", DefendingUnit, nameof(DefendingUnit.Name), false, DataSourceUpdateMode.OnPropertyChanged);
			txtArmourClass.DataBindings.Add("Text", DefendingUnit, nameof(DefendingUnit.ArmourClass), false, DataSourceUpdateMode.OnPropertyChanged);
			txtDamageThreshold.DataBindings.Add("Text", DefendingUnit, nameof(DefendingUnit.DamageThreshold), false, DataSourceUpdateMode.OnPropertyChanged);
			txtHitPoints.DataBindings.Add("Text", DefendingUnit, nameof(DefendingUnit.HitPoints), false, DataSourceUpdateMode.OnPropertyChanged);
			txtSize.DataBindings.Add("Text", DefendingUnit, nameof(DefendingUnit.Size), false, DataSourceUpdateMode.OnPropertyChanged);
			chkCharacter.DataBindings.Add("Checked", DefendingUnit, nameof(DefendingUnit.Character), false, DataSourceUpdateMode.OnPropertyChanged);
			chkEnabled.DataBindings.Add("Checked", DefendingUnit, nameof(DefendingUnit.Enabled), false, DataSourceUpdateMode.OnPropertyChanged);
		}

		private void chkCharacter_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is CheckBox characterCheckBox)
			{
				if (characterCheckBox.Checked)
				{
					txtHitPoints.Visible = true;
					lblHitPoints.Visible = true;
					txtDamageThreshold.Visible = false;
					lblDamageThreshold.Visible = false;
				}
				else
				{
					txtHitPoints.Visible = false;
					lblHitPoints.Visible = false;
					txtDamageThreshold.Visible = true;
					lblDamageThreshold.Visible = true;
				}
			}
		}

		private void chkEnabled_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is CheckBox enabledCheckBox)
			{
				txtHitPoints.Enabled = enabledCheckBox.Checked;
				txtDamageThreshold.Enabled = enabledCheckBox.Checked;
				txtArmourClass.Enabled = enabledCheckBox.Checked;
				txtName.Enabled = enabledCheckBox.Checked;
				txtSize.Enabled = enabledCheckBox.Checked;
				chkCharacter.Enabled = enabledCheckBox.Checked;
			}
		}
	}
}
