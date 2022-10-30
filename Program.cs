internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("-----Çalışan1------");
        Calisan calisan1 = new Calisan ("İnan", "Akalın", 123456, "Girişimci");
        calisan1.CalisanBilgileri();

        System.Console.WriteLine("-----Çalışan2------");
        Calisan calisan2 = new Calisan ("Erinç", "Bilican");
        calisan2.CalisanBilgileri();

       
    }
}

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Depratman;

    public Calisan (string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Depratman = departman;
    }
    public Calisan (string ad, string soyad )
    {
        this.Ad = ad;
        this.Soyad = soyad;
       
    }


    public Calisan (){}

    public void CalisanBilgileri ()
    {
        System.Console.WriteLine("Çalışanın Adı: {0}", Ad);
        System.Console.WriteLine("Çalıianın Soyadı:{0}", Soyad);
        System.Console.WriteLine("Çalışanın Nosu:{0}", No);
        System.Console.WriteLine("Çalışanın Departmanı:{0}", Depratman);
    }


}