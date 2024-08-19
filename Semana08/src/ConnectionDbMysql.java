import java.sql.*;

public class ConnectionDbMysql {
    private String usuario;
    private String dominio;
    private int puerto;
    private String db_name;
    private String clave;
    public Statement stmt;

    public ConnectionDbMysql(){
        this.dominio = "jdbc:mysql://localhost";
        this.puerto = 8889;
        this.usuario = "root";
        this.db_name = "miBD";
        this.clave = "abc123";
    }

    public void connet(){
        try{
            String stringconnection = this.dominio + ":" + this.puerto + "/" + this.db_name;
            Connection conn = DriverManager.getConnection(stringconnection, this.usuario, this.clave);
            this.stmt = conn.createStatement();
        }catch (SQLException e){
            System.out.println(e.getMessage());
        }
    }

    public void consultar(String query) throws SQLException {
        ResultSet rs = this.stmt.executeQuery(query);
        while (rs.next()){
            int id = rs.getInt("id");
            String nombre = rs.getString("nombre");
            int edad = rs.getInt("edad");

            System.out.println("El identificador es: " + id + ", el nombre es: " + nombre + " y la edad esL " + edad);
        }
    }
}
