def main():
    def vervoer(type, afstand):
        if type == "R":
            kost = 25
            extra1 = 2.25
            extra2 = 1.75
        elif type == "Z":
            kost = 20
            extra1 = 1.75
            extra2 = 1.15
        if afstand >= 11:
            kost += extra1 * (afstand - 11)
        elif afstand >= 21:
            kost += extra2 * (afstand - 21)
        return kost

    def mutualiteit(type, afstand):
        if type == "R":
            extrakorting = 15
            perkm = 1.5
        elif type == "Z":
            extrakorting = 10
            perkm = 1
        if afstand >= 11:
            extrakorting += perkm * (afstand - 10)
        return extrakorting

    def totale_kostprijs(basiskost, korting):
        totaal = basiskost - korting
        return totaal

    naam = input("Geef een naam in: ")
    aantal_lid = 0
    aantal_nietlid = 0
    aantal_slachtoffers = 0

    while naam != "/":
        type_vervoer = input("Werd u vervoerd met een zoeken of reanimatiewagen? (Z/R) ")
        kmafstand = float(input("Hoeveel KM werd u vervoerd? "))
        mutu = input("Bent u lid van een mutualiteit? (J/N) ")

        if mutu == "J":
            totale_korting = mutualiteit(type_vervoer, kmafstand)
            aantal_lid += 1
        else:
            totale_korting = 0
            aantal_nietlid += 1

        kost_vervoer = vervoer(type_vervoer, kmafstand)
        totale_kost = totale_kostprijs(kost_vervoer, totale_korting)
        aantal_slachtoffers += 1

        print(naam, ' ', kost_vervoer, ' ', totale_kost)
        naam = input("Geef een naam in: ")

    print("Aantal slachtoffers: ", aantal_slachtoffers)

    if aantal_nietlid == 0 or aantal_lid == 0:
        print("EHY BROER DA MAG NIE")
    print("Percent mutualiteit: ", round(aantal_lid / aantal_slachtoffers * 100, 2))


if __name__ == '__main__':
    main()
