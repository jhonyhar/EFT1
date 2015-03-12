using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFT1
{
  public partial class Form1 : Form
  {
    OrangKonteks iCData = new OrangKonteks();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        Orang p = new Orang();
        p.Id = 1; p.Nama = "sadas"; p.TanggalLahir = new DateTime(1990, 06, 16);
        iCData.dtOrang.Add(p);
        iCData.SaveChanges();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
