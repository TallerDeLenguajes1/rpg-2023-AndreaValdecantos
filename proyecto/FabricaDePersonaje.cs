namespace RPG
{
    public class FabricaDePersonaje
    {
        public Personaje generarPersonaje(int id)
        {
            PersonajesAPIWeb listaPersonajesJson = new PersonajesAPIWeb();
            List<Doc> lista = listaPersonajesJson.ObtenerPersonajes();
            Personaje nuevoPersonaje = new Personaje();
            Random numeroRandom = new Random();
            int numeroPersonaje = numeroRandom.Next(932);
            
            DateTime fechaInicial = new DateTime(1723, 1, 1);
            DateTime fechaFinal = new DateTime(2023, 6, 23);
            DateTime fechaAleatoria = fechaInicial.AddDays(numeroRandom.Next((fechaFinal-fechaInicial).Days));

            nuevoPersonaje.numeroPersonaje = id;
            nuevoPersonaje.tipo = lista[numeroPersonaje].race;
            nuevoPersonaje.apodo = lista[numeroPersonaje].name;
            nuevoPersonaje.fechaNacimiento = fechaAleatoria;
            nuevoPersonaje.edad = ((DateTime.Now - fechaAleatoria).Days)/365;
            nuevoPersonaje.velocidad = numeroRandom.Next(1, 10);
            nuevoPersonaje.destreza = numeroRandom.Next(1, 5);
            nuevoPersonaje.fuerza = numeroRandom.Next(1, 10);
            nuevoPersonaje.nivel = numeroRandom.Next(1, 10);
            nuevoPersonaje.armadura = numeroRandom.Next(1, 10);
            nuevoPersonaje.salud = 100;

            return nuevoPersonaje;
        }
    }
}