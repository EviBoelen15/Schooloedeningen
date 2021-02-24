package be.pxl.opgave;

public abstract class Persoon {
    private String id;
    private String naam;

    public Persoon(String id, String naam) {
        StringBuilder idBuilder = new StringBuilder("");
        for (char c : id.toString().toCharArray()) {
            boolean isletter = Character.isDigit(c) || Character.isLetter(c);
            if (idBuilder.length() < 3) {
                if (isletter) {
                    idBuilder.append(c);
                }
            }
        }
        this.id = (idBuilder.toString()).toUpperCase();
        this.naam = naam;
    }

    @Override
    public boolean equals(Object obj) {
        //check als het object een object is
        if (this == obj) {
          return true;
        }
        //checkt als het object een persoon is
        if (obj == null || getClass() != obj.getClass()) {
            return false;
        }
        Persoon anderepersoon = (Persoon) obj;

        return anderepersoon.id.equals(this.id);
    }

    public String getId() {
        return id;
    }

    public String getNaam() {
        return naam;
    }

    public String toString() {
        return String.format("[%1s] %2s", id, naam);
    }
}
