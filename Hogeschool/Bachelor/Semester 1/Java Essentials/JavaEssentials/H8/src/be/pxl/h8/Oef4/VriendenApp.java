package be.pxl.h8.Oef4;

import java.util.ArrayList;
import java.util.Scanner;

public class VriendenApp {
    public static void main(String[] args) {

        Vriendengroep vriendengroep = new Vriendengroep();
        Scanner scn = new Scanner(System.in); //create scanner object
        System.out.println("Naam: ");
        String naam = scn.nextLine(); //read user input

        while (!naam.equals("stop")) {
            System.out.println("Geef je geboortedatum in: ");
            int geboorteDag = scn.nextInt();
            int geboorteMaand = scn.nextInt();
            int geboorteJaar = scn.nextInt();

            Persoon persoon = new Persoon(naam, geboorteDag, geboorteMaand, geboorteJaar);
            vriendengroep.voegVriendToe(persoon);
            System.out.println("Naam: ");
            scn.nextLine();
            naam = scn.nextLine();
        }
        ArrayList<String> list = vriendengroep.getVriendenString();
        int lengtelijst = list.size();

        for (String s : list) {
            System.out.println(s);
        }

        System.out.println("Volgende jarige: " + vriendengroep.getVolgendeJarige());

        System.out.println("Wenst u vrienden te verwijderen? J/N");
        String keuze = scn.nextLine();
        int tellerverwijder = 0;
        while (keuze.toUpperCase().equals("J") && list.size() < 10) {
            System.out.println("Wie wil u graag verwijderen? ");
            naam = scn.nextLine();
            if (vriendengroep.verwijderVriend(naam)) {
                tellerverwijder++;
            }

            System.out.println("Wenst u vrienden te verwijderen? J/N");
            keuze = scn.nextLine();
        }
        if (tellerverwijder == lengtelijst) {
            System.out.println("Er zijn geen vrienden meer over");
        } else {
           for (String s : vriendengroep.getVriendenString()) {
               System.out.println(s);
           }
            System.out.println("De volgende jarige is " + vriendengroep.getVolgendeJarige());
        }
        scn.close();
    }
}
