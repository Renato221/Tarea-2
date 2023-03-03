namespace Tarea_2;

class Casa {

    public int area;
    public Puerta puerta;

    public Casa(int area) {

        this.area = area;
        this.puerta = new Puerta();
    }

    public void setArea(int area) {

        this.area = area;
    }

    public void setPuerta(Puerta x) {

        puerta = x;
    }

    public void MostrarDatos() {

        Console.WriteLine($"Soy una Casa, mi área es {area} m2");
    }
}
