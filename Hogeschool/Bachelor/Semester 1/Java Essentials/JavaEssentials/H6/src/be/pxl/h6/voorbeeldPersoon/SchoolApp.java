package be.pxl.h6.voorbeeldPersoon;

public class SchoolApp {
    public static void main(String[] args) {
        Persoon persoon = new Persoon();
        Student student = new Student();
        Lector lector = new Lector();

        persoon.setVoorNaam("elke54");
        persoon.setNaam("depeutere");

        student.setNaam("Boelen");
        student.setVoorNaam("Evi");
        student.setLeerkrediet(138);

        System.out.println(student.toString());
        System.out.println((student.getLeerkrediet()));

        student.wijzigLeerkrediet(100);
        System.out.println((student.getLeerkrediet()));

        student.print();
        persoon.print();
        lector.print();

    }
}
