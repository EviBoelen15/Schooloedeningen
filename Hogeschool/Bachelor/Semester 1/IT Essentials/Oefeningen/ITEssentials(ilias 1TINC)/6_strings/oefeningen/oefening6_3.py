def main():
    aantal_karakters = int(input("Hoeveel karakters wil je ingegeven? "))
    teller = 0
    som = 0

    while teller != aantal_karakters:
        karakter = input("Geef een karakter in: ")
        if karakter >= 'a' and karakter <= 'z':
            print(karakter, "is een kleine letter")
        elif karakter >= 'A' and karakter <= 'Z':
            print(karakter, "is een hoofdletter")
        elif karakter >= '0' and karakter <= '9':
            som += int(karakter)
        else:
            print("Karakter onbekend")
        teller += 1
    print("som van alle opgegeven getallen:", som)
if __name__ == '__main__':
    main()