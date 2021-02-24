package be.pxl.opgave;

public class Team {
    private Sport sport;
    private Speler[] spelers;

    public Team(Sport sport) {
        this.sport = sport;
        this.spelers = new Speler[sport.aantalSpelers];
    }

    public void voegSpelerToe(Speler speler) {
        if (!spelerKomtVoor(speler) && speler.getSport().equals(this.sport)) {
            int index = vindVrijePositie();
            if (index != -1) {
                spelers[index] = speler;
            }
        } else {
            System.out.println("Foutieve ingave");
        }

    }
    private boolean spelerKomtVoor(Speler speler) {
        return spelerIdKomtVoor(speler.getId());
    }

    boolean spelerIdKomtVoor(String spelerId) {
        for (Speler s : spelers) {
            if (new Speler(spelerId).equals(s)) {
                return true;
            }
        }
        return false;
    }
    private int vindVrijePositie() {
        for (int i = 0, aantal = spelers.length; i < aantal; i++) {
            if (spelers[i] == null) {
                return i;
            }
        }
        return -1;
    }

    @Override
    public String toString() {
        int positie = vindVrijePositie();
        StringBuilder sb = new StringBuilder();
        if (positie == -1) {
            for (Speler s : spelers) {
                sb.append(s.toString());
                sb.append("\n");
            }
        } else {
            return "onvolledig team";
        }
        return sb.toString();
    }
}
