public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Masukkan sebuah angka : ");
        string inputString = Console.ReadLine();

        try
        {
            int inputInt = int.Parse(inputString);
            int inputInt2 = Convert.ToInt32(inputString);
            int hasilKuadrat = checked(inputInt * inputInt);
            Console.WriteLine("Hasil kuadrat dari " + inputInt2 + " adalah = " + hasilKuadrat);
        } catch(FormatException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Input tidak bisa dikonversi");
        } catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Angka hasil kuadrat terlalu besar");
        } catch (ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}