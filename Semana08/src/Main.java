import java.sql.*;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) throws SQLException {
        ConnectionDbMysql conn = new ConnectionDbMysql();;
        conn.connet();
        conn.consultar("\"SELECT id, nombre, edad FROM usuarios\"");
    }
}