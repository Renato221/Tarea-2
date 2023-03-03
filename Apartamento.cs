namespace Tarea_2;

class Apartamento : Casa {

    public Apartamento() : base(50){

    }

    public new void MostrarDatos() {
        Console.WriteLine($"Soy una Apartamento, mi área es {area} m2");
    }
}