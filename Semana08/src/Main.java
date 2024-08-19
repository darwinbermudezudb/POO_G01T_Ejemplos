import java.sql.*;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        try {
            Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:8889/miBD", "root", "abc123");
            Statement stmt = conn.createStatement();
            ResultSet rs = stmt.executeQuery("SELECT id, nombre, edad FROM usuarios");
            while (rs.next()){
                    int id = rs.getInt("id");
                    String nombre = rs.getString("nombre");
                    int edad = rs.getInt("edad");

                    System.out.println("El identificador es: " + id + ", el nombre es: " + nombre + " y la edad esL " + edad);
            }

        } catch (SQLException e){
            e.getMessage();
        }
    }
}