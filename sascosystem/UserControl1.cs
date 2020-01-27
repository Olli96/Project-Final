using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sascosystem
{
    public partial class UserControl1 : UserControl
    {
        MySqlConnection connectiontext = new MySqlConnection("datasource=localhost;username=root;password=;Character Set=utf8;");
        MySqlCommand command;

        public UserControl1()
        {
            InitializeComponent();
        }

        public void openConnection()
        {
            if (connectiontext.State == ConnectionState.Closed)
            {
                connectiontext.Open();
            }
            else
            {
                connectiontext.Close();
            }
        }

        public void closeConnection()
        {
            if (connectiontext.State == ConnectionState.Open)
            {
                connectiontext.Close();
            }
        }

        public void executeQuery(String query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connectiontext);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ปัญหาคือไม่มีค่าใน Combobox ถ้าแก้ไม่ได้ให้เปลี่ยนเป็นtextboxให้หมด
            try
            {


                openConnection();
                string query = "INSERT INTO nalang.customer(getjob,jobreport,jobnumber,getjobdate,namecus,telcus,emailcus,typejob,banka,detail,typeasset,bank,asset,addrasset" +
                    ",numasset,space,land,service,suvvey,walk,copy,servicetal,com,pro,vat,oreport,book,codeasset,seq,booking,comment,dayj,percheck,daysend,perf,payget,daysend2,derate,payment,expjob,emailexpjob,telexpjob,perget,updateout,detailre,accountre,docadd,resevdoc)" +
                    " values(@getjob,@jobreport,@jobnumber,@getjobdate,@namecus,@telcus,@emailcus,@typejob,@banka,@detail,@typeasset,@bank,@asset," +
                    "@addrasset,@numasset,@space,@land,@service,@suvvey,@walk,@copy,@servicetal,@com,@pro,@vat,@oreport,@book,@codeasset,@seq,@booking,@comment,@dayj,@percheck,@daysend,@perf,@payget,@daysend2,@derate,@payment,@expjob,@emailexpjob,@telexpjob,@perget,@updateout,@detailre,@accountre,@docadd,@resevdoc)";
                command = new MySqlCommand(query, connectiontext);
                
                command.Parameters.Add("@getjob", MySqlDbType.Date).Value = dtpgetjob.Value;
                command.Parameters.Add("@jobreport", MySqlDbType.Text).Value = txtjobre.Text;
                command.Parameters.Add("@jobnumber", MySqlDbType.Text).Value = txtjobnum.Text;
                command.Parameters.Add("@getjobdate", MySqlDbType.Date).Value = dtpsavejob.Value;
                command.Parameters.Add("@namecus", MySqlDbType.Text).Value = txtcustom.Text;
                command.Parameters.Add("@telcus", MySqlDbType.Text).Value = txttelcus.Text;
                command.Parameters.Add("@emailcus", MySqlDbType.Text).Value = txtemailcus.Text;
                command.Parameters.Add("@typejob", MySqlDbType.Text).Value = cmbtype.Text.ToString();
                command.Parameters.Add("@banka", MySqlDbType.Text).Value = cmbbank2.Text.ToString();                                                                          ;
                command.Parameters.Add("@detail", MySqlDbType.Text).Value = cmbdetail.Text.ToString();
                command.Parameters.Add("@typeasset", MySqlDbType.Text).Value = cmbasset.Text.ToString();
                command.Parameters.Add("@bank", MySqlDbType.Text).Value = cmbbank.Text.ToString();
                command.Parameters.Add("@asset", MySqlDbType.Text).Value = cmbnum.Text.ToString();
                command.Parameters.Add("@addrasset", MySqlDbType.Text).Value = txtaddrasset.Text;
                command.Parameters.Add("@numasset", MySqlDbType.Text).Value = txtnumasset.Text;
                command.Parameters.Add("@space", MySqlDbType.Text).Value = txta.Text;
                command.Parameters.Add("@land", MySqlDbType.Text).Value = txtland.Text;
                command.Parameters.Add("@service", MySqlDbType.Text).Value = txtservice.Text;
                command.Parameters.Add("@suvvey", MySqlDbType.Text).Value = txtsuvvry.Text;
                command.Parameters.Add("@walk", MySqlDbType.Text).Value = txtwalk.Text;
                command.Parameters.Add("@copy", MySqlDbType.Text).Value = txtcopy.Text;
                command.Parameters.Add("@servicetal", MySqlDbType.Text).Value = txtser.Text;
                command.Parameters.Add("@com", MySqlDbType.Text).Value = txtcon.Text;
                command.Parameters.Add("@pro", MySqlDbType.Text).Value = cmbpro.Text.ToString();
                command.Parameters.Add("@vat", MySqlDbType.Text).Value = txtvat.Text;
                command.Parameters.Add("@oreport", MySqlDbType.Text).Value = txtoldreport.Text;
                command.Parameters.Add("@book", MySqlDbType.Text).Value = txtbook.Text;
                command.Parameters.Add("@codeasset", MySqlDbType.Text).Value = txtcodeasset.Text;
                command.Parameters.Add("@seq", MySqlDbType.Text).Value = txtsuq.Text;
                command.Parameters.Add("@booking", MySqlDbType.Text).Value = cmbbooking.Text.ToString();
                command.Parameters.Add("@dayj", MySqlDbType.Date).Value = dtpday.Value;
                command.Parameters.Add("@percheck", MySqlDbType.Text).Value = txtcheck.Text;
                command.Parameters.Add("@comment", MySqlDbType.Text).Value = txtcomment.Text;
                command.Parameters.Add("@daysend", MySqlDbType.Date).Value = dtpsend.Value;
                command.Parameters.Add("@perf", MySqlDbType.Text).Value = txtperF.Text;
                command.Parameters.Add("@payget", MySqlDbType.Text).Value = txtperget.Text;
                command.Parameters.Add("@daysend2", MySqlDbType.Date).Value = dtpsend2.Value;
                command.Parameters.Add("@derate", MySqlDbType.Text).Value = txtderate.Text;
                command.Parameters.Add("@payment", MySqlDbType.Text).Value = txtpayment.Text;
                command.Parameters.Add("@expjob", MySqlDbType.Text).Value = txtexpjob.Text;
                command.Parameters.Add("@emailexpjob", MySqlDbType.Text).Value = txtemail.Text;
                command.Parameters.Add("@telexpjob", MySqlDbType.Text).Value = txttelexpjob.Text;
                command.Parameters.Add("@perget", MySqlDbType.Text).Value = txtperget.Text;
                command.Parameters.Add("@updateout", MySqlDbType.Date).Value = dtpupdateout.Value;
                command.Parameters.Add("@detailre", MySqlDbType.Text).Value = txtdetailre.Text;
                command.Parameters.Add("@accountre", MySqlDbType.Text).Value = txtaccre.Text;
                command.Parameters.Add("@docadd", MySqlDbType.Text).Value = txtdocadd.Text;
                command.Parameters.Add("@resevdoc", MySqlDbType.Text).Value = txtresevdoc.Text;

                command.ExecuteNonQuery();
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            cmbtype.Items.Add("สินเชื่อใหม่");
        }
    }
}
