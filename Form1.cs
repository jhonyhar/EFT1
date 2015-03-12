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
        p.Nama = "sadas"; p.TanggalLahir = new DateTime(1990, 06, 16);
        iCData.dtOrang.Add(p);
        iCData.SaveChanges();

        List<Orang> op = (from iDt in iCData.dtOrang select iDt).ToList<Orang>();
        MessageBox.Show(op.Count.ToString());

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        foreach (Orang dtOrg in (from iDt in iCData.dtOrang select iDt).ToList<Orang>())
        {
          iCData.dtOrang.Remove(dtOrg);
        }
        iCData.SaveChanges();
        MessageBox.Show("OK");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      
    }
  }
}
