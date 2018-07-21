namespace MassBattleDiceRollinator
{
	partial class AttackingUnitControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.lblAttacks = new System.Windows.Forms.Label();
			this.lblAttackBonus = new System.Windows.Forms.Label();
			this.lblDamageDice = new System.Windows.Forms.Label();
			this.lblDamageBonus = new System.Windows.Forms.Label();
			this.txtAttacks = new System.Windows.Forms.TextBox();
			this.txtAttackBonus = new System.Windows.Forms.TextBox();
			this.txtDamageBonus = new System.Windows.Forms.TextBox();
			this.lblDiceMultiplier = new System.Windows.Forms.Label();
			this.txtDiceMultiplier = new System.Windows.Forms.TextBox();
			this.lblTotalDamageMultiplier = new System.Windows.Forms.Label();
			this.cboDamageDice = new System.Windows.Forms.ComboBox();
			this.txtTotalDamageMultiplier = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.chkEnabled = new System.Windows.Forms.CheckBox();
			this.tlpMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpMain.AutoSize = true;
			this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlpMain.ColumnCount = 2;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpMain.Controls.Add(this.lblAttacks, 0, 1);
			this.tlpMain.Controls.Add(this.lblAttackBonus, 0, 2);
			this.tlpMain.Controls.Add(this.lblDamageDice, 0, 5);
			this.tlpMain.Controls.Add(this.lblDamageBonus, 0, 6);
			this.tlpMain.Controls.Add(this.txtAttacks, 1, 1);
			this.tlpMain.Controls.Add(this.txtAttackBonus, 1, 2);
			this.tlpMain.Controls.Add(this.txtDamageBonus, 1, 6);
			this.tlpMain.Controls.Add(this.lblDiceMultiplier, 0, 4);
			this.tlpMain.Controls.Add(this.txtDiceMultiplier, 1, 4);
			this.tlpMain.Controls.Add(this.lblTotalDamageMultiplier, 0, 7);
			this.tlpMain.Controls.Add(this.cboDamageDice, 1, 5);
			this.tlpMain.Controls.Add(this.txtTotalDamageMultiplier, 1, 7);
			this.tlpMain.Controls.Add(this.txtName, 0, 0);
			this.tlpMain.Controls.Add(this.chkEnabled, 1, 0);
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 8;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.Size = new System.Drawing.Size(246, 219);
			this.tlpMain.TabIndex = 0;
			// 
			// lblAttacks
			// 
			this.lblAttacks.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblAttacks.AutoSize = true;
			this.lblAttacks.Enabled = false;
			this.lblAttacks.Location = new System.Drawing.Point(3, 32);
			this.lblAttacks.Name = "lblAttacks";
			this.lblAttacks.Size = new System.Drawing.Size(107, 15);
			this.lblAttacks.TabIndex = 2;
			this.lblAttacks.Text = "Number of Attacks";
			// 
			// lblAttackBonus
			// 
			this.lblAttackBonus.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblAttackBonus.AutoSize = true;
			this.lblAttackBonus.Enabled = false;
			this.lblAttackBonus.Location = new System.Drawing.Point(3, 61);
			this.lblAttackBonus.Name = "lblAttackBonus";
			this.lblAttackBonus.Size = new System.Drawing.Size(77, 15);
			this.lblAttackBonus.TabIndex = 4;
			this.lblAttackBonus.Text = "Attack Bonus";
			// 
			// lblDamageDice
			// 
			this.lblDamageDice.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDamageDice.AutoSize = true;
			this.lblDamageDice.Enabled = false;
			this.lblDamageDice.Location = new System.Drawing.Point(3, 139);
			this.lblDamageDice.Name = "lblDamageDice";
			this.lblDamageDice.Size = new System.Drawing.Size(77, 15);
			this.lblDamageDice.TabIndex = 8;
			this.lblDamageDice.Text = "Damage Dice";
			// 
			// lblDamageBonus
			// 
			this.lblDamageBonus.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDamageBonus.AutoSize = true;
			this.lblDamageBonus.Enabled = false;
			this.lblDamageBonus.Location = new System.Drawing.Point(3, 168);
			this.lblDamageBonus.Name = "lblDamageBonus";
			this.lblDamageBonus.Size = new System.Drawing.Size(87, 15);
			this.lblDamageBonus.TabIndex = 10;
			this.lblDamageBonus.Text = "Damage Bonus";
			// 
			// txtAttacks
			// 
			this.txtAttacks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAttacks.Enabled = false;
			this.txtAttacks.Location = new System.Drawing.Point(143, 28);
			this.txtAttacks.Name = "txtAttacks";
			this.txtAttacks.Size = new System.Drawing.Size(100, 23);
			this.txtAttacks.TabIndex = 3;
			// 
			// txtAttackBonus
			// 
			this.txtAttackBonus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAttackBonus.Enabled = false;
			this.txtAttackBonus.Location = new System.Drawing.Point(143, 57);
			this.txtAttackBonus.Name = "txtAttackBonus";
			this.txtAttackBonus.Size = new System.Drawing.Size(100, 23);
			this.txtAttackBonus.TabIndex = 5;
			// 
			// txtDamageBonus
			// 
			this.txtDamageBonus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDamageBonus.Enabled = false;
			this.txtDamageBonus.Location = new System.Drawing.Point(143, 164);
			this.txtDamageBonus.Name = "txtDamageBonus";
			this.txtDamageBonus.Size = new System.Drawing.Size(100, 23);
			this.txtDamageBonus.TabIndex = 11;
			// 
			// lblDiceMultiplier
			// 
			this.lblDiceMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDiceMultiplier.AutoSize = true;
			this.lblDiceMultiplier.Enabled = false;
			this.lblDiceMultiplier.Location = new System.Drawing.Point(3, 110);
			this.lblDiceMultiplier.Name = "lblDiceMultiplier";
			this.lblDiceMultiplier.Size = new System.Drawing.Size(84, 15);
			this.lblDiceMultiplier.TabIndex = 6;
			this.lblDiceMultiplier.Text = "Dice Multiplier";
			// 
			// txtDiceMultiplier
			// 
			this.txtDiceMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDiceMultiplier.Enabled = false;
			this.txtDiceMultiplier.Location = new System.Drawing.Point(143, 106);
			this.txtDiceMultiplier.Name = "txtDiceMultiplier";
			this.txtDiceMultiplier.Size = new System.Drawing.Size(100, 23);
			this.txtDiceMultiplier.TabIndex = 7;
			// 
			// lblTotalDamageMultiplier
			// 
			this.lblTotalDamageMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTotalDamageMultiplier.AutoSize = true;
			this.lblTotalDamageMultiplier.Enabled = false;
			this.lblTotalDamageMultiplier.Location = new System.Drawing.Point(3, 197);
			this.lblTotalDamageMultiplier.Name = "lblTotalDamageMultiplier";
			this.lblTotalDamageMultiplier.Size = new System.Drawing.Size(134, 15);
			this.lblTotalDamageMultiplier.TabIndex = 12;
			this.lblTotalDamageMultiplier.Text = "Total Damage Multiplier";
			// 
			// cboDamageDice
			// 
			this.cboDamageDice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboDamageDice.Enabled = false;
			this.cboDamageDice.FormattingEnabled = true;
			this.cboDamageDice.Items.AddRange(new object[] {
            "None",
            "d4",
            "d6",
            "d8",
            "d10",
            "d12"});
			this.cboDamageDice.Location = new System.Drawing.Point(143, 135);
			this.cboDamageDice.Name = "cboDamageDice";
			this.cboDamageDice.Size = new System.Drawing.Size(100, 23);
			this.cboDamageDice.TabIndex = 9;
			// 
			// txtTotalDamageMultiplier
			// 
			this.txtTotalDamageMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotalDamageMultiplier.Enabled = false;
			this.txtTotalDamageMultiplier.Location = new System.Drawing.Point(143, 193);
			this.txtTotalDamageMultiplier.Name = "txtTotalDamageMultiplier";
			this.txtTotalDamageMultiplier.Size = new System.Drawing.Size(100, 23);
			this.txtTotalDamageMultiplier.TabIndex = 13;
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.SystemColors.Control;
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtName.Enabled = false;
			this.txtName.Location = new System.Drawing.Point(3, 3);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 16);
			this.txtName.TabIndex = 1;
			this.txtName.Text = "[[Unit Name]]";
			// 
			// chkEnabled
			// 
			this.chkEnabled.AutoSize = true;
			this.chkEnabled.Location = new System.Drawing.Point(143, 3);
			this.chkEnabled.Name = "chkEnabled";
			this.chkEnabled.Size = new System.Drawing.Size(68, 19);
			this.chkEnabled.TabIndex = 0;
			this.chkEnabled.Text = "Enabled";
			this.chkEnabled.UseVisualStyleBackColor = true;
			this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
			// 
			// AttackingUnitControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tlpMain);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Name = "AttackingUnitControl";
			this.Size = new System.Drawing.Size(249, 222);
			this.Load += new System.EventHandler(this.AttackingUnitControl_Load);
			this.tlpMain.ResumeLayout(false);
			this.tlpMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.Label lblAttacks;
		private System.Windows.Forms.Label lblAttackBonus;
		private System.Windows.Forms.Label lblDamageDice;
		private System.Windows.Forms.Label lblDamageBonus;
		private System.Windows.Forms.TextBox txtAttacks;
		private System.Windows.Forms.TextBox txtAttackBonus;
		private System.Windows.Forms.TextBox txtDamageBonus;
		private System.Windows.Forms.Label lblDiceMultiplier;
		private System.Windows.Forms.TextBox txtDiceMultiplier;
		private System.Windows.Forms.Label lblTotalDamageMultiplier;
		private System.Windows.Forms.TextBox txtTotalDamageMultiplier;
		private System.Windows.Forms.ComboBox cboDamageDice;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.CheckBox chkEnabled;
	}
}
