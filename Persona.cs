namespace Tarea_2;

class Persona {

    public string nombre;
    public Casa casa;

    public Persona() {

        nombre = "Juan";
        casa = new Casa(150);
    }

    public Persona(string nombre, Casa casa) {

        this.nombre = nombre;
        this.casa = casa;
    }

    public void setNombre(string nombre) {

        this.nombre = nombre;
    }

    public void setCasa(Casa casa) {

        this.casa = casa;
    }

    public void MostrarDatos() {

        Console.WriteLine($"Mi nombre es {nombre}");
        casa.MostrarDatos();
        casa.puerta.MostrarDatos();
    }
}