using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNhauDanBam
{
    class BanDat
    {
        public static int banDangChon;
        public static DataTable[] monAn = new DataTable[9];
        public static bool[] trangThaiBan = new bool[9];

        public static void init()
        {
            DataColumn column;
            for (int i = 0; i < monAn.Length; i++)
            {
                monAn[i] = new DataTable();

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "SL";
                column.AutoIncrement = false;
                column.ReadOnly = false;
                column.Unique = false;
                monAn[i].Columns.Add(column);

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Mon An";
                column.AutoIncrement = false;
                column.ReadOnly = false;
                column.Unique = false;
                monAn[i].Columns.Add(column);

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Don gia";
                column.AutoIncrement = false;
                column.ReadOnly = false;
                column.Unique = false;
                monAn[i].Columns.Add(column);
                
                
            }
        }
    }
}
