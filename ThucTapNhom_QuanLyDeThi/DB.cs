﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyDeThi
{
    
    public class DB
    {
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(@"Data Source=DESKTOP-6KM2KGB\SQLEXPRESS;Initial Catalog=QuanLyNganHangDeThi;Integrated Security=True");

    }
}
