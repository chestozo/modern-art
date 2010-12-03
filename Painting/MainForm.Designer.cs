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
			this.btnShowImage = new System.Windows.Forms.Button();
			this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.tbFolder = new System.Windows.Forms.TextBox();
			this.selectFolder = new System.Windows.Forms.Button();
			this.btnMaximize = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nudArchSize = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbRemoveArchiveAfterCopy = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.nudArchSize)).BeginInit();
			this.SuspendLayout();
			// 
			// btnShowImage
			// 
			this.btnShowImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowImage.Location = new System.Drawing.Point(15, 102);
			this.btnShowImage.Name = "btnShowImage";
			this.btnShowImage.Size = new System.Drawing.Size(219, 40);
			this.btnShowImage.TabIndex = 0;
			this.btnShowImage.Text = "Показать изображение";
			this.btnShowImage.UseVisualStyleBackColor = true;
			this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
			// 
			// tbFolder
			// 
			this.tbFolder.Location = new System.Drawing.Point(15, 29);
			this.tbFolder.Name = "tbFolder";
			this.tbFolder.ReadOnly = true;
			this.tbFolder.Size = new System.Drawing.Size(610, 22);
			this.tbFolder.TabIndex = 1;
			// 
			// selectFolder
			// 
			this.selectFolder.Location = new System.Drawing.Point(631, 28);
			this.selectFolder.Name = "selectFolder";
			this.selectFolder.Size = new System.Drawing.Size(75, 23);
			this.selectFolder.TabIndex = 2;
			this.selectFolder.Text = "...";
			this.selectFolder.UseVisualStyleBackColor = true;
			this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
			// 
			// btnMaximize
			// 
			this.btnMaximize.Location = new System.Drawing.Point(12, 195);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Size = new System.Drawing.Size(115, 33);
			this.btnMaximize.TabIndex = 4;
			this.btnMaximize.Text = "Развернуть";
			this.btnMaximize.UseVisualStyleBackColor = true;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Location = new System.Drawing.Point(133, 195);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(98, 33);
			this.btnMinimize.TabIndex = 5;
			this.btnMinimize.Text = "Свернуть";
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(240, 106);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(185, 33);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.Text = "Обновить изображение";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(326, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Шаг1: Папка, куда кладутся новые фотографии:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(319, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Шаг 3: Развернуть изображение на весь экран:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(258, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Шаг 2: Показать окно с фотографией:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 260);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "Дополнительные настройки:";
			// 
			// nudArchSize
			// 
			this.nudArchSize.Location = new System.Drawing.Point(18, 316);
			this.nudArchSize.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.nudArchSize.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudArchSize.Name = "nudArchSize";
			this.nudArchSize.Size = new System.Drawing.Size(120, 22);
			this.nudArchSize.TabIndex = 11;
			this.nudArchSize.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.nudArchSize.ValueChanged += new System.EventHandler(this.nudArchSize_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(224, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Размер фотографии для архива:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(144, 318);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "пикселей";
			// 
			// cbRemoveArchiveAfterCopy
			// 
			this.cbRemoveArchiveAfterCopy.AutoSize = true;
			this.cbRemoveArchiveAfterCopy.Checked = true;
			this.cbRemoveArchiveAfterCopy.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRemoveArchiveAfterCopy.Location = new System.Drawing.Point(18, 354);
			this.cbRemoveArchiveAfterCopy.Name = "cbRemoveArchiveAfterCopy";
			this.cbRemoveArchiveAfterCopy.Size = new System.Drawing.Size(419, 21);
			this.cbRemoveArchiveAfterCopy.TabIndex = 14;
			this.cbRemoveArchiveAfterCopy.Text = "После копирования архива удалять файлы из компьютера";
			this.cbRemoveArchiveAfterCopy.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 571);
			this.Controls.Add(this.cbRemoveArchiveAfterCopy);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nudArchSize);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.btnMaximize);
			this.Controls.Add(this.selectFolder);
			this.Controls.Add(this.tbFolder);
			this.Controls.Add(this.btnShowImage);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.nudArchSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnShowImage;
		private System.Windows.Forms.FolderBrowserDialog folderDialog;
		private System.Windows.Forms.TextBox tbFolder;
		private System.Windows.Forms.Button selectFolder;
		private System.Windows.Forms.Button btnMaximize;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudArchSize;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox cbRemoveArchiveAfterCopy;
	}
}

