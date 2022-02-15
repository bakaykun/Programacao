import javax.swing.JOptionPane;

//O objetivo do programa é fazer com que o usuário digite uma das opções desejadas e após isso, insira dados que ele quiser a fim de ver qual tipo de triângulo os dados inseridos resultam.
public class Triangulo {
    public static void main(final String args[]) {
         String op = JOptionPane.showInputDialog("Qual opção deseja? \n [A] - Lado \n [B] - Ângulo \n");

        switch (op) {
            case "A":
            case "a":

            double l1 = Double.parseDouble(JOptionPane.showInputDialog("Valor do lado 1"));
            double l2 = Double.parseDouble(JOptionPane.showInputDialog("Valor do lado 2"));
            double l3 = Double.parseDouble(JOptionPane.showInputDialog("Valor do lado 3"));

            // Condição para determinar se os valores inseridos se emquadram em triângulos
            // ou não.
            if ((l1 + l2 > l3) && (l2 + l3 > l1) && (l1 + l3 > l2)) {
                // condições para os tipos de trângulo acutângulo, isósceles e escaleno.
                if (l1 == l2 && l2 == l3 && l3 == l1) {
                    JOptionPane.showMessageDialog(null,"Os valores dos lados digitados resultam em um triângulo equilátero", "Lados ",JOptionPane.PLAIN_MESSAGE);
                } else if (l1 != l2 && l2 == l3 && l3 != l1) {
                    JOptionPane.showMessageDialog(null,"Os valores dos lados digitados resultam em um triângulo isósceles", "Lados ",JOptionPane.PLAIN_MESSAGE);
                } else {
                    JOptionPane.showMessageDialog(null," Os valores dos lados digitados resultam tem um Trinângulo escaleno", "Lados ",JOptionPane.PLAIN_MESSAGE);

                }
                // mensagem que vai aparecer caso os valores digitados não formem um triângulo.
            } else {
                JOptionPane.showMessageDialog(null, "Pois é meu consagrado, saporra não é um triângulo !", "MOIADO",JOptionPane.PLAIN_MESSAGE);
            }
            break;

        // Segunda condição, para que a partir dos ângulos que a pessoa digitou o
        // programa mostre o tipo de triângulo que é.
        case "B":
        case "b":

        
            double a1 = Double.parseDouble(JOptionPane.showInputDialog("Valor do Ângulo 1"));
            double a2 = Double.parseDouble(JOptionPane.showInputDialog("Valor do Ângulo 2"));
            double a3 = Double.parseDouble(JOptionPane.showInputDialog("Valor do Ângulo 3"));

        if (a1+a2+a3 == 180) {

            if (a1 < 90 && a2 < 90 && a3 < 90) {

                JOptionPane.showMessageDialog(null," Os valores dos lados digitados resultam tem um Trinângulo acutângulo", "Ângulo ",JOptionPane.PLAIN_MESSAGE);
    
            } else if (a1 == 90 || a2 == 90 || a3 == 90) {
    
                JOptionPane.showMessageDialog(null," Os valores dos lados digitados resultam tem um Trinângulo retângulo", "Ângulo ",JOptionPane.PLAIN_MESSAGE);
    
            } else {
    
                JOptionPane.showMessageDialog(null," Os valores dos lados digitados resultam tem um Trinângulo obtusângulo", "Âtenção ",JOptionPane.PLAIN_MESSAGE);
    
            }

        } else { JOptionPane.showMessageDialog(null, "Poxa meu parceiro, os valores digitados não dá 180°\n Digite novos valores re-executando o programa!", "JAGAURA", JOptionPane.PLAIN_MESSAGE);}

            break;
        default:
            JOptionPane.showMessageDialog(null, "Ai tu não colabora meu rei\n. Escolha a opção certa !", "JAGUARA ",JOptionPane.PLAIN_MESSAGE);
        }
    }
}