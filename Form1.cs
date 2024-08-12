using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace taskadonet3
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter authorsSqlDataAdapter;
        SqlDataAdapter booksSqlDataAdapter;
        DataSet authorsDataSet;
        DataSet booksDataSet;
        SqlCommandBuilder sqlCommandBuilder;
        string connectionString = @"Server = (localdb)\MSSQLLocalDB; 
    Integrated Security = SSPI; Database = Library";
        int id = 1;
        public Form1()
        {
            InitializeComponent();
            authorsDataSet = new DataSet();
            booksDataSet = new DataSet();
            sqlConnection = new SqlConnection(connectionString);
            string getAuthorsQuery = @"USE [Library];

SELECT FirstName + ' ' + LastName AS FullName, Id
FROM Authors;";
            authorsSqlDataAdapter = new SqlDataAdapter(getAuthorsQuery, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(authorsSqlDataAdapter);
            authorsSqlDataAdapter.Fill(authorsDataSet, "authors");
            List<string> authors = new List<string>();
            foreach (DataRow row in authorsDataSet.Tables["authors"].Rows)
            {
                authors.Add(row["FullName"].ToString());
            }
            comboBox1.DataSource = authors;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in authorsDataSet.Tables["authors"].Rows)
            {
                if (comboBox1.Text == row["FullName"].ToString())
                {
                    id = (int)row["Id"];
                    break;
                }
            }
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            booksDataSet.Clear();
            string getBooksByAuthorQuery = @$"USE [Library];

SELECT [Name], [Pages], [YearPress], [Comment], [Quantity] 
FROM Books
WHERE Id_Author = {id};";
            booksSqlDataAdapter = new SqlDataAdapter(getBooksByAuthorQuery, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(booksSqlDataAdapter);
            booksSqlDataAdapter.Fill(booksDataSet, "books");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = booksDataSet.Tables["books"];
        }
    }
}
