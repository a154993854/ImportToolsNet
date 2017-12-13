using ImportToolsNet.Base;
using ImportToolsNet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImportToolsNet.Delegate
{
    public class MenuClickAction
    {
        public MenuAttributecs menuAttributecs;
        public string menu_no;
        public MenuClickAction(string menuNo,MenuAttributecs menuAttributecs)
        {
            this.menu_no = menuNo;
            this.menuAttributecs = menuAttributecs;
        }
        public void menuclick(object sender, EventArgs e)
        {
            Console.WriteLine(menu_no);
            Frm_ypinfo_Base _Base = new Frm_ypinfo_Base(menuAttributecs);
            _Base.Show();
        }
    }
}
