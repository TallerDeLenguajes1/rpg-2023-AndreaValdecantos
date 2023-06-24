namespace PersonajesAPI{

public class FabricaDePersonaje{
    public Personaje generarPersonaje(){
        PersonajesJson listaPersonajesJson = new PersonajesJson();
        List<Doc> lista =  listaPersonajesJson.ObtenerPersonajes();
        Personaje nuevoPersonaje = new Personaje();
        Random numeroRandom = new Random();
        int numeroAleatorio = numeroRandom.Next(932);

        nuevoPersonaje.tipo = lista[numeroAleatorio].race;
        nuevoPersonaje.apodo = lista[numeroAleatorio].name;
        nuevoPersonaje.fechaNacimiento = lista[numeroAleatorio].birth;
        nuevoPersonaje.edad = numeroRandom.Next(0,300);
        nuevoPersonaje.velocidad = numeroRandom.Next(1,10);
        nuevoPersonaje.destreza = numeroRandom.Next(1,5);
        nuevoPersonaje.fuerza = numeroRandom.Next(1,10);
        nuevoPersonaje.nivel = numeroRandom.Next(1,10);
        nuevoPersonaje.armadura = numeroRandom.Next(1,10);
        nuevoPersonaje.salud = 100;
        
        return nuevoPersonaje;
    }
}
}