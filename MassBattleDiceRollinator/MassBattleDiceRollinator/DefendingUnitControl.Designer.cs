namespace MassBattleDiceRollinator
{
	partial class DefendingUnitControl
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblDamageThreshold = new System.Windows.Forms.Label();
			this.chkCharacter = new System.Windows.Forms.CheckBox();
			this.txtDamageThreshold = new System.Windows.Forms.TextBox();
			this.lblHitPoints = new System.Windows.Forms.Label();
			this.txtHitPoints = new System.Windows.Forms.TextBox();
			this.txtArmourClass = new System.Windows.Forms.TextBox();
			this.txtSize = new System.Windows.Forms.TextBox();
			this.lblArmourClass = new System.Windows.Forms.Label();
			this.lblSize = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.lblDamageThreshold, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.chkCharacter, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.txtDamageThreshold, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.lblHitPoints, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.txtHitPoints, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.txtArmourClass, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtSize, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblArmourClass, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblSize, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 7);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(247, 273);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblDamageThreshold
			// 
			this.lblDamageThreshold.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDamageThreshold.AutoSize = true;
			this.lblDamageThreshold.Location = new System.Drawing.Point(3, 134);
			this.lblDamageThreshold.Name = "lblDamageThreshold";
			this.lblDamageThreshold.Size = new System.Drawing.Size(107, 15);
			this.lblDamageThreshold.TabIndex = 0;
			this.lblDamageThreshold.Text = "Damage Threshold";
			// 
			// chkCharacter
			// 
			this.chkCharacter.AutoSize = true;
			this.chkCharacter.Location = new System.Drawing.Point(3, 105);
			this.chkCharacter.Name = "chkCharacter";
			this.chkCharacter.Size = new System.Drawing.Size(77, 19);
			this.chkCharacter.TabIndex = 2;
			this.chkCharacter.Text = "Character";
			this.chkCharacter.UseVisualStyleBackColor = true;
			this.chkCharacter.CheckedChanged += new System.EventHandler(this.chkCharacter_CheckedChanged);
			// 
			// txtDamageThreshold
			// 
			this.txtDamageThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDamageThreshold.Location = new System.Drawing.Point(144, 130);
			this.txtDamageThreshold.Name = "txtDamageThreshold";
			this.txtDamageThreshold.Size = new System.Drawing.Size(100, 23);
			this.txtDamageThreshold.TabIndex = 1;
			// 
			// lblHitPoints
			// 
			this.lblHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblHitPoints.AutoSize = true;
			this.lblHitPoints.Location = new System.Drawing.Point(3, 163);
			this.lblHitPoints.Name = "lblHitPoints";
			this.lblHitPoints.Size = new System.Drawing.Size(59, 15);
			this.lblHitPoints.TabIndex = 0;
			this.lblHitPoints.Text = "Hit Points";
			// 
			// txtHitPoints
			// 
			this.txtHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHitPoints.Location = new System.Drawing.Point(144, 159);
			this.txtHitPoints.Name = "txtHitPoints";
			this.txtHitPoints.Size = new System.Drawing.Size(100, 23);
			this.txtHitPoints.TabIndex = 1;
			// 
			// txtArmourClass
			// 
			this.txtArmourClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtArmourClass.Location = new System.Drawing.Point(144, 54);
			this.txtArmourClass.Name = "txtArmourClass";
			this.txtArmourClass.Size = new System.Drawing.Size(100, 23);
			this.txtArmourClass.TabIndex = 1;
			// 
			// txtSize
			// 
			this.txtSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSize.Location = new System.Drawing.Point(144, 25);
			this.txtSize.Name = "txtSize";
			this.txtSize.Size = new System.Drawing.Size(100, 23);
			this.txtSize.TabIndex = 3;
			// 
			// lblArmourClass
			// 
			this.lblArmourClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblArmourClass.AutoSize = true;
			this.lblArmourClass.Location = new System.Drawing.Point(3, 58);
			this.lblArmourClass.Name = "lblArmourClass";
			this.lblArmourClass.Size = new System.Drawing.Size(78, 15);
			this.lblArmourClass.TabIndex = 0;
			this.lblArmourClass.Text = "Armour Class";
			// 
			// lblSize
			// 
			this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSize.AutoSize = true;
			this.lblSize.Location = new System.Drawing.Point(3, 29);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(27, 15);
			this.lblSize.TabIndex = 0;
			this.lblSize.Text = "Size";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Control;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Location = new System.Drawing.Point(3, 3);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 16);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "[[Unit Name]]";
			// 
			// textBox3
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.textBox3, 2);
			this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox3.Location = new System.Drawing.Point(3, 188);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(241, 82);
			this.textBox3.TabIndex = 8;
			// 
			// DefendingUnitControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Name = "DefendingUnitControl";
			this.Size = new System.Drawing.Size(247, 273);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblArmourClass;
		private System.Windows.Forms.Label lblDamageThreshold;
		private System.Windows.Forms.TextBox txtArmourClass;
		private System.Windows.Forms.TextBox txtDamageThreshold;
		private System.Windows.Forms.CheckBox chkCharacter;
		private System.Windows.Forms.Label lblHitPoints;
		private System.Windows.Forms.TextBox txtHitPoints;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.Label lblSize;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
	}
}
