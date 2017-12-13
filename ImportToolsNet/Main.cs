using ImportToolsNet.Base;
using ImportToolsNet.Core;
using ImportToolsNet.Delegate;
using ImportToolsNet.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Windows.Forms;

namespace ImportToolsNet
{
    public partial class Main : Form
    {

        List<MenuAttributecs> Imenu = new List<MenuAttributecs>();
        public Main()
        {
            InitializeComponent();
        }
       

        private void Main_Load(object sender, EventArgs e)
        {
            
            string strMenu = string.Empty;
            //读取菜单文件
            StreamUtil streamUtil = new StreamUtil();
            strMenu = streamUtil.GetJsonText(@"Content\Menuconfig.json");
            Imenu = Json.ToListEntity<MenuAttributecs>(strMenu);

            ToolStripMenuItem subItem;
            foreach (MenuAttributecs menu in Imenu)
            {
                subItem = AddContextMenu(menu.MenuName,menu.Menu_no,menuStrip1.Items, new MenuClickAction(menu.Menu_no,menu));
            }



            //List<MenuAttributecs> Lmenu = Json.ToList<MenuAttributecs>(strMenu);
        }

        /// <summary>
        /// 添加子菜单
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <param name="cms"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        ToolStripMenuItem AddContextMenu(string name,string tag, ToolStripItemCollection cms, MenuClickAction callback)
        {
            
            if (name == "-")
            {
                ToolStripSeparator tsp = new ToolStripSeparator();
                cms.Add(tsp);
                return null;
            }
            else if (!string.IsNullOrEmpty(name))
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(name);
                tsmi.Tag = tag;
                tsmi.Text = name;
                callback.menu_no = tag;
                if (callback != null) tsmi.Click += callback.menuclick;
                cms.Add(tsmi);
                return tsmi;
            }
            return null;
        }

    }
}
