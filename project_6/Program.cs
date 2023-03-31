using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        Mahasiswa objMhs = new Mahasiswa("John", 130221, "RPL");

        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        string stringJson = JsonSerializer.Serialize(objMhs, options);
        string posisiFolder = "C:/Users/ACER/praktikum_kpl/minggu_6/project_6";
        string filename = posisiFolder + "/mahasiswa.json";
        File.WriteAllText(posisiFolder, stringJson);

    }
}

public class Mahasiswa
{
    public string nama { get; set; }
    public int nim { get; set; }
    public string prodi { get; set; }

    public Mahasiswa()
    {

    }

    public Mahasiswa(string nama, int nim, string prodi)
    {
        this.nama = nama;
        this.nim = nim;
        this.prodi = prodi;
    }   
}