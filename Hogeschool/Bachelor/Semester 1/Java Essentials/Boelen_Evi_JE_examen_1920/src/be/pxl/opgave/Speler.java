package be.pxl.opgave;

public final class Speler extends Persoon {
    private Sport sport;

    public Speler(String id) {
        this(id, " ", null);
    }

    public Speler(String id, String naam, Sport sport) {
        super(id, naam);
        this.sport = sport;
    }


    public Sport getSport() {
        return sport;
    }

    @Override
    public String toString() {
        return String.format("[%s] %s (%s)", this.getId(), this.getNaam(), this.sport);
    }
}
