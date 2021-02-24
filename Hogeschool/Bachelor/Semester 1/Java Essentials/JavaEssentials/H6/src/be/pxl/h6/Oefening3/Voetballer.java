package be.pxl.h6.Oefening3;

import java.util.Arrays;

public final class Voetballer extends Sporter {
    private String opstelling;
    private String[] opstellingen = {"middenvelder", "aanvaller", "verdediger"};
    private String club;

    public Voetballer(String naam, String voorNaam) {
        super(naam, voorNaam, "Voetbal ");
    }

    public Voetballer(String naam, String voorNaam, String soortSport, String opstelling, String club) {
        super(naam, voorNaam, "Voetbal");
        this.opstelling = opstelling;
        this.club = club;
    }

    public String getClub() {
        return club;
    }

    public void setClub(String club) {
        this.club = club;
    }

    public String getOpstelling() {
        return opstelling;
    }

    public void setOpstelling(String opstelling) {
        this.opstelling = opstelling;
    }

    public void checkOpstelling(String opstelling) {
        boolean isInit = false;
        opstelling = opstelling.toLowerCase();
        for (String object : opstellingen)  {
            isInit = opstelling.equals(object);
        }
        /*for (int i = 0; i < opstellingen.length; i++) {
            if (opstelling.equals(opstellingen[i])) {
                isInit = true;
            }
            else {
                isInit = false;
            }
        }
         */
        if (!isInit) {
            this.opstelling = "onbekend";
        }
    }
    @Override
    public void print() {
        System.out.println(getVoorNaam() + " " + getNaam());
        System.out.println(getSoortSport());
        System.out.println("Club: " + club + " Opstelling: " + opstelling);
    }

}
