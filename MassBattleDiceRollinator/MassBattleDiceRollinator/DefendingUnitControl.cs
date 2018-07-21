using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassBattleDiceRollinator
{
	public partial class DefendingUnitControl : UserControl
	{
		public DefendingUnitControl()
		{
			InitializeComponent();
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
	}
}
