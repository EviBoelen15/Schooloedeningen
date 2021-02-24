from random import randint


def zetOmNaarRomeinseCijfers(lijstromeins, lijstwaardes, getal):
    uitvoer = ""
    nieuwgetal = getal
    for i in range(len(lijstromeins)):
        aantal_maal = nieuwgetal // lijstwaardes[i]
        uitvoer += aantal_maal * lijstromeins[i]
        nieuwgetal %= lijstwaardes[i]
    print("Het romeinse cijfer voor", getal, "is", uitvoer)


def main():
    lijst_romeinsecijfers = ["XL", "X", "IX", "V", "IV", "I"]
    lijst_waardescijfers = [40, 10, 9, 5, 4, 1]

    invoer = input("Geef letter: ")

    for i in range(ord(invoer) - 96):
        print("Reeks: ", chr(i + 97))
        randomgetal = randint(1, 50)
        vorig_getal = 0
        while randomgetal > vorig_getal:
            zetOmNaarRomeinseCijfers(lijst_romeinsecijfers, lijst_romeinsecijfers, randomgetal)
            vorig_getal = randomgetal
            randomgetal = randint(1, 50)


if __name__ == '__main__':
    main()