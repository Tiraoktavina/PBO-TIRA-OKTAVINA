using System;
using System.Collections.Generic;
public class Exercise30 {
    public static void Main() {

        Console.WriteLine("****************************************************************");
        Console.WriteLine("Tugas Program Bilangan Desimal Ke Hexadesimal Visual C#");
        Console.WriteLine("Nama         : Tira Oktavina");
        Console.WriteLine("Npm          : 1102201012");
        Console.WriteLine("Kelas        : Malam");
        Console.WriteLine("Dosen        : Asep Mabrur Aid,S.T,M.Kom");
        Console.WriteLine("Prodi        : Teknik Informatika");
        Console.WriteLine("Mata Kuliah  : Pemgraman Berorientasi Objek");
        Console.WriteLine("****************************************************************");
        string hexval = "5B0";
        Console.WriteLine("Hexadecimal number: "+hexval);
        int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("Convert to-");
        Console.WriteLine("Decimal number: " +decValue);
    }
}
