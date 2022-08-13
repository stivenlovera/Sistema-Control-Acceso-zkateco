namespace control_acceso.ControlAcceso.Models;

    public class Usuario
    {

        public int id { get; set; }
        public string ci { get; set; }
        public string num_tarjeta { get; set; }
        public string contraseña_tarjeta { get; set; } = "";
        public string nombre { get; set; }
        public string image { get; set; } = "usuario-default.webp";
        public DateTime fecha_nac { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string nota { get; set; }
        public string dirrecion { get; set; }
        public int proyecto_id { get; set; }
        public int departamento_id { get; set; }
        public int grupo_id { get; set; }
        public int creado_por { get; set; }
    }
