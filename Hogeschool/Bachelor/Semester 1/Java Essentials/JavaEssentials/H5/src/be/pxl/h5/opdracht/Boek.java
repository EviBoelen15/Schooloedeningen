package be.pxl.h5.opdracht;

public class Boek {
    private String isbn;
    private String titel;
    private int bladzijden;
    private Auteur auteur;

    public Boek() {
        auteur = new Auteur("Jan", "Hermans");
    }

    public Boek(String isbn, String titel, int bladzijden, Auteur auteur) {
        this.isbn = isbn;
        this.titel = titel;
        this.bladzijden = bladzijden;
        this.auteur = new Auteur();
    }

    public String getIsbn() {
        return isbn;
    }

    public void setIsbn(String isbn) {
        this.isbn = isbn;
    }

    public String getTitel() {
        return titel;
    }

    public void setTitel(String titel) {
        this.titel = titel;
    }

    public int getBladzijden() {
        return bladzijden;
    }

    public void setBladzijden(int bladzijden) {
        this.bladzijden = bladzijden;
    }

    public Auteur getAuteur() {
        return auteur;
    }

    public void setAuteur(Auteur auteur) {
        this.auteur = auteur;
    }
    public String ToonBoekGegevens() {
        return auteur.toString() + ", Aantal paginas: " + bladzijden + " titel: " + titel + " isbn: " + isbn;
    }
}
