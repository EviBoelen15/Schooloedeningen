package be.pxl.opgave.mains;

import be.pxl.opgave.Scheidsrechter;
import be.pxl.opgave.Speler;
import be.pxl.opgave.Sport;

public class PersoonApp {
    public static void main(String[] args) {
        Speler speler1 = new Speler("A12AA", "Tim Schuermans", Sport.TENNIS);
        System.out.println(speler1.toString());
        Scheidsrechter scheidsrechter1 = new Scheidsrechter("_B", "Sofie Verlaek");
        System.out.println(scheidsrechter1.toString());
        /* output
        [A12] Tim Schuermans (ten)
        [B] Sofie Verlaek <ref>
         */
    }
}
