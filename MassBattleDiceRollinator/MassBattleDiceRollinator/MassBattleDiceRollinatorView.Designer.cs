namespace MassBattleDiceRollinator
{
	partial class MassBattleDiceRollinatorView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.radAdvantage = new System.Windows.Forms.RadioButton();
			this.radDisadvantage = new System.Windows.Forms.RadioButton();
			this.radNone = new System.Windows.Forms.RadioButton();
			this.btnRollinate = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.spcMain = new System.Windows.Forms.SplitContainer();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.aucAttackingUnit1 = new MassBattleDiceRollinator.AttackingUnitControl();
			this.aucAttackingUnit2 = new MassBattleDiceRollinator.AttackingUnitControl();
			this.aucAttackingUnit3 = new MassBattleDiceRollinator.AttackingUnitControl();
			this.ducDefendingUnit1 = new MassBattleDiceRollinator.DefendingUnitControl();
			this.ducDefendingUnit2 = new MassBattleDiceRollinator.DefendingUnitControl();
			this.ducDefendingUnit3 = new MassBattleDiceRollinator.DefendingUnitControl();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClearOutput = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
			this.spcMain.Panel1.SuspendLayout();
			this.spcMain.Panel2.SuspendLayout();
			this.spcMain.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.aucAttackingUnit1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.aucAttackingUnit2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.aucAttackingUnit3, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.ducDefendingUnit1, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.ducDefendingUnit2, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.ducDefendingUnit3, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnRollinate, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 658);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.radAdvantage, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.radDisadvantage, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.radNone, 0, 1);
			this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 272);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(102, 84);
			this.tableLayoutPanel3.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Attackers have:";
			// 
			// radAdvantage
			// 
			this.radAdvantage.AutoSize = true;
			this.radAdvantage.Location = new System.Drawing.Point(3, 40);
			this.radAdvantage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radAdvantage.Name = "radAdvantage";
			this.radAdvantage.Size = new System.Drawing.Size(82, 19);
			this.radAdvantage.TabIndex = 2;
			this.radAdvantage.Text = "Advantage";
			this.radAdvantage.UseVisualStyleBackColor = true;
			// 
			// radDisadvantage
			// 
			this.radDisadvantage.AutoSize = true;
			this.radDisadvantage.Location = new System.Drawing.Point(3, 63);
			this.radDisadvantage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radDisadvantage.Name = "radDisadvantage";
			this.radDisadvantage.Size = new System.Drawing.Size(96, 19);
			this.radDisadvantage.TabIndex = 3;
			this.radDisadvantage.Text = "Disadvantage";
			this.radDisadvantage.UseVisualStyleBackColor = true;
			// 
			// radNone
			// 
			this.radNone.AutoSize = true;
			this.radNone.Checked = true;
			this.radNone.Location = new System.Drawing.Point(3, 17);
			this.radNone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radNone.Name = "radNone";
			this.radNone.Size = new System.Drawing.Size(54, 19);
			this.radNone.TabIndex = 1;
			this.radNone.TabStop = true;
			this.radNone.Text = "None";
			this.radNone.UseVisualStyleBackColor = true;
			// 
			// btnRollinate
			// 
			this.btnRollinate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRollinate.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.btnRollinate.Location = new System.Drawing.Point(263, 270);
			this.btnRollinate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRollinate.Name = "btnRollinate";
			this.btnRollinate.Size = new System.Drawing.Size(254, 88);
			this.btnRollinate.TabIndex = 6;
			this.btnRollinate.Text = "ROLLINATE";
			this.btnRollinate.UseVisualStyleBackColor = true;
			this.btnRollinate.Click += new System.EventHandler(this.btnRollinate_Click);
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.AutoSize = true;
			this.btnReset.Location = new System.Drawing.Point(3, 2);
			this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(66, 25);
			this.btnReset.TabIndex = 13;
			this.btnReset.Text = "Reset All";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// spcMain
			// 
			this.spcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.spcMain.Location = new System.Drawing.Point(10, 9);
			this.spcMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.spcMain.Name = "spcMain";
			// 
			// spcMain.Panel1
			// 
			this.spcMain.Panel1.Controls.Add(this.tableLayoutPanel1);
			this.spcMain.Panel1MinSize = 780;
			// 
			// spcMain.Panel2
			// 
			this.spcMain.Panel2.Controls.Add(this.txtOutput);
			this.spcMain.Size = new System.Drawing.Size(1139, 658);
			this.spcMain.SplitterDistance = 780;
			this.spcMain.TabIndex = 1;
			// 
			// txtOutput
			// 
			this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtOutput.Location = new System.Drawing.Point(0, 0);
			this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtOutput.Size = new System.Drawing.Size(355, 658);
			this.txtOutput.TabIndex = 0;
			// 
			// aucAttackingUnit1
			// 
			this.aucAttackingUnit1.AutoSize = true;
			this.aucAttackingUnit1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.aucAttackingUnit1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.aucAttackingUnit1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.aucAttackingUnit1.Location = new System.Drawing.Point(3, 39);
			this.aucAttackingUnit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.aucAttackingUnit1.Name = "aucAttackingUnit1";
			this.aucAttackingUnit1.Size = new System.Drawing.Size(254, 220);
			this.aucAttackingUnit1.TabIndex = 0;
			// 
			// aucAttackingUnit2
			// 
			this.aucAttackingUnit2.AutoSize = true;
			this.aucAttackingUnit2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.aucAttackingUnit2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.aucAttackingUnit2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.aucAttackingUnit2.Location = new System.Drawing.Point(263, 39);
			this.aucAttackingUnit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.aucAttackingUnit2.Name = "aucAttackingUnit2";
			this.aucAttackingUnit2.Size = new System.Drawing.Size(254, 220);
			this.aucAttackingUnit2.TabIndex = 1;
			// 
			// aucAttackingUnit3
			// 
			this.aucAttackingUnit3.AutoSize = true;
			this.aucAttackingUnit3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.aucAttackingUnit3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.aucAttackingUnit3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.aucAttackingUnit3.Location = new System.Drawing.Point(523, 39);
			this.aucAttackingUnit3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.aucAttackingUnit3.Name = "aucAttackingUnit3";
			this.aucAttackingUnit3.Size = new System.Drawing.Size(254, 220);
			this.aucAttackingUnit3.TabIndex = 2;
			// 
			// ducDefendingUnit1
			// 
			this.ducDefendingUnit1.AutoSize = true;
			this.ducDefendingUnit1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ducDefendingUnit1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ducDefendingUnit1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ducDefendingUnit1.Location = new System.Drawing.Point(3, 370);
			this.ducDefendingUnit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ducDefendingUnit1.Name = "ducDefendingUnit1";
			this.ducDefendingUnit1.Size = new System.Drawing.Size(254, 286);
			this.ducDefendingUnit1.TabIndex = 3;
			// 
			// ducDefendingUnit2
			// 
			this.ducDefendingUnit2.AutoSize = true;
			this.ducDefendingUnit2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ducDefendingUnit2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ducDefendingUnit2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ducDefendingUnit2.Location = new System.Drawing.Point(263, 370);
			this.ducDefendingUnit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ducDefendingUnit2.Name = "ducDefendingUnit2";
			this.ducDefendingUnit2.Size = new System.Drawing.Size(254, 286);
			this.ducDefendingUnit2.TabIndex = 4;
			// 
			// ducDefendingUnit3
			// 
			this.ducDefendingUnit3.AutoSize = true;
			this.ducDefendingUnit3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ducDefendingUnit3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ducDefendingUnit3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ducDefendingUnit3.Location = new System.Drawing.Point(523, 370);
			this.ducDefendingUnit3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ducDefendingUnit3.Name = "ducDefendingUnit3";
			this.ducDefendingUnit3.Size = new System.Drawing.Size(254, 286);
			this.ducDefendingUnit3.TabIndex = 5;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.btnReset, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnClearOutput, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(614, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(163, 31);
			this.tableLayoutPanel2.TabIndex = 14;
			// 
			// btnClearOutput
			// 
			this.btnClearOutput.AutoSize = true;
			this.btnClearOutput.Location = new System.Drawing.Point(75, 3);
			this.btnClearOutput.Name = "btnClearOutput";
			this.btnClearOutput.Size = new System.Drawing.Size(85, 25);
			this.btnClearOutput.TabIndex = 14;
			this.btnClearOutput.Text = "Clear Output";
			this.btnClearOutput.UseVisualStyleBackColor = true;
			this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
			// 
			// MassBattleDiceRollinatorView
			// 
			this.AcceptButton = this.btnRollinate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1160, 676);
			this.Controls.Add(this.spcMain);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MassBattleDiceRollinatorView";
			this.Text = "Mass Battle Dice Rollinator";
			this.Load += new System.EventHandler(this.MassBattleDiceRollinatorView_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.spcMain.Panel1.ResumeLayout(false);
			this.spcMain.Panel2.ResumeLayout(false);
			this.spcMain.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
			this.spcMain.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.SplitContainer spcMain;
		private System.Windows.Forms.TextBox txtOutput;
		private AttackingUnitControl aucAttackingUnit1;
		private AttackingUnitControl aucAttackingUnit2;
		private AttackingUnitControl aucAttackingUnit3;
		private DefendingUnitControl ducDefendingUnit1;
		private DefendingUnitControl ducDefendingUnit2;
		private DefendingUnitControl ducDefendingUnit3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.RadioButton radDisadvantage;
		private System.Windows.Forms.RadioButton radAdvantage;
		private System.Windows.Forms.RadioButton radNone;
		private System.Windows.Forms.Button btnRollinate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btnClearOutput;
	}
}
