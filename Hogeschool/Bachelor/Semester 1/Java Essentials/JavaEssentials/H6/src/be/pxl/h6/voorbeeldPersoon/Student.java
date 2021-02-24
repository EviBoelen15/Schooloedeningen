package be.pxl.h6.voorbeeldPersoon;

public class Student extends Persoon {

    private int leerkrediet;
    private String studentnummer;
    private String opleiding;

    public Student() {
        this("", "", "15999999","xxx", 140);
    }
    public Student(String n, String vn) {
        super(n, vn);
    }
    public Student(String naam, String voornaam, String studentennummer, String opleiding, int leerkrediet) {
        super(naam, voornaam);
        this.studentnummer = studentennummer;
        this.opleiding = opleiding;
        this.leerkrediet = leerkrediet;
    }
    public  Student(Student student) {
        super(student.getNaam(), student.getVoorNaam());
        this.studentnummer = student.studentnummer;
        this.leerkrediet = student.leerkrediet;
        this.opleiding = student.opleiding;
    }
    public int getLeerkrediet() {
        return leerkrediet;
    }

    public void setLeerkrediet(int leerkrediet) {
        if (0 < leerkrediet && leerkrediet < 141) {
            this.leerkrediet = leerkrediet;
        }
    }

    public String getStudentnummer() {
        return studentnummer;
    }

    public void setStudentnummer(String studentnummer) {
        this.studentnummer = studentnummer;
    }

    public String getOpleiding() {
        return opleiding;
    }

    public void setOpleiding(String opleiding) {
        this.opleiding = opleiding;
    }

    public void wijzigLeerkrediet(int leerkrediet) {
        if (0 < leerkrediet && leerkrediet < 141) {
            this.leerkrediet = leerkrediet;
        }
    }
    @Override
    public void print() {
        super.print();
        System.out.println("studentnummer: " + studentnummer);
        System.out.println("opleiding: " + opleiding);
        System.out.println("leerkrediet: " + leerkrediet);
    }
}
