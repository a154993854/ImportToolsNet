using ImportToolsNet.Core;
using ImportToolsNet.Entity;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImportToolsNet.Base
{
    public partial class Frm_ypinfo_Base : Form
    {
        private MenuAttributecs menuAttributecs;
        public Frm_ypinfo_Base(MenuAttributecs menuAttributecs)
        {
            InitializeComponent();
            this.menuAttributecs = menuAttributecs;
            this.Text = this.menuAttributecs.MenuName;

        }

        private void Bt_openfile_Click(object sender, EventArgs e)
        {
            string fName = string.Empty;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "Excel文件(*.xlsx)|*.xlsx";
            openFile.RestoreDirectory = true;
            openFile.FilterIndex = 1;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fName = openFile.FileName;
            }
            lb_path.Text = fName;
            ImportExcel import = new ImportExcel();
            DataTable dataTable =  import.GetXlsDataTable(fName);
            DGV_import.DataSource = dataTable;
            Load_Choose(fName);


        }
        /// <summary>
        /// 加载列名选择Grid
        /// </summary>
        /// <param name="fName"></param>
        public void Load_Choose(string fName)
        {
            ImportExcel import = new ImportExcel();
            DataTable  dt = import.LoadDGV_Choose(fName);
            DGV_Choose.DataSource = dt;
            //创建下拉对象 
            DataGridViewComboBoxColumn dataGridViewComboBox = new DataGridViewComboBoxColumn();
            dataGridViewComboBox.DataSource = import.GetTableColunm(menuAttributecs.DataTable);
            dataGridViewComboBox.ValueMember = "name";
            dataGridViewComboBox.DisplayMember = "name";
            dataGridViewComboBox.HeaderText = "数据库列名";
            dataGridViewComboBox.DisplayStyle= DataGridViewComboBoxDisplayStyle.DropDownButton;
            DGV_Choose.Columns.Add(dataGridViewComboBox);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 获取列对应关系进行有效性验证
            DataTable dt = GetDgvToTable(DGV_Choose);


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有有效的数据列");
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow Irow = dt.Rows[i];
                for (int k = 0; i < dt.Rows.Count; k++)
                {
                    DataRow Krow = dt.Rows[k];
                    if (i != k)
                    {
                        if (Irow["数据库列名"].ToString() == Krow["数据库列名"].ToString())
                        {
                            MessageBox.Show(string.Format("发现列名指定重复第{0}行和第{1}行",i.ToString(),k.ToString()));
                        }
                    }
                }
            }

            #endregion
        }
        /// <summary>
        /// 方法实现把dgv里的数据完整的复制到一张内存表
        /// </summary>
        /// <param name="dgv">dgv控件作为参数</param>
        /// <returns>返回临时内存表</returns>
        public static DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = dgv.Rows[count].Cells[countsub].Value.ToString();
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DGV_Choose.Rows[0].Cells[1].Value.ToString());
        }
    }
}
