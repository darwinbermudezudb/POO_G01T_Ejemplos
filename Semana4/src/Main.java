//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Alumno a = new Alumno("Milena");
        System.out.println(a.primer_apellido);
        a.primer_apellido = "Mauricio";
        System.out.println(a.primer_apellido);
    }
}