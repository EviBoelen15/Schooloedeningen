package be.pxl.h5.opdracht;

public class BoekApp {
    public static void main(String[] args) {
        Boek boek = new Boek();
        System.out.println(boek.getAuteur());
        boek.setBladzijden(100);
        boek.setIsbn("ldfhudsf");
        boek.setTitel("Cell");
        System.out.println(boek.ToonBoekGegevens());

    }
}
