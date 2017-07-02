/*
 * Created by SharpDevelop.
 * User: Theone
 * Date: 2017-07-01
 * Time: 09:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace IBD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox servername;
		private System.Windows.Forms.TextBox database;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button loginToDB;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.TextBox surnameBox;
		private System.Windows.Forms.TextBox positionBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dateOfEmployment;
		private System.Windows.Forms.NumericUpDown salaryBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.NumericUpDown idBox;
		private System.Windows.Forms.Label label10;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.servername = new System.Windows.Forms.TextBox();
			this.database = new System.Windows.Forms.TextBox();
			this.username = new System.Windows.Forms.TextBox();
			this.deleteButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.TextBox();
			this.loginToDB = new System.Windows.Forms.Button();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.surnameBox = new System.Windows.Forms.TextBox();
			this.positionBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dateOfEmployment = new System.Windows.Forms.DateTimePicker();
			this.salaryBox = new System.Windows.Forms.NumericUpDown();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idBox = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.salaryBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.idBox)).BeginInit();
			this.SuspendLayout();
			// 
			// servername
			// 
			this.servername.Location = new System.Drawing.Point(228, 7);
			this.servername.Name = "servername";
			this.servername.Size = new System.Drawing.Size(157, 20);
			this.servername.TabIndex = 0;
			// 
			// database
			// 
			this.database.Location = new System.Drawing.Point(228, 33);
			this.database.Name = "database";
			this.database.Size = new System.Drawing.Size(157, 20);
			this.database.TabIndex = 1;
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(228, 59);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(157, 20);
			this.username.TabIndex = 2;
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(151, 307);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(100, 27);
			this.deleteButton.TabIndex = 7;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(17, 307);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(100, 27);
			this.updateButton.TabIndex = 8;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(282, 307);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(100, 27);
			this.addButton.TabIndex = 9;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Nazwa serwera";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(210, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Baza danych";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(17, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(210, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Nazwa użytkownika";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(17, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(210, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "Hasło użytkownika";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(228, 82);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(157, 20);
			this.password.TabIndex = 13;
			// 
			// loginToDB
			// 
			this.loginToDB.Location = new System.Drawing.Point(228, 114);
			this.loginToDB.Name = "loginToDB";
			this.loginToDB.Size = new System.Drawing.Size(156, 26);
			this.loginToDB.TabIndex = 15;
			this.loginToDB.Text = "Login";
			this.loginToDB.UseVisualStyleBackColor = true;
			this.loginToDB.Click += new System.EventHandler(this.LoginToDBClick);
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(229, 176);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(156, 20);
			this.nameBox.TabIndex = 16;
			// 
			// surnameBox
			// 
			this.surnameBox.Location = new System.Drawing.Point(229, 202);
			this.surnameBox.Name = "surnameBox";
			this.surnameBox.Size = new System.Drawing.Size(156, 20);
			this.surnameBox.TabIndex = 17;
			// 
			// positionBox
			// 
			this.positionBox.Location = new System.Drawing.Point(229, 228);
			this.positionBox.Name = "positionBox";
			this.positionBox.Size = new System.Drawing.Size(156, 20);
			this.positionBox.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(211, 20);
			this.label5.TabIndex = 21;
			this.label5.Text = "Imie";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 202);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(211, 20);
			this.label6.TabIndex = 22;
			this.label6.Text = "Nazwisko";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 227);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(211, 20);
			this.label7.TabIndex = 23;
			this.label7.Text = "Stanowisko";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 253);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(211, 20);
			this.label8.TabIndex = 24;
			this.label8.Text = "Pensja";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 280);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(211, 20);
			this.label9.TabIndex = 25;
			this.label9.Text = "Data zatrudnienia";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateOfEmployment
			// 
			this.dateOfEmployment.CustomFormat = "yyyy-MM-dd";
			this.dateOfEmployment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateOfEmployment.Location = new System.Drawing.Point(229, 280);
			this.dateOfEmployment.Name = "dateOfEmployment";
			this.dateOfEmployment.Size = new System.Drawing.Size(156, 20);
			this.dateOfEmployment.TabIndex = 26;
			// 
			// salaryBox
			// 
			this.salaryBox.DecimalPlaces = 2;
			this.salaryBox.Location = new System.Drawing.Point(229, 255);
			this.salaryBox.Maximum = new decimal(new int[] {
			1000000,
			0,
			0,
			0});
			this.salaryBox.Name = "salaryBox";
			this.salaryBox.Size = new System.Drawing.Size(156, 20);
			this.salaryBox.TabIndex = 27;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(19, 340);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(367, 225);
			this.dataGridView1.TabIndex = 29;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1SelectionChanged);
			// 
			// idBox
			// 
			this.idBox.Location = new System.Drawing.Point(229, 150);
			this.idBox.Maximum = new decimal(new int[] {
			1000000,
			0,
			0,
			0});
			this.idBox.Name = "idBox";
			this.idBox.Size = new System.Drawing.Size(153, 20);
			this.idBox.TabIndex = 31;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(12, 150);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(211, 20);
			this.label10.TabIndex = 32;
			this.label10.Text = "Id";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 580);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.idBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.salaryBox);
			this.Controls.Add(this.dateOfEmployment);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.positionBox);
			this.Controls.Add(this.surnameBox);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.loginToDB);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.password);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.username);
			this.Controls.Add(this.database);
			this.Controls.Add(this.servername);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(420, 618);
			this.MinimumSize = new System.Drawing.Size(420, 618);
			this.Name = "MainForm";
			this.Text = "IBD";
			((System.ComponentModel.ISupportInitialize)(this.salaryBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.idBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
