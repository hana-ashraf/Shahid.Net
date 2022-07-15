using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace WindowsFormsApp1
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        OracleDataAdapter adapter1;
        DataTable dt;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl ; User Id=scott; Password=tiger;";

            if (isvalid())
            {
                string cmdstr = "SELECT *from my_movies where MemberID =(select client_id from client where client_email=:e and client_pass=:p)";
                string cmd = "select client_email , client_pass from client where client_email=:e and client_pass=:p ";
                adapter1 = new OracleDataAdapter(cmd, constr);
                adapter = new OracleDataAdapter(cmdstr, constr);
                adapter.SelectCommand.Parameters.Add("e", textBox1.Text);
                adapter.SelectCommand.Parameters.Add("p", textBox2.Text);
                adapter1.SelectCommand.Parameters.Add("e", textBox1.Text);
                adapter1.SelectCommand.Parameters.Add("p", textBox2.Text);


                dt = new DataTable();
                adapter1.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    ds = new DataSet();

                    adapter.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("invalid email or password", "Error");
                    dataGridView1.DataSource = "";

                }

            }

        }
        private bool isvalid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid email please", "Error");
                textBox2.Clear();
                return false;
            }
            else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid password please", "Error");
                textBox1.Clear();
                return false;
            }
            return true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Updated Successfully");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 n = new Form1();
            n.ShowDialog();
        }
    }
}
