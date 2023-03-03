namespace Tarea_2;

class Program
{
    static void Main(string[] args) {

        Persona persona = new Persona();
        persona.MostrarDatos();
        persona.nombre = "Carlos";
        Apartamento nuevoApartamento = new Apartamento();
        Puerta nuevaPuerta = new Puerta("Verde");

        nuevoApartamento.setPuerta(nuevaPuerta);
        persona.setCasa(nuevoApartamento);
        persona.MostrarDatos();

    }
}
