from random import randint


def zetOmNaarRomeinsCijfer(lijstroman, lijstwaarde, nummer):
    uitvoer = ""
    omzetten = nummer
    for i in range(len(lijstroman)):
        #print("Reeks: ", (i + 1))
        aantal = omzetten // lijstwaarde[i]
        uitvoer += aantal * lijstroman[i]
        omzetten %= lijstwaarde[i]
    print("De romeinse cijfers van getal ", nummer, "zijn", uitvoer)


def main():
    lijst_romeinsecijfers = ["XL", "X", "IX", "V", "IV", "I"]
    lijst_waardescijfers = [40, 10, 9, 5, 4, 1]

    invoer = input("Geef een letter in: ")

    for i in range(ord(invoer) - 96):
        print("Reeks: ", chr(i + 97))
        randomgetal = randint(1, 50)
        vorig_getal = 0
        while randomgetal > vorig_getal:
            zetOmNaarRomeinsCijfer(lijst_romeinsecijfers, lijst_waardescijfers, randomgetal)
            vorig_getal = randomgetal
            randomgetal = randint(1, 50)


if __name__ == '__main__':
    main()