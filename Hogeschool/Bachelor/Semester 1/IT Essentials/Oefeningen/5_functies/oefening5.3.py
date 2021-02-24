def bereken_lidgeld(leeftijd, aantal_kinderen, aansluitingsjaar, inkomen):
    startgeld = 100
    HUIDIGJAAR = 2019
    jaren_aangesloten = HUIDIGJAAR - aansluitingsjaar

    if leeftijd > 60:
        startgeld -= 15

    if aantal_kinderen > 0:
        if aantal_kinderen * 7.5 <= 35:
            startgeld -= aantal_kinderen * 7.5

    if jaren_aangesloten > 20:
        startgeld -= 12.5

    if inkomen < 7500:
        startgeld -= 25

    if startgeld < 50:
        startgeld = 50

    return startgeld


def main():
    naam_gebruiker = input("Naam: ")
    leeftijd_gebruiker = int(input("Leeftijd: "))
    aantalKinderen_gebruiker = int(input("Aantal kinderen: "))
    inkomen_gebruiker = int(input("Jaarlijks inkomen: "))
    aansluitingsjaar_gebruiker = int(input("Aansluitingsjaar: "))

    lidgeld = bereken_lidgeld(leeftijd_gebruiker, aansluitingsjaar_gebruiker, aansluitingsjaar_gebruiker, inkomen_gebruiker)
    print("U betaald", lidgeld)


if __name__ == '__main__':
    main()