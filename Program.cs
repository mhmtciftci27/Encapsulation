internal class Program
{
    private static void Main(string[] args)
    {
        Ogrenci ogrenci1=new Ogrenci();
        ogrenci1.Isim = "Ayşe";
        ogrenci1.Soyisim = "kaya";
        ogrenci1.Sinif = 3;
        ogrenci1.Ogrencino = 1213;

        ogrenci1.OgrenciBilgileri();
        ogrenci1.SinifAtlat();
        ogrenci1.OgrenciBilgileri();

        Ogrenci ogrenci2 = new Ogrenci("Deniz","Yolmaz",245,1);
        ogrenci2.OgrenciBilgileri();

        ogrenci2.SinifDusur();
        ogrenci2.OgrenciBilgileri();
    }
}
class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrencino;
    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Ogrencino { get => ogrencino; set => ogrencino = value; }
    public int Sinif 
    { 
        get => sinif; 
        set
        {
            if(value <=1)
            {
                Console.WriteLine("Sınıf en az 1 olabilir");
                sinif=1;
            }
            else
                sinif =value;
        }  
    }

    public Ogrenci(string ısim, string soyisim, int ogrencino, int sinif) // 
    {
        Isim = ısim;
        Soyisim = soyisim;
        Ogrencino = ogrencino;
        Sinif = sinif;
    }

    public Ogrenci(){} //boş olarak buradan yaratacak.,

    public void OgrenciBilgileri()
    {
        Console.WriteLine("****Öğrenci Bilgileri*********");
        Console.WriteLine("Öğrenci Adı      :{0}", this.Isim);
        Console.WriteLine("Öğrenci Adı      :{0}", this.Soyisim);
        Console.WriteLine("Öğrenci Adı      :{0}", this.Ogrencino);
        Console.WriteLine("Öğrenci Adı      :{0}", this.Sinif);
    }

    public void SinifAtlat()
    {
        this.Sinif = this.Sinif +1;
    }
    public void SinifDusur()
    {
        this.Sinif = this.Sinif -1;
    }
    
}
