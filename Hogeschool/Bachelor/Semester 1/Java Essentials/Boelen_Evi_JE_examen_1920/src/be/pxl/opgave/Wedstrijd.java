package be.pxl.opgave;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;

public class Wedstrijd implements DatumVergelijkbaar {

    private static final DateTimeFormatter FORMATTER = DateTimeFormatter.ofPattern("dd/MM/YY HH:mm");

    private LocalDateTime wedstrijdDatum;
    private Team team1;
    private Team team2;
    private Scheidsrechter scheidsrechter;
    private int scoreTeam1;
    private int scoreTeam2;

    public Wedstrijd(Team team1, Team team2, Scheidsrechter scheidsrechter,
                     int dag, int maand, int jaar, int uur, int minuut) {
        this.team1 = team1;
        this.team2 = team2;
        this.scheidsrechter = scheidsrechter;
        this.wedstrijdDatum = LocalDateTime.of(jaar, maand, dag, uur, minuut);
    }

    public LocalDateTime getWedstrijdDatum() {
        return wedstrijdDatum;
    }

    public void setScore(int scoreTeam1, int scoreTeam2) {
        this.scoreTeam1 = scoreTeam1;
        this.scoreTeam2 = scoreTeam2;
    }

    public boolean spelerIdKomtVoor(String spelerId) {
        if (team1 != null) {
            return team1.spelerIdKomtVoor(spelerId);
        } else {
            if (team2 != null) {
                return team2.spelerIdKomtVoor(spelerId);
            } else {
                return false;
            }
        }
    }

    @Override
    public long berekenAantalMinutenNa(LocalDateTime ldt) {
        long minutes = ChronoUnit.MINUTES.between(ldt, LocalDateTime.now());
        if (ldt.isBefore(LocalDateTime.now())) {
            return -minutes;
        } else {
            return minutes;
        }

        //return wedstrijdDatum.until(datum, MINUTES);
    }

    @Override
    public String toString() {
        if (wedstrijdDatum.isBefore(LocalDateTime.now())) {
            return"Team 1" + "\n"
                    + team1 + "\n"
                    + "Team 2"
                    + team2 + "\n"
                    + wedstrijdDatum.format(FORMATTER) + "\n"
                    + "Scheidsrechter" + scheidsrechter + "\n"
                    + "Score: "
                    + scoreTeam1 + " " + scoreTeam2;
        } else {
            return "Team 1" + "\n"
                    + team1.toString() + "\n"
                    + "Team 2"
                    + team2.toString() + "\n"
                    + wedstrijdDatum.format(FORMATTER) + "\n"
                    + "Scheidsrechter" + scheidsrechter + "\n";
        }
    }

}
