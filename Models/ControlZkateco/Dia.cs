namespace Control_acceso.Models;
public class Dia
{
    public int id { get; set; }
    public string nombre { get; set; }
    public int horario_id { get; set; }
    public int proyecto_id { get; set; }
    public string estado { get; set; } = "activo";
    public List<Hora> Horas { get; set; }
}

