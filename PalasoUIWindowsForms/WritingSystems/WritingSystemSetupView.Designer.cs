namespace Palaso.UI.WindowsForms.WritingSystems
{
	partial class WritingSystemSetupView
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this._treeView = new Palaso.UI.WindowsForms.WritingSystems.WSTree.WritingSystemTreeView();
			this._rfc4646 = new Palaso.UI.WindowsForms.Widgets.BetterLabel();
			this._languageName = new Palaso.UI.WindowsForms.Widgets.BetterLabel();
			this._propertiesTabControl = new Palaso.UI.WindowsForms.WritingSystems.WSPropertiesTabControl();
			this._buttonBar = new Palaso.UI.WindowsForms.WritingSystems.WSAddDuplicateMoreButtonBar();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			//
			// splitContainer1
			//
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			// splitContainer1.Panel1
			//
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			//
			// splitContainer1.Panel2
			//
			this.splitContainer1.Panel2.Controls.Add(this._buttonBar);
			this.splitContainer1.Size = new System.Drawing.Size(841, 461);
			this.splitContainer1.SplitterDistance = 422;
			this.splitContainer1.TabIndex = 2;
			//
			// splitContainer2
			//
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			//
			// splitContainer2.Panel1
			//
			this.splitContainer2.Panel1.Controls.Add(this._treeView);
			//
			// splitContainer2.Panel2
			//
			this.splitContainer2.Panel2.Controls.Add(this._rfc4646);
			this.splitContainer2.Panel2.Controls.Add(this._languageName);
			this.splitContainer2.Panel2.Controls.Add(this._propertiesTabControl);
			this.splitContainer2.Size = new System.Drawing.Size(841, 422);
			this.splitContainer2.SplitterDistance = 222;
			this.splitContainer2.SplitterWidth = 10;
			this.splitContainer2.TabIndex = 0;
			//
			// _treeView
			//
			this._treeView.BackColor = System.Drawing.Color.White;
			this._treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._treeView.Location = new System.Drawing.Point(0, 0);
			this._treeView.Name = "_treeView";
			this._treeView.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this._treeView.Size = new System.Drawing.Size(222, 422);
			this._treeView.TabIndex = 1;
			//
			// _rfc4646
			//
			this._rfc4646.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._rfc4646.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._rfc4646.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rfc4646.Location = new System.Drawing.Point(309, 4);
			this._rfc4646.Multiline = true;
			this._rfc4646.Name = "_rfc4646";
			this._rfc4646.ReadOnly = true;
			this._rfc4646.Size = new System.Drawing.Size(292, 20);
			this._rfc4646.TabIndex = 2;
			this._rfc4646.TabStop = false;
			this._rfc4646.Text = "foo-CN-variant1-a-extend1-x-wadefile";
			this._rfc4646.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			// _languageName
			//
			this._languageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._languageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._languageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._languageName.Location = new System.Drawing.Point(4, 4);
			this._languageName.Multiline = true;
			this._languageName.Name = "_languageName";
			this._languageName.ReadOnly = true;
			this._languageName.Size = new System.Drawing.Size(318, 20);
			this._languageName.TabIndex = 1;
			this._languageName.TabStop = false;
			this._languageName.Text = "Language Name";
			//
			// _propertiesTabControl
			//
			this._propertiesTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._propertiesTabControl.Location = new System.Drawing.Point(0, 30);
			this._propertiesTabControl.Name = "_propertiesTabControl";
			this._propertiesTabControl.Size = new System.Drawing.Size(609, 392);
			this._propertiesTabControl.TabIndex = 0;
			this._propertiesTabControl.Load += new System.EventHandler(this._propertiesTabControl_Load);
			//
			// _buttonBar
			//
			this._buttonBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._buttonBar.Location = new System.Drawing.Point(0, 4);
			this._buttonBar.Name = "_buttonBar";
			this._buttonBar.Size = new System.Drawing.Size(841, 31);
			this._buttonBar.TabIndex = 0;
			//
			// WritingSystemSetupView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "WritingSystemSetupView";
			this.Size = new System.Drawing.Size(841, 461);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private WSAddDuplicateMoreButtonBar _buttonBar;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private WSPropertiesTabControl _propertiesTabControl;
		private Palaso.UI.WindowsForms.WritingSystems.WSTree.WritingSystemTreeView _treeView;
		private Palaso.UI.WindowsForms.Widgets.BetterLabel _rfc4646;
		private Palaso.UI.WindowsForms.Widgets.BetterLabel _languageName;

	}
}