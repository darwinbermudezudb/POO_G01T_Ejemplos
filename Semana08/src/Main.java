import java.sql.*;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) throws SQLException {
        ConnectionDbMysql conn = new ConnectionDbMysql();;

        System.out.println("------------------- Tabla usuarios, vista 1 ----------------------");
        ResultSet usuarios_read = conn.consultar("SELECT id, nombre, edad FROM usuarios");
        while (usuarios_read.next()){
            int id = usuarios_read.getInt("id");
            String nombre = usuarios_read.getString("nombre");
            int edad = usuarios_read.getInt("edad");

            System.out.println("El identificador es: " + id + ", el nombre es: " + nombre + " y la edad esL " + edad);
        }
        conn.create("INSERT INTO usuarios (nombre, edad) VALUES (?, ?)");
        conn.pd_stmt.setString(1, "Roberto");
        conn.pd_stmt.setInt(2, 14);
        conn.pd_stmt.executeUpdate();

        System.out.println("------------------- Tabla usuarios, vista 2 ----------------------");
        ResultSet usuarios_read_2 = conn.consultar("SELECT id, nombre, edad FROM usuarios");
        while (usuarios_read_2.next()){
            int id = usuarios_read_2.getInt("id");
            String nombre = usuarios_read_2.getString("nombre");
            int edad = usuarios_read_2.getInt("edad");

            System.out.println("El identificador es: " + id + ", el nombre es: " + nombre + " y la edad esL " + edad);
        }

    }
}