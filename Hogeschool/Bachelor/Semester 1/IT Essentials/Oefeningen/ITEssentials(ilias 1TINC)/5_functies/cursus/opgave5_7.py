def toon_tafel(getal): # getal is een parameter
    for i in range(0, 11):
        print(i, "x", getal, "=", i * getal)

def main():
    getal = int(input("Geef het getal op: ")) # getal is hier een lokale variabele
    toon_tafel(getal) # getal is hier een argument

if __name__ == '__main__':
    main()