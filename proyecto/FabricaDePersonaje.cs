namespace EspecificacionesPersonaje{

public class FabricaDePersonaje{
    public Personaje generarPersonaje(){
        Personaje nuevoPersonaje = new Personaje();
        Random numeroRandom = new Random();
        nuevoPersonaje.tipo = nuevoPersonaje.tipos[numeroRandom.Next(0,3)]; //agregar de un array
        nuevoPersonaje.apodo = nuevoPersonaje.apodos[numeroRandom.Next(0,3)]; //agregar de un array
        nuevoPersonaje.fechaNacimiento = DateTime.Today; //falta fecha
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