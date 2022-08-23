using System;
using System.Collections;

class Program{

    static void Main(string[] args){

        Console.WriteLine("Calışan Sayısı {0}",Calısan.CalısanSayısı1);

        Calısan calısan = new Calısan("ayşe","yılmaz","IK");
        Console.WriteLine("Calışan Sayısı : {0} ", Calısan.CalısanSayısı1);
        
        Console.WriteLine("Toplama işlemi Sonucu : " + Islemler.Topla(100,200));
        Console.WriteLine("Çıkarma işlemi Sonucu : " + Islemler.Cıkar(100,200));

    }

}

class Calısan{

    private static int CalısanSayısı;

    public static int CalısanSayısı1 { get => CalısanSayısı;}
    private string isim;
    private string Soyisim;
    private string Departman;

    static Calısan(){
        CalısanSayısı = 0;
    }

    public Calısan(string isim,string Soyisim,string Departman){
        this.isim = isim;
        this.Soyisim = Soyisim;
        this.Departman = Departman;
        CalısanSayısı++;
    }
}

static class Islemler{

    public static long Topla(int sayı1,int sayı2){
        return sayı1 + sayı2;
    }

    public static long Cıkar(int sayı1,int sayı2){
        return sayı1 - sayı2;
    }

}
