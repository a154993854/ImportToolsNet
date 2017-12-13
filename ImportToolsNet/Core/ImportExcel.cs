using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//using Microsoft.Office.Interop.Excel;  
using System.Data.OleDb;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Spire.Xls;
using ImportToolsNet.Data.Common;

namespace ImportToolsNet.Core
{
    public class ImportExcel
    {
        /// <summary>
        /// 导入excel数据
        /// </summary>
        /// <param name="fname"></param>
        /// <returns></returns>
        public DataTable GetXlsDataTable(string fname)
        {
            DataTable dt = new DataTable();
            Workbook workbook = new Workbook();
            if (fname == "")
            {
                return null;
            }
            //加载读取EXCEL文件
            workbook.LoadFromFile(fname);
            //读取第一个sheet的数据
            Worksheet worksheet = workbook.Worksheets[0];
            //获取第一行所有列
            //CellRange[] cellRange  = worksheet.Rows[0].Columns;
            CellRange[] rowrange = worksheet.Rows;
            //获取所有行数据遍历行
            foreach (CellRange row in rowrange)
            {
                if (row.Row == 1)
                {
                    foreach (CellRange cell in row.Cells)
                    {
                        dt.Columns.Add(cell.Value);
                    }
                    continue;
                }
                DataRow dr = dt.NewRow();
                //获取总列数
                try
                {
                    //如果DT 的列数和EXCEL 的数据列数不一样提示出错
                    if (dt.Columns.Count != row.CellsCount)
                    {
                        throw (new Exception("EXCEL 文件存在异常的列,在"+row.Row+"行"));
                    }
                    for (int i = 0; i < 7; i++)
                    {
                        dr[i] = row.Cells[i].Value;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                dt.Rows.Add(dr);
                
                
            }
            
            return dt;
        }
        /// <summary>
        /// 读取列名
        /// </summary>
        /// <param name="fname"></param>
        /// <returns></returns>
        public DataTable LoadDGV_Choose(string fname)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Excel列名");
            Workbook workbook = new Workbook();

            //加载读取EXCEL文件
            workbook.LoadFromFile(fname);
            //读取第一个sheet的数据
            Worksheet worksheet = workbook.Worksheets[0];
            //获取第一行所有列
            CellRange[] cellRange  = worksheet.Rows[0].Columns;
           
            foreach (CellRange cell in cellRange)
            {
                DataRow dr = dt.NewRow();
                dr[0] = cell.Value;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        /// <summary>
        /// 获取数据库表的所有列
        /// </summary>
        /// <param name="表名"></param>
        /// <returns></returns>
        public DataTable GetTableColunm(string table)
        {
            DataTable dataTable = new DataTable();
            DataProvider dataProvider = new DataProvider();
            dataTable = dataProvider.SelectDataColunm(table).Tables[0];
            DataRow dr = dataTable.NewRow();
            //增加一个空白行
            dr[0] = "";
            dataTable.Rows.Add(dr);
            return dataTable;
        }
    }
}