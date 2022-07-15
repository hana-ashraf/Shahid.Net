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
using WindowsFormsApp1;

namespace swproject
{
    public partial class Form_Connected : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;"; 
        OracleConnection conn;
        string zz;
        string selected_series;
        string selected_move;
        string selected_Tvshow;

        public Form_Connected()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select SeriesTitle  from Series";
            cmd.CommandType = CommandType.Text;
            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_ST.Items.Add(dr[0]);
                }
                dr.Close();




                cmd.CommandText = "select TVshowTitle  from Tvshow";
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_TT.Items.Add(dr[0]);
                }
                dr.Close();
            }
            catch
            {
                Console.Write("Error occurred.");

            }

        }

        private void cmb_ST_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select SeriesID,ReleaseDate,SeriesCategory from Series where SeriesTitle =:title";
            c.CommandType = CommandType.Text;
            try
            {
                c.Parameters.Add("title", cmb_ST.SelectedItem.ToString());
                OracleDataReader dr = c.ExecuteReader();
                selected_series = cmb_ST.SelectedItem.ToString();
                if (dr.Read())
                {
                    txt_SID.Text = dr[0].ToString();
                    Date_S.Text = dr[1].ToString();
                    TXT_SC.Text = dr[2].ToString();

                }
                dr.Close();
            }
            catch
            {
                Console.Write("Error occurred.");

            }
        }
        
        private void cmb_TT_SelectedIndexChanged(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "GETTITLE";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("title", cmb_TT.SelectedItem.ToString());
            try
            {
                zz = cmb_TT.SelectedItem.ToString();
                c.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                c.Parameters.Add("datecreate", OracleDbType.Date, ParameterDirection.Output);
                c.Parameters.Add("category", OracleDbType.Varchar2, 32767).Direction = ParameterDirection.Output;
                /*
                            OracleDataReader dr = c.ExecuteReader();
                            if (dr.Read()) { 
                                // cmb_TID.Items.Add(cmb_TID.Text);
                                cmb_TID.Text = c.Parameters["id"].Value.ToString();
                            }
                            */
                int r = c.ExecuteNonQuery();
                Console.WriteLine("*************");
                Console.WriteLine(r);
                Console.WriteLine("****************");
                // if (r != -1)
                // {
                txt_TID.Text = c.Parameters["id"].Value.ToString();
                Date_T.Text = c.Parameters["datecreate"].Value.ToString();
                TXT_TC.Text = c.Parameters["category"].Value.ToString();
                //}


            }
            catch
            {
                Console.Write("Error occurred.");

            }

        }
        ///Select
        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Series(SeriesID,SeriesTitle,ReleaseDate,SeriesCategory) values(:id,:title,:datecreate,:category)";
            try
            {
                cmd.Parameters.Add("id", txt_SID.Text);
                cmd.Parameters.Add("title", cmb_ST.Text);
                cmd.Parameters.Add("datecreate", Convert.ToDateTime(Date_S.Text));
                cmd.Parameters.Add("category", TXT_SC.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    cmb_ST.Items.Add(cmb_ST.Text);
                    MessageBox.Show("New series has been successfully added! ");
                    txt_SID.Text = "";
                    TXT_SC.Text = "";
                    Date_S.Text = "";
                    cmb_ST.Text = "";
                }
            }
            catch
            {
                Console.Write("Error occurred.");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into MOVIES(FILMID,FILMTITLE,RELEASEDATE,FILMCATEGORY) values(:iddd,:titllle,:datttte,:categooory)";
            cmd.Parameters.Add("iddd", txt_MID.Text);
            cmd.Parameters.Add("titllle", cmb_MT.Text);
            cmd.Parameters.Add("datttte", Convert.ToDateTime(Date_M.Text));
            cmd.Parameters.Add("categooory", TXT_MC.Text);
            Console.WriteLine(txt_MID.Text);
            Console.WriteLine(cmb_MT.Text);
            Console.WriteLine(Date_M.Text);
            Console.WriteLine(TXT_MC.Text);
            Console.WriteLine("***************");
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_MT.Items.Add(cmb_MT.Text);
                MessageBox.Show("New Movie has been successfully added! ");
                txt_MID.Text = "";
                TXT_MC.Text = "";
                Date_M.Text = "";
                cmb_MT.Text = "";
                    cmb_MT.Items.Clear();
                }
           }
            catch
            {
                Console.Write("Error occurred.");

            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            try
            {
                cmd.CommandText = "insert into tvshow(tvshowid , tvshowtitle , releasedate , tvshowcategory) values(:iD, :titl, :da , :ac)";
            cmd.Parameters.Add("iD",txt_TID.Text);
            cmd.Parameters.Add("titl", cmb_TT.Text);
            cmd.Parameters.Add("da", Convert.ToDateTime(Date_T.Text));
            cmd.Parameters.Add("ac", TXT_TC.Text);

          
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_TT.Items.Add(cmb_TT.Text);
                MessageBox.Show("New TVshow has been successfully added! ");
            }
            }
            catch
            {
                Console.Write("Error occurred.");

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
       //     Console.WriteLine("NEM: ", cmb_ST.Text);
        //    Console.WriteLine("old: ", selected_series);
        //    Console.WriteLine("***************");
             //   cmb_ST.Items.Remove(selected_series);
              //  selected_series = cmb_ST.Text;
            if (cmb_ST.Text != selected_series)
            {
                cmb_ST.Items.Remove(selected_series);
            }
            cmd.Connection = conn;
            cmd.CommandText = "update Series set SeriesTitle=:title, SeriesCategory=:category where SeriesID=:id ";
            try
            {
                cmd.Parameters.Add("title", cmb_ST.Text);
                cmd.Parameters.Add("category", TXT_SC.Text);
                cmd.Parameters.Add("id", txt_SID.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    // cmb_ST.Items.Remove(selected_series);

                    if (cmb_ST.Text != selected_series)
                    {
                        Console.WriteLine("IN: ");
                        Console.WriteLine(cmb_ST.Text);
                        Console.WriteLine(selected_series);

                        cmb_ST.Items.Add(cmb_ST.Text);
                    }
                    MessageBox.Show("Series has been modified!");
                    txt_SID.Text = "";
                    TXT_SC.Text = "";
                    Date_S.Text = "";
                    cmb_ST.Text = "";
                }
            }
            catch
            {
                Console.Write("Error occurred.");

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            try
            {
                if (cmb_MT.Text != selected_move)
                {
                    cmb_MT.Items.Remove(selected_move);
                }
                cmd.CommandText = "update Movies set FilmTitle=:title, FilmCategory=:category where FilmID=:id ";
                cmd.Parameters.Add("title", cmb_MT.Text);
                cmd.Parameters.Add("category", TXT_MC.Text);
                cmd.Parameters.Add("id", txt_MID.Text);
                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    if (cmb_MT.Text != selected_move)
                    {
                        cmb_MT.Items.Add(cmb_MT.Text);
                    }
                    MessageBox.Show("Movie has been modified!");
                    txt_MID.Text = "";
                    TXT_MC.Text = "";
                    Date_M.Text = "";
                    cmb_MT.Text = "";
                    cmb_MT.Items.Clear();
                }
            }
            catch
            {
                Console.Write("Error occurred.");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            Console.WriteLine(zz);
            if (cmb_TT.Text != zz)
            {
                cmb_TT.Items.Remove(zz);
            }
            cmd.CommandText = "update Tvshow set TvshowTitle=:title, TvshowCategory=:category where TvshowID=:id ";
            try { 
            cmd.Parameters.Add("title", cmb_TT.Text);
            cmd.Parameters.Add("category", TXT_TC.Text);
            cmd.Parameters.Add("id", txt_TID.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                if (cmb_TT.Text != zz)
                {
                    cmb_TT.Items.Add(cmb_TT.Text);
                }
                MessageBox.Show("TVshow has been modified!");
                txt_TID.Text = "";
                TXT_TC.Text = "";
                Date_T.Text = "";
                cmb_TT.Text = "";
            }
            }
            catch
            {
                Console.Write("Error occurred.");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            try
            {
                c.CommandText = "delete from Series where SeriesID=:id ";
                c.Parameters.Add("id", txt_SID.Text);
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Series has been deleted!");
                    cmb_ST.Items.RemoveAt(cmb_ST.SelectedIndex);
                    txt_SID.Text = "";
                    TXT_SC.Text = "";
                    Date_S.Text = "";

                }
            }
            catch
            {
                Console.Write("Error occurred.");

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            try
            {
                c.CommandText = "delete from Movies where FilmID=:id ";
                c.Parameters.Add("id", txt_MID.Text);
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Movie has been deleted!");
                    txt_MID.Text = "";
                    cmb_MT.Text = "";
                    TXT_MC.Text = "";
                    Date_M.Text = "";
                    cmb_MT.Items.Clear();

                }
            }
            catch
            {
                Console.Write("Error occurred.");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "delete from TVshow where TVshowid=:id ";
            try
            {
                c.Parameters.Add("id", txt_TID.Text);
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("TVshow has been deleted!");
                    txt_TID.Text = "";
                    //cmb_TT.Text = "";
                    TXT_TC.Text = "";
                    cmb_TT.Items.Remove(zz);
                    Date_T.Text = "";
                }
            }
            catch
            {
                Console.Write("Error occurred.");

            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            try { 
            c.CommandText = "select FilmID,ReleaseDate,FilmCategory from Movies where FilmTitle =:title";
            c.CommandType = CommandType.Text;
                selected_move = cmb_MT.SelectedItem.ToString();
            c.Parameters.Add("title", cmb_MT.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                txt_MID.Text = dr[0].ToString();
                Date_M.Text = dr[1].ToString();
                TXT_MC.Text = dr[2].ToString();

            }
            dr.Close();
            }
            catch
            {
                Console.Write("Error occurred.");

            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void cmb_SID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXT_SC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SortByCategory_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETCAT";
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add("category", TXT_MC.Text);
                cmd.Parameters.Add("titles", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dr = cmd.ExecuteReader();
                if (cmb_MT.Items.Count > 0)
                {
                    cmb_MT.Items.Clear();
                    txt_MID.Text = "";
                    Date_M.Text = "";
                    cmb_MT.Text = "";
                }
                while (dr.Read())
                {
                    cmb_MT.Items.Add(dr[0]);
                }
                dr.Close();
            }
            catch
            {
                Console.Write("Error occurred.");

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 n = new Form1();
            n.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_TID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TXT_TC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_T_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
