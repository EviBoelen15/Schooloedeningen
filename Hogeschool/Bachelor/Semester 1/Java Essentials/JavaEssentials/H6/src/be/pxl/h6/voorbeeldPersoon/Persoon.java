package be.pxl.h6.voorbeeldPersoon;

public class Persoon {
    private String naam;
    private String voorNaam;

    public Persoon() {
        this("", "");
    }
    public Persoon(String naam, String voorNaam) {
        this.naam = naam;
        this.voorNaam = voorNaam;
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public String getVoorNaam() {
        return voorNaam;
    }

    public void setVoorNaam(String voorNaam) {
        this.voorNaam = voorNaam;
    }

    public void print() {
        System.out.println("naam: " + voorNaam + " " + naam);
    }
}
