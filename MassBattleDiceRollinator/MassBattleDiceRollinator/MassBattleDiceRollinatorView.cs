using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MassBattleDiceRollinator
{
	public partial class MassBattleDiceRollinatorView : Form
	{
		private List<AttackingUnit> AttackingUnits = new List<AttackingUnit>();
		private List<DefendingUnit> DefendingUnits = new List<DefendingUnit>();

		public MassBattleDiceRollinatorView()
		{
			InitializeComponent();
		}

		private void MassBattleDiceRollinatorView_Load(object sender, System.EventArgs e)
		{
			ResetAllUnits();
		}

		private void ResetAllUnits()
		{
			AttackingUnits.Clear();
			DefendingUnits.Clear();

			for (int i = 1; i <= 3; i++)
			{
				var attackingUnit = new AttackingUnit($"Attacking Unit {i}");
				AttackingUnits.Add(attackingUnit);

				var defendingUnit = new DefendingUnit($"Defending Unit {i}");
				DefendingUnits.Add(defendingUnit);
			}

			aucAttackingUnit1.RegisterUnit(AttackingUnits[0]);
			aucAttackingUnit2.RegisterUnit(AttackingUnits[1]);
			aucAttackingUnit3.RegisterUnit(AttackingUnits[2]);
			ducDefendingUnit1.RegisterUnit(DefendingUnits[0]);
			ducDefendingUnit2.RegisterUnit(DefendingUnits[1]);
			ducDefendingUnit3.RegisterUnit(DefendingUnits[2]);

			txtOutput.ResetText();

			radNone.Checked = true;
		}

		private void btnRollinate_Click(object sender, EventArgs e)
		{
			try
			{
				DefendingUnits.ForEach(d =>
				{
					d.DamageTaken = 0;
					d.HitsTakenFromAttackers?.Clear();
					d.Casualties.Clear();
				});

				txtOutput.AppendText($"------ Beginning Skirmish ------" + Environment.NewLine);
				txtOutput.AppendText(Environment.NewLine);

				var attackerAdvantage = Advantage.None;

				if (radAdvantage.Checked) attackerAdvantage = Advantage.Advantage;
				else if (radDisadvantage.Checked) attackerAdvantage = Advantage.Disadvantage;
				else attackerAdvantage = Advantage.None;

				List<AttackingUnit> activeAttackers = AttackingUnits.Where(a => a.Enabled).ToList();
				List<DefendingUnit> activeDefenders = DefendingUnits.Where(d => d.Enabled).ToList();

				var totalDefenderSize = activeDefenders.Sum(d => d.Size);

				txtOutput.AppendText($"Total Defender Size: {totalDefenderSize}." + Environment.NewLine);

				foreach (AttackingUnit attackingUnit in activeAttackers)
				{
					txtOutput.AppendText($"{attackingUnit.Name} is attacking " + Environment.NewLine);
					txtOutput.AppendText($"----------------------------");
					txtOutput.AppendText(Environment.NewLine);

					var incomingAttacksPerUnit = new Dictionary<DefendingUnit, int>();

					foreach (DefendingUnit defender in activeDefenders)
					{
						incomingAttacksPerUnit.Add(defender, 0);
					}

					var random = new Random();

					foreach (int attack in Enumerable.Range(0, attackingUnit.Attacks))
					{
						int attackTarget = random.Next(1, totalDefenderSize + 1);

						if (1 <= attackTarget && attackTarget <= activeDefenders[0].Size)
						{
							incomingAttacksPerUnit[activeDefenders[0]]++;
						}
						else if (activeDefenders[0].Size <= attackTarget && attackTarget <= (activeDefenders[0].Size + activeDefenders[1].Size))
						{
							incomingAttacksPerUnit[activeDefenders[1]]++;
						}
						else if ((activeDefenders[0].Size + activeDefenders[1].Size) <= attackTarget && attackTarget <= totalDefenderSize)
						{
							incomingAttacksPerUnit[activeDefenders[2]]++;
						}
						else
						{
							txtOutput.AppendText("What even is this my dude?");
						}
					}

					foreach (var unitAttacks in incomingAttacksPerUnit.Select(kvp => new { Unit = kvp.Key, Attacks = kvp.Value }))
					{
						var advantageText = string.Empty;

						switch (attackerAdvantage)
						{
							case Advantage.Advantage:
								advantageText = "with advantage";
								break;
							case Advantage.Disadvantage:
								advantageText = "with disadvantage";
								break;
						}

						txtOutput.AppendText($"{attackingUnit.Name} attacks {unitAttacks.Unit.Name} {unitAttacks.Attacks} times {advantageText}." + Environment.NewLine);
						int totalHits = 0;

						var attackRandom = new Random();

						foreach (int attack in Enumerable.Range(0, unitAttacks.Attacks))
						{
							int rollToHit = attackRandom.Next(1, 21);

							switch (attackerAdvantage)
							{
								case Advantage.Advantage:
									rollToHit = Math.Max(rollToHit, attackRandom.Next(1, 21));
									break;
								case Advantage.Disadvantage:
									rollToHit = Math.Min(rollToHit, attackRandom.Next(1, 21));
									break;
							}

							if ((rollToHit + attackingUnit.AttackBonus) >= unitAttacks.Unit.ArmourClass)
							{
								totalHits++;
							}
						}

						unitAttacks.Unit.HitsTakenFromAttackers.Add(attackingUnit, totalHits);

						txtOutput.AppendText($"{attackingUnit.Name} hits {totalHits} times" + Environment.NewLine);
						txtOutput.AppendText(Environment.NewLine);
					}

					txtOutput.AppendText("--- Casualties ---");
					txtOutput.AppendText(Environment.NewLine);

					foreach (DefendingUnit defendingUnit in activeDefenders)
					{
						int totalDamage = 0;
						var damageRandom = new Random();
						foreach (int hit in Enumerable.Range(0, defendingUnit.HitsTakenFromAttackers[attackingUnit]))
						{
							int damage = 0;
							int damageAfterMods = 0;

							foreach (int diceMultiplier in Enumerable.Range(0, attackingUnit.DiceMultiplier))
							{
								damage += damageRandom.Next(1, (int)(attackingUnit.DiceType));
							}

							damageAfterMods = (int)Math.Floor(((damage + attackingUnit.DamageBonus) * attackingUnit.TotalDamageMultiplier));

							totalDamage += damageAfterMods;
						}

						defendingUnit.DamageTaken += totalDamage;
						txtOutput.AppendText($"{defendingUnit.Name} takes {totalDamage} damage from {attackingUnit.Name}'s attacks." + Environment.NewLine);
					}

					txtOutput.AppendText($"----------------------------");
					txtOutput.AppendText(Environment.NewLine);
					txtOutput.AppendText(Environment.NewLine);
				}

				foreach (DefendingUnit defendingUnit in activeDefenders)
				{
					var skirmishReportSb = new StringBuilder();

					skirmishReportSb.AppendLine($"{defendingUnit.Name} takes {defendingUnit.DamageTaken} total damage from {defendingUnit.TotalHitsTaken} attacks." + Environment.NewLine);

					if (defendingUnit.Character)
					{
						skirmishReportSb.AppendLine($"{defendingUnit.Name}'s remaining hitpoints are {defendingUnit.HitPoints - defendingUnit.DamageTaken}.");
					}
					else
					{
						if (defendingUnit.DamageTaken > 0)
						{
							int casualties = (int)Math.Floor(((double)defendingUnit.DamageTaken / defendingUnit.DamageThreshold));

							if (casualties > 0)
							{
								var casualtyRandom = new Random();

								foreach (int casualty in Enumerable.Range(0, casualties))
								{
									int severity = casualtyRandom.Next(0, 100);

									if (severity < 25)
									{
										defendingUnit.Casualties.Add(Casualty.Light);
									}
									else if (severity < 55)
									{
										defendingUnit.Casualties.Add(Casualty.Moderate);
									}
									else if (severity < 80)
									{
										defendingUnit.Casualties.Add(Casualty.Critical);
									}
									else if (severity < 100)
									{
										defendingUnit.Casualties.Add(Casualty.Fatal);
									}
									else
									{
										//error
									}
								}

								if ((((double)defendingUnit.DamageTaken / defendingUnit.DamageThreshold) - casualties) > 0)
								{
									defendingUnit.Casualties.Add(Casualty.Light);
								}
							}

							var casualtyCounts = defendingUnit.Casualties
								.GroupBy(c => c)
								.Select(g => new
								{
									CasualtyType = g.Key,
									Count = g.Count()
								});

							skirmishReportSb.AppendLine($"{defendingUnit.Name} sustains:");
							if (defendingUnit.Casualties.Count == 0)
							{
								skirmishReportSb.AppendLine("No Casualties");
							}
							else
							{
								foreach (var casualtyCount in casualtyCounts)
								{
									skirmishReportSb.AppendLine($"\t {casualtyCount.Count} {casualtyCount.CasualtyType} casualt{(casualtyCount.Count == 1 ? "y" : "ies")}.");
								}
							}
						}
					}

					defendingUnit.SkirmishReport = skirmishReportSb.ToString();

					txtOutput.AppendText(skirmishReportSb.ToString());
					txtOutput.AppendText(Environment.NewLine);
					txtOutput.AppendText(Environment.NewLine);
				}

				txtOutput.AppendText("------ End of Skirmish ------" + Environment.NewLine);
				txtOutput.AppendText(Environment.NewLine);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something done gon' died. Just be glad you don't have to type all that out again." + ex.Message);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			ResetAllUnits();
		}

		private void btnClearOutput_Click(object sender, EventArgs e)
		{
			txtOutput.ResetText();
		}
	}
}
