namespace EspecificacionesPersonaje{

public class FabricaDePersonaje{
    public void generarPersonaje(){
        Personaje nuevoPersonaje = new Personaje();
        Random numeroRandom = new Random();
        nuevoPersonaje.tipo = "coso";
        nuevoPersonaje.apodo = "cosoo";
        nuevoPersonaje.fechaNacimiento = DateTime.Today;
        nuevoPersonaje.edad = numeroRandom.Next(0,300);
        nuevoPersonaje.velocidad = numeroRandom.Next(1,10);
        nuevoPersonaje.destreza = numeroRandom.Next(1,5);
        nuevoPersonaje.fuerza = numeroRandom.Next(1,10);
        nuevoPersonaje.nivel = numeroRandom.Next(1,10);
        nuevoPersonaje.armadura = numeroRandom.Next(1,10);
        nuevoPersonaje.salud = 100;
    }
}
}