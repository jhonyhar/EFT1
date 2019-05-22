using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFT1
{
  class Orang
  {
    public int Id { get; set; }
    public string Nama { get; set; }
    public DateTime TanggalLahir { get; set; }
    private int _usia;

    public int Usia
    {
      get { return DateTime.Today.Year - TanggalLahir.Year; }
    }
		//walao
    public string Alamat { get; set; }
  }
}
