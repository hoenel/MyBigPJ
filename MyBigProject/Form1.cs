using System.Data;
using System.Data.SqlClient;

namespace MyBigProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            dtgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTable.DataSource = GetAllnhanvien().Tables[0];
            //dtgvTable.DataMember = "staff";

        }
        //connectionString

        DataSet GetAllnhanvien()
        {
            DataSet dt = new DataSet();
            //SQL conn
            string query = "select * from staff";
            using (SqlConnection connection = new SqlConnection(ConnectionString.conn))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dt);

                connection.Close();
            }
            //SQL comment
            //SQL dataAdapter

            return dt;
        }

        
    }
}
