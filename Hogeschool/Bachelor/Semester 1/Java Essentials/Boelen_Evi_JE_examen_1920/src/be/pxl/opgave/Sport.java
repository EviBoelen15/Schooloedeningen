package be.pxl.opgave;

public enum Sport {
    VOETBAL(11),
    VOLLEYBAL(8),
    TENNIS(2);

    public int aantalSpelers;

    Sport(int aantalspelers) {
        this.aantalSpelers = aantalspelers;
    }

    public int getAantalSpelers() {
        return aantalSpelers;
    }

    @Override
    public String toString() {
        return this.name().toLowerCase().substring(0,3);
    }
}
