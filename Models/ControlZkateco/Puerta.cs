namespace control_acceso.Models;

    public class Puerta
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string ip_controlador { get; set; }
        public int num_puerta { get; set; }
        public int tipo_verificacion_id { get; set; }
        public int tipo_sensor_id { get; set; }
        public int hora_habilitada_id { get; set; }
        public int hora_programada_id { get; set; }
        public int creado_por { get; set; }
        public int proyecto_id { get; set; }
        public int controlador_id { get; set; }
    }
