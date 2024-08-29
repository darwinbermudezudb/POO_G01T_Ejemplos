import java.sql.*;

public class ConnectionDbMysql {
    private String usuario;
    private String dominio;
    private int puerto;
    private String db_name;
    private String clave;
    private Statement stmt;
    private Connection conn;
    public PreparedStatement pd_stmt;

    public ConnectionDbMysql(){
        this.dominio = "jdbc:mysql://localhost";
        this.puerto = 8889;
        this.usuario = "root";
        this.db_name = "miBD";
        this.clave = "abc123";

        try{
            String stringconnection = this.dominio + ":" + this.puerto + "/" + this.db_name;
            this.conn = DriverManager.getConnection(stringconnection, this.usuario, this.clave);
        }catch (SQLException e){
            System.out.println(e.getMessage());
        }
    }


    public ResultSet consultar(String query) throws SQLException {
        this.stmt = this.conn.createStatement();
        ResultSet rs = this.stmt.executeQuery(query);
        return rs;
    }

    public void create(String query) throws SQLException {
        this.pd_stmt = this.conn.prepareStatement(query);
    }
}
