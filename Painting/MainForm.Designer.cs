namespace Painting
{
	partial class MainForm
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
			this.btnMaximize = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 127);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(219, 40);
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
			// btnMaximize
			// 
			this.btnMaximize.Location = new System.Drawing.Point(12, 185);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Size = new System.Drawing.Size(115, 33);
			this.btnMaximize.TabIndex = 4;
			this.btnMaximize.Text = "Развернуть";
			this.btnMaximize.UseVisualStyleBackColor = true;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Location = new System.Drawing.Point(133, 185);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(98, 33);
			this.btnMinimize.TabIndex = 5;
			this.btnMinimize.Text = "Свернуть";
			this.btnMinimize.UseVisualStyleBackColor = true;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(252, 185);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(185, 33);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.Text = "Обновить изображение";
			this.btnRefresh.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 571);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.btnMaximize);
			this.Controls.Add(this.selectFolder);
			this.Controls.Add(this.tbFolder);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FolderBrowserDialog folderDialog;
		private System.Windows.Forms.TextBox tbFolder;
		private System.Windows.Forms.Button selectFolder;
		private System.Windows.Forms.Button btnMaximize;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.Button btnRefresh;
	}
}

