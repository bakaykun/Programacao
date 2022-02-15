import javax.swing.JOptionPane;

public class Reajuste {
    public static void main( final String[] args) {
        double porc;
        double reaj;
        final String nome = JOptionPane.showInputDialog(null, "Nome do funcionário: ");
        final int cargo = Integer.parseInt(JOptionPane.showInputDialog(null, "Número do cargo que ele ocupa: "));
        final double sal = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite o Salario do funcionário"));

        switch (cargo) {
        case 1:
        case 5:
        case 9:

            porc = (sal * 5) / 100;
            reaj = porc + sal;
            JOptionPane.showConfirmDialog(null,"O funcionário " + nome + "\n Vai receber " + porc+ " de aumento.\r Seu salário passa a ser " + reaj + " Reais","Reajuste", JOptionPane.INFORMATION_MESSAGE);

            break;
        case 10:
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:

            porc = (sal * 10) / 100;
            reaj = porc + sal;
            JOptionPane.showConfirmDialog(null,"O funcionário " + nome + "\n Vai receber " + porc+ " de aumento.\r Seu salário passa a ser " + reaj + " Reais","Reajuste", JOptionPane.INFORMATION_MESSAGE);

            break;
        default:

             porc = (sal * 15) / 100;
             reaj = porc + sal;
            JOptionPane.showConfirmDialog(null,"O funcionário " + nome + "\n Vai receber " + porc+ " de aumento.\r Seu salário passa a ser " + reaj + " Reais","Reajuste", JOptionPane.INFORMATION_MESSAGE);

            break;
        }

    }
}