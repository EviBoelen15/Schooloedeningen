package be.pxl.h6.Oefening3;
import be.pxl.h6.voorbeeldPersoon.Persoon;

public class Sporter extends Persoon {
    private String soortSport;
    public int aantalSporters;

    public Sporter() {
        this("", "", "onbepaald");
    }

    public Sporter(String naam, String voorNaam, String soortSport) {
        super(naam, voorNaam);
        this.soortSport = soortSport;
        aantalSporters++;
    }

    public String getSoortSport() {
        return soortSport;
    }

    public void setSoortSport(String soortSport) {
        this.soortSport = soortSport;
    }

    public void veranderSport(String soortSport) {
        this.soortSport = soortSport;
    }

    public void print() {
        System.out.println(getVoorNaam() + " " + getNaam());
        System.out.println(soortSport);
    }

}
