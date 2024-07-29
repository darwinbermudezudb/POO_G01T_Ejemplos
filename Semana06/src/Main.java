import javax.swing.*;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {

        // Frame para pantalla en clase
        JFrame frame = new JFrame("Mi aplicacion");
        frame.setSize(500, 500);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);

        // Inicio de panel
        JPanel panel = new JPanel();
        frame.add(panel);

        JLabel label = new JLabel("Hola, mundo!");
        panel.add(label);

        JTextField text_field = new JTextField(20);
        panel.add(text_field);
    }
}