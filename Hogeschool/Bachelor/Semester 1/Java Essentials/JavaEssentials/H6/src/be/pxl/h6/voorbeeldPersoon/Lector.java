package be.pxl.h6.voorbeeldPersoon;

public class Lector extends Persoon {
    private int personeelsNummer;
    private double aanstPercent;
    private double salaris;

    public Lector() {
        this("", "", 0, 0, 0);

    }
    public Lector(String naam, String voorNaam, int personeelsNummer, double aanstPercent, double salaris) {
        super(naam, voorNaam);
        this.personeelsNummer = personeelsNummer;
        this.aanstPercent = aanstPercent;
        this.salaris = salaris;
    }

    public int getPersoneelsNummer() {
        return personeelsNummer;
    }

    public void setPersoneelsNummer(int personeelsNummer) {
        this.personeelsNummer = personeelsNummer;
    }

    public double getAanstPercent() {
        return aanstPercent;
    }

    public void setAanstPercent(double aanstPercent) {
        if (aanstPercent > 0 && aanstPercent < 100) {
            this.aanstPercent = aanstPercent;
        }
    }

    public double getSalaris() {
        return salaris;
    }

    public void setSalaris(double salaris) {
        this.salaris = salaris;
    }

    public void veranderPercent(double percent) {
        this.aanstPercent = percent;
        this.salaris = this.salaris / 100 * percent;
    }

    @Override
    public void print() {
        super.print();
        System.out.println("naam: " + getNaam());
        System.out.println("voornaam: " + getVoorNaam());
        System.out.println("personeelsnummer: " + personeelsNummer);
        System.out.println("salaris: " + salaris);
        System.out.println("percent: " + aanstPercent);
    }
}
