using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DbHomework
{
    public partial class hospitalTxt : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUU0K4S;Initial Catalog=Tutorial;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlDataAdapter adapter;
        SqlDataAdapter searchAdapter;
        SqlDataAdapter printAdapter;
        SqlDataAdapter deleteAdapter;
        SqlDataAdapter updateAdapter;
        DataTable dataTable;
        DataTable searchTable;
        DataTable printTable;
        DataTable deleteTable;
        DataTable updateTable;
            
        public hospitalTxt()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //cmd = new SqlCommand("insert into Doctor(DoctorName) values ('" + txtName.Text + "')",conn);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Data has been saved");
            //conn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //cmd = new SqlCommand("insert into Hospital(HospitalName,DoctorId) values ('" + textBox1.Text + "','" + textBox2.Text + "')", conn);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Data has been saved");
            //conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void doctorTxt_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {   
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
         
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}