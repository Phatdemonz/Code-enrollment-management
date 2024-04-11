using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DOAN_QLTUYENSINHDH.FormQuanLy;
using DOAN_QLTUYENSINHDH.BaoCao;

namespace DOAN_QLTUYENSINHDH
{
    static class Program
    {
      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}