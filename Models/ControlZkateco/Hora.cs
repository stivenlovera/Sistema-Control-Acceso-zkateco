namespace Control_acceso.Models;

    public class Hora
    {
        public int id { get; set; }
        public string hora_inicio { get; set; }
        public string hora_final { get; set; }
        public Dia dia { get; set; }
        public int proyecto_id { get; set; }
    }

