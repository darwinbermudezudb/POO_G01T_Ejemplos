//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Alumno a = new Alumno();
        a.generarCarnet("BP080489");
        System.out.println(a.carnet);
    }
}