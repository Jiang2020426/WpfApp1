using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            DataTable db = new DataTable();
            string sqlstr = "select Code,Remarks,GPerM2,KeyInBy,KeyInOn from QualityCode";
            SqlConnection conn = new SqlConnection("server=192.168.1.8;uid=wit;pwd=witman;database=WEBASE");
            SqlCommand comm = new SqlCommand(sqlstr, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(db);
            Table = db.DefaultView;

        }
        private DataView table;

        public DataView Table
        {
            get { return table; }
            set { table = value; }
        }


    }
}
