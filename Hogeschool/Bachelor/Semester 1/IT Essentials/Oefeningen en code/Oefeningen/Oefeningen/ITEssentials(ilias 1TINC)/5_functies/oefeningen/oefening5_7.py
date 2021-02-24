def boete_berekenen(aantal_boeken, aantal_dagen):
    boete = 0.07 * aantal_dagen * aantal_boeken
    return round(boete, 2)

def main():
    aanmaningsbrieven = 0
    prijs_aanmaningsbrief = 0.84
    naam = input("Naam: ")
    while not(naam == "xx"):
        aantal_boeken = int(input("Aantal gehuurde boeken: "))
        aantal_dagen = int(input("Aantal dagen over datum: "))

        if aantal_dagen >= 45:
            aanmaningsbrieven += 1
            totaal = boete_berekenen(aantal_boeken, aantal_dagen) + prijs_aanmaningsbrief
        else:
            totaal = boete_berekenen(aantal_dagen, aantal_boeken)

        print("Boete bedraagt: ", totaal)
        naam = input("Naam: ")

    print("Aantal aanmaningsbrieven verstuurd: ", aanmaningsbrieven)

if __name__ == '__main__':
    main()