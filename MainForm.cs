/*
 * Created by SharpDevelop.
 * User: Theone
 * Date: 2017-07-01
 * Time: 09:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace IBD
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Initialization of global variables
		string id,name,surname,position,salary,date;
		
		public MainForm()
		{
			InitializeComponent();
		}
		//connection to database and inserting data to dataGridView
		public void downloadData(){	
			string connection = "SERVER=" + servername.Text + ";" + "DATABASE=" + database.Text + ";" + "UID=" + username.Text + ";" + "PASSWORD=" + password.Text + ";";
			
			string sqlCommand = "SELECT * FROM Pracownicy";
			
			MySqlConnection connectionToDatabase = new MySqlConnection(connection);
			//trying to connect using MySqlConnection if connected create table then create adapter from mysqlcommand and finally use adapter to fill data on datagrid
			try{
				connectionToDatabase.Open();
				
				using(MySqlCommand sqlCmd = new MySqlCommand(sqlCommand, connectionToDatabase)){
					DataTable dataTable = new DataTable();//creating new datatable used to store data from mysql database
					MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCmd);
					dataAdapter.Fill(dataTable);//transferring data from adapter fo datatable
					dataGridView1.DataSource = dataTable.DefaultView;//transferring datatable data to datasource
				}
			}
			catch(MySql.Data.MySqlClient.MySqlException ex)//if not connected then show error
			{
				MessageBox.Show("Błąd logowania", "Błąd");
			}
			connectionToDatabase.Close();//closing the connection to free memory
		}
		public void dataToInsert(){
			
			string connection = "SERVER=" + servername.Text + ";" + "DATABASE=" + database.Text + ";" + "UID=" + username.Text + ";" + "PASSWORD=" + password.Text + ";";
			
			MySqlConnection connectionToDatabase = new MySqlConnection(connection);
			
			//setting boxes text to variables for easy storage
			id = idBox.Text;
			name = nameBox.Text;
			surname = surnameBox.Text;
			position = positionBox.Text;
			salary = salaryBox.Text.Replace(",", ".");//There was a problem with MySql database readying salary string, because Mysql accepts only '.' as floating point where windows uses ',', so I had to change it using .Replace() function.
			date	= dateOfEmployment.Text;
			
			//trying to execute query that inserts into "pracownicy", if failed then shows error
			try{
				
				string sqlCmdInsert = "INSERT INTO `pracownicy` (`Id_pracownika`, `Imie`, `Nazwisko`, `Stanowisko`, `Pensja`, `Data_zatrudnienia`) VALUES ('"+ id + "', '" + name + "', '" + surname + "', '" + position + "', '" + salary + "', '" + date + "')";
				connectionToDatabase.Open();
				MySqlCommand command = connectionToDatabase.CreateCommand();
				command.CommandText = sqlCmdInsert;
				command.ExecuteNonQuery();
				
			}
			catch(MySql.Data.MySqlClient.MySqlException ex){
				MessageBox.Show("Błąd połączenia", "Błąd");
			}
			connectionToDatabase.Close();//closing the connection to free memory
			
		
		}
		public void dataToChange(){
			
			string connection = "SERVER=" + servername.Text + ";" + "DATABASE=" + database.Text + ";" + "UID=" + username.Text + ";" + "PASSWORD=" + password.Text + ";";
			
			MySqlConnection connectionToDatabase = new MySqlConnection(connection);
			
			
			id = idBox.Text;
			name = nameBox.Text;
			surname = surnameBox.Text;
			position = positionBox.Text;
			salary = salaryBox.Text.Replace(",", ".");//There was a problem with MySql database readying salary string, because Mysql accepts only '.' as floating point where windows uses ',', so I had to change it using .Replace() function.
			date = dateOfEmployment.Text;
			if(dataGridView1.SelectedRows.Count > 0){//if selected then send sql command, to prevent sending UPDATE command without id
			try{
				//literally the same code as dataToInsert, but instead of INSERTING we are UPDATING database record of selected row by id
				int selectedId = dataGridView1.CurrentCell.RowIndex;
				string sqlCmdInsert = "UPDATE pracownicy SET Id_pracownika = '" + id + "', Imie = '" + name + "', Nazwisko = '" + surname + "', Stanowisko = '" + position + "', Pensja = '" + salary + "', Data_zatrudnienia = '" + date + "' WHERE id_pracownika =" + selectedId;
				connectionToDatabase.Open();
				MySqlCommand command = connectionToDatabase.CreateCommand();
				command.CommandText = sqlCmdInsert;
				command.ExecuteNonQuery();
				
				
			}
			catch(MySql.Data.MySqlClient.MySqlException ex)//If not connection problem then show error
			{
				MessageBox.Show("Błąd połączenia", "Błąd");
			}
			connectionToDatabase.Close();//closing the connection to free memory
			}
			else//When no rows are selected display error
			{
				MessageBox.Show("Błąd, nie wybrano kolumny do zmiany", "Błąd");
			}
			
		}
		public void dataToDelete(){
			
			string connection = "SERVER=" + servername.Text + ";" + "DATABASE=" + database.Text + ";" + "UID=" + username.Text + ";" + "PASSWORD=" + password.Text + ";";
			
			MySqlConnection connectionToDatabase = new MySqlConnection(connection);
			
			
			id = idBox.Text;
			name = nameBox.Text;
			surname = surnameBox.Text;
			position = positionBox.Text;
			salary = salaryBox.Text.Replace(",", ".");//There was a problem with MySql database readying salary string, because Mysql accepts only '.' as floating point where windows uses ',', so I had to change it using .Replace() function.
			date = dateOfEmployment.Text;
			if(dataGridView1.SelectedRows.Count > 0)//To prevent executing when no rows are selected
			{
			try{
				//literally the same code as dataToInsert, but instead of INSERTING we are DELETING database record of selected row by id
				int selectedId = dataGridView1.CurrentCell.RowIndex;
				string sqlCmdInsert = "DELETE FROM pracownicy WHERE id_pracownika =" + selectedId;
				connectionToDatabase.Open();
				MySqlCommand command = connectionToDatabase.CreateCommand();
				command.CommandText = sqlCmdInsert;
				command.ExecuteNonQuery();
				
				
			}
			catch(MySql.Data.MySqlClient.MySqlException ex)//When no connection, show connection error
			{
				MessageBox.Show("Błąd połączenia", "Błąd");
			}
			connectionToDatabase.Close();//closing the connection to free memory
			}
			else//If no rows are selected, show error
			{
				MessageBox.Show("Błąd, nie wybrano kolumny do usunięcia", "Błąd");
			}
			
		}
		
		
		
		
		void LoginToDBClick(object sender, EventArgs e){
			downloadData();//calling out function
		}
		void AddButtonClick(object sender, EventArgs e)
		{
			dataToInsert();//calling out function
			
		}
		void UpdateButtonClick(object sender, EventArgs e)
		{
			dataToChange();//calling out function
			
		}
		void DeleteButtonClick(object sender, EventArgs e)
		{
			dataToDelete();//calling out function
		}
		void DataGridView1SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)//When selection changed for each row update variables 
		    {
		        idBox.Text = row.Cells[0].Value.ToString();
		        nameBox.Text = row.Cells[1].Value.ToString();
		        surnameBox.Text = row.Cells[2].Value.ToString();
		        positionBox.Text = row.Cells[3].Value.ToString();
		        salaryBox.Text = row.Cells[4].Value.ToString();
		        dateOfEmployment.Text = row.Cells[5].Value.ToString();
		    }
		}

	}
}
