package be.pxl.h2.opdracht1;

public class RechthoekApp {
    public static void main(String[] args) {
        System.out.println("Dit programma maakt een rechthoek");
        Rechthoek rechthoek = new Rechthoek();
        Rechthoek rechthoek2 = new Rechthoek();

        System.out.print(rechthoek.hoogte + " ");
        System.out.print(rechthoek.breedte + " ");
        System.out.print(rechthoek.x + " ");
        System.out.println(rechthoek.y + " ");

        rechthoek.hoogte = 10;
        rechthoek.breedte = 20;
        rechthoek.x = 15;
        rechthoek.y = 23;

        System.out.print(rechthoek.hoogte + " ");
        System.out.print(rechthoek.breedte + " ");
        System.out.print(rechthoek.x + " ");
        System.out.println(rechthoek.y);

        rechthoek2.hoogte = 123;
        rechthoek2.breedte = 50;
        rechthoek2.x = 0;
        rechthoek2.y = 0;

        System.out.print(rechthoek2.hoogte + " ");
        System.out.print(rechthoek2.breedte + " ");
        System.out.print(rechthoek2.x + " ");
        System.out.println(rechthoek2.y);
    }
}
