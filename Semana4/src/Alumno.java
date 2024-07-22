public class Alumno {

    String nombre = "";
    String primer_apellido = "";
    String segundo_apellido = "";
    String carnet = "";

    public Alumno(){
        this.primer_apellido = "Alguien";
    }

    public Alumno(String primer_apellido) {
        this.primer_apellido = primer_apellido;
    }

    public String obtenerNombre(){
        return this.nombre;
    }

    public String obtenerNombre(String nombre){
        return this.nombre = nombre;
    }


}
