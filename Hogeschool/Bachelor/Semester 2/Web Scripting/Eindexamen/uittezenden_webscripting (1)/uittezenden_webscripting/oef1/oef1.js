// naam: Evi Boelen 1TINH

class Persoon {
    constructor(id, naam) {
        if ((Number.isInteger(id) && id > 0) && typeof naam === 'string') {
            this.id = id;
            this.naam = naam;
        }
        Error("ID moet een integer, en groter dan 0 zijn. Naam moet een string zijn")
    }

    toString() {
        return `[${this.id}] ${this.naam}`;
    }
}
class Loonwerker extends Persoon {
    constructor(id, naam, loonPerUur, aantalUrenGewerkt) {
        super(id, naam);
        if ((Number.isInteger(loonPerUur) && loonPerUur > 0)
            && (Number.isInteger(aantalUrenGewerkt) && aantalUrenGewerkt > 0)) {
            this.loonPerUur = loonPerUur;
            this.aantalUrenGewerkt = aantalUrenGewerkt;
        }
        Error("Zowel het aantal uren als het loon per uur moet groter dan 0 zijn");
    }

    berekenLoon() {
        return this.aantalUrenGewerkt * this.loonPerUur;
    }

    toString() {
        return `[${this.id}] ${this.naam} = ${this.berekenLoon()}`;
    }

}
class Manager extends Persoon {
    loonwerkers = [];
    constructor(id, naam, loonwerkers) {
        super(id, naam);
        this.loonwerkers = loonwerkers;
    }

    voegLoonWerkerToe(loonwerker) {
        if (typeof loonwerker === this.Loonwerker) {
            this.loonwerkers.push(loonwerker);
        }
        Error("enkel loonwerkers kunnen toegevoegd worden aan deze lijst");
    }

    berekenLoon() {
        const som = arr => arr.reduce((a,b) => a + b, 0);
        return som * 0.2;
    }

    toString() {
        return `[${this.id}] ${this.naam} = ${this.berekenLoon()}`;
    }
}
let persoon = new Persoon(1,"mieke");
let manager=new Manager(2,"jan");
let werker1=new Loonwerker(3,"tim",11,13);
let werker2=new Loonwerker(4,"sofie",2,50);

manager.voegLoonWerkerToe(werker1);
manager.voegLoonWerkerToe(werker2);

console.log(persoon.toString());
// [1] mieke 
console.log(werker1.toString());
// [3] tim = 143
console.log(werker2.toString());
// [4] sofie = 100
console.log(manager.toString());
// [2] jan = 49 

