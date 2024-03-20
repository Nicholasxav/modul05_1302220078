// See https://aka.ms/new-console-template for more information
namespace modul5_130222007;
public class Penjumlahan<T>
{
    public void JumlahTigaAngka(T t, T i, T k)
    {
        dynamic t1 = t;
        dynamic i1 = i;
        dynamic k1 = k;
        dynamic hasil = t1 + i1 + k1;
        Console.WriteLine(hasil);
    }
}
internal class program
{
    private static void Main(string[] args)
    {
        Penjumlahan x = new Penjumlahan<int>();
        x.JumlahTigaAngka(13, 02, 22);
    }
}

public class SimpleDataBase<T>
{

}