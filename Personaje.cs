namespace Personaje
{

    //datos: tipo, nombre, apodo, fecha nacimiento, edad entre 0 a 300
    //caracteristicas: velocidad de 1 a 10, destreza de 1 a 5, fuerza de 1 a 10, nivel de 1 a 10, armadura de 1 a 10, salud 100
    public class personaje
    {

        public enum datos
        {
            tipo,
            apodo,
            fechaNacimiento,
            edad
        }

        public enum caracteristicas
        {
            velocidad,
            destreza,
            fuerza,
            nivel,
            armadura,
            salud
        }
    }
}