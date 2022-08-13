namespace control_acceso.Models;

    public class ControlAcceso
    {
        public int id { get; set; }
        public int proyecto_id { get; set; }
        public int puerta_id { get; set; }
        public int horario_id { get; set; }
        public int usuario_id { get; set; }
        public int creado_por { get; set; }
        public int acceso_id { get; set; }
    }
