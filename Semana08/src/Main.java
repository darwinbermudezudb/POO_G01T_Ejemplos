import java.sql.*;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) throws SQLException {
        ConnectionDbMysql conn = new ConnectionDbMysql();;


        // consulta de datos
        ResultSet usuario_consultar = conn.consultar("SELECT id, nombre, edad FROM usuarios");
        while (usuario_consultar.next()){
            int id = usuario_consultar.getInt("id");
            String nombre = usuario_consultar.getString("nombre");
            int edad = usuario_consultar.getInt("edad");
            System.out.println("El resultado de usuario es: El identificador es: " + id + ", el nombre es: " + nombre + " y la edad esL " + edad);
        }

        /*
        // consulta de datos
        ResultSet cliente_consultar = conn.consultar("SELECT id, nombre, apellido, edad FROM cliente");
        while (cliente_consultar.next()){
            int id = cliente_consultar.getInt("id");
            String nombre = cliente_consultar.getString("nombre");
            String apellido = cliente_consultar.getString("apellido");
            int edad = cliente_consultar.getInt("edad");
            System.out.println("El resultado de cliente es: El identificador es: " + id + ", el nombre es: " + nombre + ", el apellido es: "  + apellido + " y la edad esL " + edad);
        }
    */

        // Insert
        PreparedStatement usuario_insertar = conn.insert("INSERT INTO usuarios (nombre, edad) VALUES (?, ?)");
        usuario_insertar.setString(1, "Oscar");
        usuario_insertar.setInt(2, 20);
        usuario_insertar.executeUpdate();

        PreparedStatement usuario_actualizacion = conn.update("UPDATE usuarios SET nombre = ? WHERE id = ?");
        usuario_actualizacion.setString(1, "Alexandra");
        usuario_actualizacion.setInt(2, 6);
        int rowsAffected = usuario_actualizacion.executeUpdate();
askjdlahsldkhalsh
        PreparedStatement usuario_borrrar = conn.delete("Delete FROM usuarios");
        usuario_borrrar.executeUpdate();


        usuario_consultar = conn.consultar("SELECT id, nombre, edad FROM usuarios");
        while (usuario_consultar.next()){
            int id = usuario_consultar.getInt("id");
            String nombre = usuario_consultar.getString("nombre");
            int edad = usuario_consultar.getInt("edad");
            System.out.println("El resultado de usuario es: El identificador es: " + id + ", el nombre es: " + nombre + " y la edad esL " + edad);
        }


    }
}