def main():
    nummer_getal = []
    som = 0
    aantal_kleiner = 0
    for i in range(1, 11):
        getal = int(input("Geef getal " + str(i) + " in: "))
        nummer_getal.append(getal)
        som += getal

    gemiddelde = som / 10

    for getal in nummer_getal:
        if getal < gemiddelde:
            aantal_kleiner += 1

    print("Som van alle getallen", som)
    print("Gemiddelde van alle getallen", gemiddelde)

if __name__ == '__main__':
    main()