package be.pxl.h8.Oef4;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;

public class Persoon {
    private String naam;
    private LocalDate geboorteDatum;

    public Persoon(String naam, int dag, int maand, int jaar) {
        this.naam = naam;
        this.geboorteDatum = LocalDate.of(jaar, maand, dag);
    }

    public String getNaam() {
        return naam;
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
        return anderepersoon.naam.equals(this.naam);
    }

    public String toString() {
        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("dd MM  yyyy");
        return this.naam + "  " + dtf.format(this.geboorteDatum);
    }

    public int aantalDagenTotVerjaardag() {
        LocalDate now = LocalDate.now();
        LocalDate verjaardag = LocalDate.of(now.getYear(), this.geboorteDatum.getMonth(), this.geboorteDatum.getDayOfMonth());
        if (verjaardag.isBefore(now)) {
            verjaardag = verjaardag.plusYears(1);
        }
        long aantaldagen = ChronoUnit.DAYS.between(LocalDate.now(),verjaardag);
        return (int)aantaldagen;
    }
}
