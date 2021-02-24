def bereken_inkom(leeftijd, kinderen, inkomen, aansluitingsjaar):
    JAAR = 2019
    lidgeld = 100
    totaal_jaren_lid = JAAR - aansluitingsjaar
    if leeftijd >= 60:
        lidgeld -= 15

    if kinderen > 0:
        korting = 7.5 * kinderen
        if 7.5 * kinderen > 35:
            korting = 35
        lidgeld -= korting

    if totaal_jaren_lid > 20:
        lidgeld -= 12.5

    if inkomen < 7500:
        lidgeld -= 25

    if lidgeld < 50:
        lidgeld = 50

    return lidgeld

def main():
    naam = input("Naam: ")
    while not(naam == "X" or naam == "x"):
        leeftijd = int(input("Leeftijd: "))
        aantal_kinderen = int(input("Aantal kinderen: "))
        inkomen = int(input("Inkomen per jaar: "))
        aansluitingsjaar = int(input("Aansluitingsjaar: "))

        print(naam, "moet €", bereken_inkom(leeftijd, aantal_kinderen, inkomen, aansluitingsjaar), "betalen")

        naam = input("Naam: ")

if __name__ == '__main__':
    main()