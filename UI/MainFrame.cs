using System;
using System.Collections.Generic;
using System.Text;
using FaceCat;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace encodeex
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public class MainFrame : UIXmlEx
    {
        /// <summary>
        /// 加载XML
        /// </summary>
        /// <param name="xmlPath">XML地址</param>
        public override void loadFile(String file, FCView parent)
        {
            //预创建控件
            base.loadFile(file, parent);
        }
    }
}