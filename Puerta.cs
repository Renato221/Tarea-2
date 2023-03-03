namespace Tarea_2;

class Puerta {

    public string color;

    public Puerta() {
        
        this.color = "Cafe";
    }
    public Puerta(string color) {

        this.color = color;
    }

    public void setColor(string color){

        this.color = color;
    }

    public void MostrarDatos() {

        Console.WriteLine($"Soy una puerta mi color es {color}");
    }
}
