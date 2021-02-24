def bereken_percentage(getal, totaal):
    te_berekenen = totaal / 100
    return getal / te_berekenen

def main():
    aantal_stemmen = 0
    stemmen_lijst = [0, 0, 0, 0] # frequentietabel
    kandidaten_lijst = ["An Janssen", "Bart Vriends", "Andries Michels", "Inge Kaas"]
    # totaal_stemmen = sum(stemmen_lijst)
    stem = int(input("Stem op jouw kandidaat(1 - 4): "))

    while stem != 0:
        aantal_stemmen += 1
        stemmen_lijst[stem - 1] += 1
        stem = int(input("Stem op jouw kandidaat(1 - 4): "))

    for i in range(len(stemmen_lijst)):
        print("Kandidaat", kandidaten_lijst[i], "heeft", stemmen_lijst[i])
        print("totaal aantal stemmen", aantal_stemmen, "goed voor een percentage van", round(bereken_percentage(stemmen_lijst[i], aantal_stemmen), 1))

if __name__ == '__main__':
    main()