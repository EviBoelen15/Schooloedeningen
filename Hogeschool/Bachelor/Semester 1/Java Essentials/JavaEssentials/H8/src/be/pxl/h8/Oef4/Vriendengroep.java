package be.pxl.h8.Oef4;

import java.util.ArrayList;

public class Vriendengroep {

    public ArrayList<Persoon> getLijstpersonen() {
        return lijstpersonen;
    }

    private ArrayList<Persoon> lijstpersonen = new ArrayList<>();

    private static final int MAX_AANTAL_VRIENDEN = 10;

    //HEEL BELANGRIJK
    public void voegVriendToe(Persoon persoon) {
        if (lijstpersonen.size() == MAX_AANTAL_VRIENDEN) {
            System.out.println("Max aantal vrienden is bereikt");
        } else {
            if (lijstpersonen.contains(persoon)) {
                System.out.println("De naam bestaat al.");
            } else {
                lijstpersonen.add(persoon);
            }
        }
    }

    public boolean verwijderVriend(String naam) {
        Persoon verwijderen = new Persoon(naam, 1, 1, 1);
        //remove geeft true of false terug adhv of het object is verwijdert.
        //indien dit false is bevatte de lijst het object niet en kon deze niet verwijdert worden
        boolean isverwijdert = false;
        if (!lijstpersonen.remove(verwijderen)) {

            System.out.println("Deze persoon is geen vriend en kan niet verwijdert worden");
            isverwijdert = true;
        } else {
            System.out.println("verwijdert.");
        }
        return isverwijdert;
    }

    public ArrayList<String> getVriendenString() {
        ArrayList<String> arreyNamen = new ArrayList<>();
        for (Persoon p : lijstpersonen) {
            arreyNamen.add(p.toString());
        }
        return arreyNamen;
    }

    public String getVolgendeJarige() {
        if (lijstpersonen.size() == 0) { return "ik heb geen vrienden meer"; }

        String volgendeJarige = "";
        long aantaldagenVolgendejarige = 500;

        for (Persoon p : lijstpersonen) {
            if (p.aantalDagenTotVerjaardag() < aantaldagenVolgendejarige) {
                aantaldagenVolgendejarige = p.aantalDagenTotVerjaardag();
                volgendeJarige = p.getNaam();
            }
        }
        return volgendeJarige;
    }
}
