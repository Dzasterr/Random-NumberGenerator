namespace Winforms0000
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.MinLabel = new System.Windows.Forms.Label();
			this.MinInput = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MaxInput = new System.Windows.Forms.TextBox();
			this.MaxLabel = new System.Windows.Forms.Label();
			this.OutputLabel = new System.Windows.Forms.Label();
			this.GenButton = new System.Windows.Forms.Button();
			this.useFractions = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// MinLabel
			// 
			this.MinLabel.AutoSize = true;
			this.MinLabel.Location = new System.Drawing.Point(13, 13);
			this.MinLabel.Name = "MinLabel";
			this.MinLabel.Size = new System.Drawing.Size(30, 17);
			this.MinLabel.TabIndex = 0;
			this.MinLabel.Text = "Min";
			// 
			// MinInput
			// 
			this.MinInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MinInput.Location = new System.Drawing.Point(50, 13);
			this.MinInput.Name = "MinInput";
			this.MinInput.Size = new System.Drawing.Size(202, 22);
			this.MinInput.TabIndex = 1;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// MaxInput
			// 
			this.MaxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MaxInput.Location = new System.Drawing.Point(50, 41);
			this.MaxInput.Name = "MaxInput";
			this.MaxInput.Size = new System.Drawing.Size(202, 22);
			this.MaxInput.TabIndex = 4;
			// 
			// MaxLabel
			// 
			this.MaxLabel.AutoSize = true;
			this.MaxLabel.Location = new System.Drawing.Point(13, 41);
			this.MaxLabel.Name = "MaxLabel";
			this.MaxLabel.Size = new System.Drawing.Size(33, 17);
			this.MaxLabel.TabIndex = 3;
			this.MaxLabel.Text = "Max";
			// 
			// OutputLabel
			// 
			this.OutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutputLabel.Location = new System.Drawing.Point(12, 106);
			this.OutputLabel.Name = "OutputLabel";
			this.OutputLabel.Size = new System.Drawing.Size(240, 36);
			this.OutputLabel.TabIndex = 5;
			this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GenButton
			// 
			this.GenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GenButton.Location = new System.Drawing.Point(12, 158);
			this.GenButton.MinimumSize = new System.Drawing.Size(214, 36);
			this.GenButton.Name = "GenButton";
			this.GenButton.Size = new System.Drawing.Size(239, 36);
			this.GenButton.TabIndex = 6;
			this.GenButton.Text = "Generate";
			this.GenButton.UseVisualStyleBackColor = true;
			this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
			// 
			// useFractions
			// 
			this.useFractions.AutoSize = true;
			this.useFractions.Location = new System.Drawing.Point(16, 69);
			this.useFractions.Name = "useFractions";
			this.useFractions.Size = new System.Drawing.Size(250, 21);
			this.useFractions.TabIndex = 7;
			this.useFractions.Text = "Use Fractions (To 1 decimal place)";
			this.useFractions.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(264, 206);
			this.Controls.Add(this.useFractions);
			this.Controls.Add(this.GenButton);
			this.Controls.Add(this.OutputLabel);
			this.Controls.Add(this.MaxInput);
			this.Controls.Add(this.MaxLabel);
			this.Controls.Add(this.MinInput);
			this.Controls.Add(this.MinLabel);
			this.MinimumSize = new System.Drawing.Size(282, 253);
			this.Name = "Form1";
			this.Text = "RNG";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label MinLabel;
		private System.Windows.Forms.TextBox MinInput;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox MaxInput;
		private System.Windows.Forms.Label MaxLabel;
		private System.Windows.Forms.Label OutputLabel;
		private System.Windows.Forms.Button GenButton;
		private System.Windows.Forms.CheckBox useFractions;
	}
}

