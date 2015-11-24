//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace PhotoEditor
{
    class Control_Tab : TabControl
    {
        private ContextMenuStrip _cms;
        public Control_Tab()
        {
            _cms = Getcms();
        }

        private ContextMenuStrip Getcms()
        {
            ContextMenuStrip CMS = new ContextMenuStrip();
            CMS.Items.Add("Close", null, new EventHandler(Item_Clicked));
            return _cms;
        }
        private void Item_Clicked(object sender, EventArgs e)
        {

            for (int i = 0; i < this.TabCount; i++)
            {
                Rectangle rect = this.GetTabRect(i);
                if (rect.Contains(this.PointToClient(Cursor.Position)))
                {
                    this.TabPages.RemoveAt(i);
                }
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                _cms.Show(Cursor.Position); 
            }
        }
    }
}
