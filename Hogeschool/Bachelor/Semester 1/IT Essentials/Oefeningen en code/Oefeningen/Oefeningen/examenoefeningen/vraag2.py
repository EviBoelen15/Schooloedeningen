from random import randint


def print_lijst(lijst):
    i = 0
    for i in range(len(lijst)):
        print(lijst[i], end=" ")
        i += 1
    print()


def vul_en_print_randomlist(lijst, deler, aantalgetallen):
    i = 0
    for i in range(aantalgetallen):
        randomgetal = randint(1, 100 // deler + 1) * deler
        lijst.append(randomgetal)
        i += 1
    print_lijst(lijst)
    #lijst = [(randint(0, 10) * deler) for i in range(aantalgetallen)]


def lager_dan_gemiddelde(lijst, aantalgetallen):
    lijst_lagerdan = []
    som = 0
    i = 0
    j = 0
    for i in range(aantalgetallen):
        som += int(lijst[i])
        i += 1
    gemiddelde = som / aantalgetallen

    for j in range(aantalgetallen):
        if lijst[j] < gemiddelde:
            lijst_lagerdan.append(lijst[j])
        j += 1
    return lijst_lagerdan


def print_omgekeerd(lijst):
    lijst.reverse()
    print_lijst(lijst)


def main():
    lijst_getallen = []

    aantalGetallen = int(input("Geef het aantal getallen dat random berekend zal worden: "))
    while aantalGetallen < 1:
        print("Dit is geen geldige invoer, probeer opnieuw")
        aantalGetallen = int(input("Geef het aantal getallen dat random berekend zal worden: "))

    veelvoud = int(input("Geef het veelvoud: "))
    while not veelvoud <= 10:
        print("Dit is geen geldige invoer, probeer opnieuw")
        veelvoud = int(input("Geef het veelvoud: "))

    print("De gegenereede getallen zijn: ")
    vul_en_print_randomlist(lijst_getallen, veelvoud, aantalGetallen)
    if aantalGetallen % 2 != 0:
        print("De array in speciale afdruk: ")
        print_omgekeerd(lijst_getallen)
    lijst_gemiddelde = lager_dan_gemiddelde(lijst_getallen, aantalGetallen)
    print("Getallen kleiner dan het gemiddelde: ")
    print_lijst(lijst_gemiddelde)


if __name__ == '__main__':
    main()