namespace ManoPrograma.Models;

public class Zmogus
{
    public static int StatineVerte;
    public string Vardas { get; set; }
    public string Pavarde { get; set; }
    public int GimimoMetus { get; set; }
    public int Ugis { get; set; }

    public void PadidinkUgi(int cm)
    {
        this.Ugis += cm;
    }
}