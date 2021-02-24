package be.pxl.h6.Oefening3;

public class SportApp {
    public static void main(String[] args) {
        Sporter zwemmer1 = new Sporter("An", "Bex", "Zwemmen");
        Sporter volleyballer = new Sporter("bn", "Bex", "volleybal");
        Sporter zwemmer2 = new Sporter("Ansd", "Bex", "Zwemmen");
        Sporter zwemmer3 = new Sporter("Anqzd", "Bex", "Zwemmen");
        Sporter vb1 = new Voetballer("joren", "vos", "voetbal", "aanvaller", "fckip");
        Sporter vb2 = new Voetballer("joren", "vos", "voetbal", "verdediger", "fckip");
        Sporter vb3 = new Voetballer("joren", "vos", "voetbal", "jantje", "fckip");
        Sporter vb4 = new Voetballer("joren", "voske");
        String[] sporters = {zwemmer1, };
    }
}
