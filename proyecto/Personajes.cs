namespace RPG
{
    //datos: tipo, nombre, apodo, fecha nacimiento, edad entre 0 a 300
    //caracteristicas: velocidad de 1 a 10, destreza de 1 a 5, fuerza de 1 a 10, nivel de 1 a 10, armadura de 1 a 10, salud 100
    public class Personaje
    {
        public int numeroPersonaje;
        // public string[] tipos = {"tipo1", "tipo2", "tipo3", "tipo4"}; //definir tipos de personajes
        public string tipo { get; set; }
        // public string[] apodos = {"apodo1", "apodo2", "apodo3", "apodo4"}; //definir tipos de personajes
        public string apodo { get; set; } //definir apodos
        public DateTime fechaNacimiento { get; set; }
        public int edad { get; set; }
        public int velocidad { get; set; }
        public int destreza { get; set; }
        public int fuerza { get; set; }
        public int nivel { get; set; }
        public int armadura { get; set; }
        public int salud { get; set; }

        public void MostrarPersonaje()
        {
            Console.WriteLine("Tipo P" + numeroPersonaje + ": " + tipo);
            Console.WriteLine("Apodo P" + numeroPersonaje + ": " + apodo);
            Console.WriteLine("Fecha de nacimiento P" + numeroPersonaje + ": " + fechaNacimiento.ToShortDateString());
            Console.WriteLine("Edad P" + numeroPersonaje + ": " + edad);
            Console.WriteLine("Velocidad P" + numeroPersonaje + ": " + velocidad);
            Console.WriteLine("Destreza P" + numeroPersonaje + ": " + destreza);
            Console.WriteLine("Fuerza P" + numeroPersonaje + ": " + fuerza);
            Console.WriteLine("Nivel P" + numeroPersonaje + ": " + nivel);
            Console.WriteLine("Armadura P" + numeroPersonaje + ": " + armadura);
            Console.WriteLine("Salud P" + numeroPersonaje + ": " + salud);

            Console.WriteLine("--------------------------");
        }
    }
}

