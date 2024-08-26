import java.sql.*;

public class ConnectionDbMysql {
    private String usuario;
    private String dominio;
    private int puerto;
    private String db_name;
    private String clave;
    private Connection conn;
    public Statement stmt;
    private PreparedStatement pstmt;

    public ConnectionDbMysql(){
        this.dominio = "jdbc:mysql://localhost";
        this.puerto = 8889;
        this.db_name = "miBD";
        this.usuario = "root";
        this.clave = "abc123";

        this.connet();
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public void setClave(String clave) {
        this.clave = clave;
    }

    public void connet(){
        try{
            String stringconnection = this.dominio + ":" + this.puerto + "/" + this.db_name;
            this.conn = DriverManager.getConnection(stringconnection, this.usuario, this.clave);
        }catch (SQLException e){
            System.out.println(e.getMessage());
        }
    }

    public ResultSet consultar(String query) throws SQLException {
        this.stmt = conn.createStatement();
        ResultSet rs = this.stmt.executeQuery(query);
        return rs;
    }

    public PreparedStatement insert(String query) throws SQLException {
        this.pstmt = conn.prepareStatement(query);
        return this.pstmt;
    }

    public PreparedStatement update(String query) throws SQLException {
        this.pstmt = conn.prepareStatement(query);
        return this.pstmt;
    }

    public PreparedStatement delete(String query) throws SQLException {
        this.pstmt = conn.prepareStatement(query);
        return this.pstmt;
    }

}
