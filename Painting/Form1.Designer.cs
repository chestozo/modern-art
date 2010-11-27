namespace Painting
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
			this.button1 = new System.Windows.Forms.Button();
			this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.tbFolder = new System.Windows.Forms.TextBox();
			this.selectFolder = new System.Windows.Forms.Button();
			this.cbAutoLoad = new System.Windows.Forms.CheckBox();
			this.btnMaximize = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 159);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(175, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Показать изображение";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbFolder
			// 
			this.tbFolder.Location = new System.Drawing.Point(12, 12);
			this.tbFolder.Name = "tbFolder";
			this.tbFolder.ReadOnly = true;
			this.tbFolder.Size = new System.Drawing.Size(610, 22);
			this.tbFolder.TabIndex = 1;
			// 
			// selectFolder
			// 
			this.selectFolder.Location = new System.Drawing.Point(628, 11);
			this.selectFolder.Name = "selectFolder";
			this.selectFolder.Size = new System.Drawing.Size(75, 23);
			this.selectFolder.TabIndex = 2;
			this.selectFolder.Text = "...";
			this.selectFolder.UseVisualStyleBackColor = true;
			this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
			// 
			// cbAutoLoad
			// 
			this.cbAutoLoad.AutoSize = true;
			this.cbAutoLoad.Location = new System.Drawing.Point(12, 49);
			this.cbAutoLoad.Name = "cbAutoLoad";
			this.cbAutoLoad.Size = new System.Drawing.Size(345, 21);
			this.cbAutoLoad.TabIndex = 3;
			this.cbAutoLoad.Text = "Автоматически подгружать новое изображение";
			this.cbAutoLoad.UseVisualStyleBackColor = true;
			this.cbAutoLoad.CheckedChanged += new System.EventHandler(this.cbAutoLoad_CheckedChanged);
			// 
			// btnMaximize
			// 
			this.btnMaximize.Location = new System.Drawing.Point(193, 159);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Size = new System.Drawing.Size(115, 33);
			this.btnMaximize.TabIndex = 4;
			this.btnMaximize.Text = "Развернуть";
			this.btnMaximize.UseVisualStyleBackColor = true;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 204);
			this.Controls.Add(this.btnMaximize);
			this.Controls.Add(this.cbAutoLoad);
			this.Controls.Add(this.selectFolder);
			this.Controls.Add(this.tbFolder);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FolderBrowserDialog folderDialog;
		private System.Windows.Forms.TextBox tbFolder;
		private System.Windows.Forms.Button selectFolder;
		private System.Windows.Forms.CheckBox cbAutoLoad;
		private System.Windows.Forms.Button btnMaximize;
	}
}

