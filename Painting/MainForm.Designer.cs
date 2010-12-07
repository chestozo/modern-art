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
			this.nudArchSize = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbRemoveImagesAfterArchive = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.nudArchSize)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnShowImage
			// 
			this.btnShowImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowImage.Location = new System.Drawing.Point(15, 32);
			this.btnShowImage.Name = "btnShowImage";
			this.btnShowImage.Size = new System.Drawing.Size(219, 40);
			this.btnShowImage.TabIndex = 0;
			this.btnShowImage.Text = "Показать изображение";
			this.btnShowImage.UseVisualStyleBackColor = true;
			this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
			// 
			// tbFolder
			// 
			this.tbFolder.Location = new System.Drawing.Point(9, 38);
			this.tbFolder.Name = "tbFolder";
			this.tbFolder.ReadOnly = true;
			this.tbFolder.Size = new System.Drawing.Size(610, 22);
			this.tbFolder.TabIndex = 1;
			this.tbFolder.TextChanged += new System.EventHandler(this.tbFolder_TextChanged);
			// 
			// selectFolder
			// 
			this.selectFolder.Location = new System.Drawing.Point(625, 37);
			this.selectFolder.Name = "selectFolder";
			this.selectFolder.Size = new System.Drawing.Size(75, 23);
			this.selectFolder.TabIndex = 2;
			this.selectFolder.Text = "...";
			this.selectFolder.UseVisualStyleBackColor = true;
			this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
			// 
			// btnMaximize
			// 
			this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMaximize.Location = new System.Drawing.Point(15, 117);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Size = new System.Drawing.Size(115, 33);
			this.btnMaximize.TabIndex = 4;
			this.btnMaximize.Text = "Развернуть";
			this.btnMaximize.UseVisualStyleBackColor = true;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Location = new System.Drawing.Point(136, 117);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(98, 33);
			this.btnMinimize.TabIndex = 5;
			this.btnMinimize.Text = "Свернуть";
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(240, 36);
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
			this.label1.Location = new System.Drawing.Point(6, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(302, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "1. Папка, куда кладутся новые фотографии:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(319, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Шаг 2: Развернуть изображение на весь экран:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(258, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Шаг 1: Показать окно с фотографией:";
			// 
			// nudArchSize
			// 
			this.nudArchSize.Location = new System.Drawing.Point(9, 92);
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
			this.label5.Location = new System.Drawing.Point(6, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(240, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "2. Размер фотографии для архива:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(135, 94);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "пикселей";
			// 
			// cbRemoveImagesAfterArchive
			// 
			this.cbRemoveImagesAfterArchive.AutoSize = true;
			this.cbRemoveImagesAfterArchive.Checked = true;
			this.cbRemoveImagesAfterArchive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRemoveImagesAfterArchive.Location = new System.Drawing.Point(9, 159);
			this.cbRemoveImagesAfterArchive.Name = "cbRemoveImagesAfterArchive";
			this.cbRemoveImagesAfterArchive.Size = new System.Drawing.Size(110, 21);
			this.cbRemoveImagesAfterArchive.TabIndex = 14;
			this.cbRemoveImagesAfterArchive.Text = "Да, удалять";
			this.cbRemoveImagesAfterArchive.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 135);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(281, 17);
			this.label7.TabIndex = 15;
			this.label7.Text = "3. Удалять фотографии после архивации";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cbRemoveImagesAfterArchive);
			this.groupBox1.Controls.Add(this.tbFolder);
			this.groupBox1.Controls.Add(this.selectFolder);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.nudArchSize);
			this.groupBox1.Location = new System.Drawing.Point(7, 213);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(739, 201);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Допонительные настройки";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 425);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.btnMaximize);
			this.Controls.Add(this.btnShowImage);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.nudArchSize)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.NumericUpDown nudArchSize;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox cbRemoveImagesAfterArchive;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

