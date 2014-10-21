
namespace COME.Clases
{
    public class Cliente
    {
        public Cliente()
        {
            this.ID = -1;
            this.Clave = string.Empty;
            this.Descripcion = string.Empty;
            this.EjecutarAccion = false;
        }
        
        public int ID { get; set; }

        public string Clave { get; set; }

        public string Descripcion { get; set; }

        public bool EjecutarAccion { get; set; }
    }
}
