using RepasoConceptos.Animales;

namespace RepasoConceptos
{
    internal class Polimorfismo
    {
        public void Repaso()
        {
            //Completar cada if para que se escriba en consola lo que dice cada uno

            Animal gato = new Gato();
            Animal perro = new Perro();
            Animal vaca = new Vaca();

            if(gato.Hablar() == "")
            {
                Console.WriteLine("el gato dijo: " + gato.Hablar());
            }

            if (perro.Hablar() == "")
            {
                Console.WriteLine("el perro dijo: " + perro.Hablar());
            }

            if (vaca.Hablar() == "")
            {
                Console.WriteLine("el vaca dijo: " + vaca.Hablar());
            }
        }
    }
}
