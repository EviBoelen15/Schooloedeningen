package be.pxl.h1.oef2;
import java.time.LocalDateTime;
import java.util.Scanner;
import java.time.LocalDate;


public class bijdrageTennisclub {

    public static void main(String[] args) {
        /*
        Scanner keyboard = new Scanner(System.in);
        System.out.println("Geef je leeftijd:");
        int leeftijd = keyboard.nextInt();
        if(leeftijd >= 18) {
           System.out.println("Je bent volwassen");
        }
        else{
           System.out.println("Je bent een kind");
        }
        keyboard.close();
         */
        double REDUCTIE_LEEFTIJD = 15.5;
        double REDUCTIE_JAAR = 2.5;

        double basis_bedrag = 100;

        Scanner keyboard = new Scanner(System.in);
        System.out.println("Naam: ");
        String naam = keyboard.next();
        keyboard.nextLine();
        System.out.println("aansluitingsjaar: ");
        int aansluitngsjaar = keyboard.nextInt();
        keyboard.close();

        int aantal_jaren_lid = (LocalDate.now().getYear() - (int) aansluitngsjaar);
        basis_bedrag -= (aantal_jaren_lid * REDUCTIE_JAAR);

        if (basis_bedrag < 62.5) {
            basis_bedrag = 62.5;
            System.out.println("U moet " + basis_bedrag + " betalen.");
        }
        else {
            System.out.println("U moet " + basis_bedrag + " betalen.");
        }

    }
}
