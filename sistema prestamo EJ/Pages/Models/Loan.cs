namespace sistema_prestamo_EJ.Pages.Models
{
public class Loan
{
    public required string Nombre { get; set; }
    public double TasaInteres { get; set; }
    public decimal MontoMaximo { get; set; }
}
}