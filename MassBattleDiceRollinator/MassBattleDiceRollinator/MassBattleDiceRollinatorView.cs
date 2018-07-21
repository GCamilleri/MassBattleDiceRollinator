using System.Collections.Generic;
using System.Windows.Forms;

namespace MassBattleDiceRollinator
{
	public partial class MassBattleDiceRollinatorView : Form
	{
		private IEnumerable<AttackingUnit> AttackingUnits;
		private IEnumerable<DefendingUnit> DefendingUnits;

		public MassBattleDiceRollinatorView()
		{
			InitializeComponent();
		}

		private void MassBattleDiceRollinatorView_Load(object sender, System.EventArgs e)
		{

		}
	}
}
