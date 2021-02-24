def main():
    getal = int(input("Geef een getal in: "))

    lijst = []
    while getal != 0:
        if getal in lijst:
            index = lijst.index(getal)
            print("Getal op plaats", index, "is reeds aanwezig")
            lijst.remove(getal)
        else:
            lijst.append(getal)
        getal = int(input("Geef een getal in (0 om te stoppen): "))

    print(lijst)

if __name__ == '__main__':
    main()