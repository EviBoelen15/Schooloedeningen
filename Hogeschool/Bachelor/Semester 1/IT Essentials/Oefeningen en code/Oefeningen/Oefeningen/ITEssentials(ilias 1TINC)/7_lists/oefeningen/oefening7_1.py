def main():
    getallen_lijst = []
    som = 0
    aantal_kleine_getallen = 0
    for i in range(1, 16):
        getal = int(input("Geef getal " + str(i) + " in: "))
        getallen_lijst.append(getal)
        som += getal

    gemiddelde = som / 15

    for getal in getallen_lijst:
        if getal < gemiddelde:
            aantal_kleine_getallen += 1

    percentage_kleine_getallen = (gemiddelde / 100) * 15
    print("Som van alle getallen:", som)
    print("Het gemiddelde van 15 getallen:", round(gemiddelde, 1))
    print("Aantal kleiner dan het gemiddelde:", aantal_kleine_getallen, "dit is", str(percentage_kleine_getallen) + "% van al de getallen")

if __name__ == '__main__':
    main()