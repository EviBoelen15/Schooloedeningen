package be.pxl.opgave;

import java.time.LocalDateTime;

public class Toernooi {
    private Wedstrijd[] wedstrijden;

    private static final int MAX_AANTAL_WEDSTRIJDEN = 10;

    public Toernooi() {
        this.wedstrijden = new Wedstrijd[MAX_AANTAL_WEDSTRIJDEN];
    }

    public void voegWedstrijdToe(Wedstrijd wdst) {
        //boolean stop = false;
        for(int i = 0; i < wedstrijden.length; i++) {
            if (wedstrijden[i] == null) {
                wedstrijden[i] = wdst;
                //stop = true;
                return;
            }
        }
        System.out.println("Geen ruimte meer voor wedstrijden");
    }

    public LocalDateTime zoekDatumVolgendeWedstrijdVan(String spelerId) {
        // This might be an error in the exam. Logic to get the first possible date (next upcoming game) should be inverted i think?
        LocalDateTime minDate = LocalDateTime.MIN;

        for (Wedstrijd wedstrijd : wedstrijden) {
            if (wedstrijd != null && wedstrijd.spelerIdKomtVoor(spelerId) && minDate.isBefore(wedstrijd.getWedstrijdDatum())) {
                minDate = wedstrijd.getWedstrijdDatum();
            }
        }
        return minDate == LocalDateTime.MIN ? null : minDate;
    }
}
