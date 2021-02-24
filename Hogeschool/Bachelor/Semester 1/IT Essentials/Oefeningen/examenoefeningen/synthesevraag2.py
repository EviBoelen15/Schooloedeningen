from random import randint


def basisscore_berekenen(naam, aantal_bezoek, geboortejaar):
    basisscore = 0
    komt_voor = ""
    som = 0

    for i in range(len(naam)):
        if naam[i] in "cinema":
            #komt_voor += str(naam[i])
            som += (ord(naam[i]) * (i + 1))
    som += geboortejaar
    #som *= aantal_bezoek
    return som


def gewonnen_tickets(randomgetal):
    som_tickets = 0
    string_random = str(randomgetal)
    for letter in string_random:
        som_tickets += int(letter)
        randomgetall = int(string_random)
    return som_tickets


def is_slechteklant(snacks, aantal_bezoek):
    if snacks.lower() == "n" and (aantal_bezoek == "2" or aantal_bezoek == "1"):
        return True
    else:
        return False


def bezoek_korting(aantalbezoeken, score):
    if aantalbezoeken == 1:
        score /= 2
    elif aantalbezoeken == 2:
        score *= 2
    elif aantalbezoeken == 3:
        score *= 3
    return score

def main():
    naam = input("Naam: ")
    winnaar = ""
    score = 0
    random_getal = randint(0, 10000)
    som_gewonnengetal = 0
    bezoek_per_maand = 0

    while naam != "xxx" and naam != "qqq":
        geboortejaar = int(input("Geboortejaar: "))
        bezoek_per_maand = int(input("Hoevaak per maand bezoekt u de kinepolis? (1 = weinig, 2 = matig, 3 = veel): "))
        versnaperingen = input("Wat neemt u als versnapering? (p = popcorn, c = chips, n = niets): ")

        som = basisscore_berekenen(naam, bezoek_per_maand, geboortejaar)
        print(naam, ": ", som)

        if is_slechteklant(versnaperingen, bezoek_per_maand):
            som -= 1050
        if som > score:
            winnaar = naam
            score = som

        naam = input("Naam: ")

    while random_getal < 5000 and random_getal % 10 != 0:
        if random_getal % 2 != 0:
            random_getal = randint(0, 10000)

    if winnaar != "":
        print(winnaar, ": Jij hebt gewonnen!")
        print("Jouw score is: ", bezoek_korting(bezoek_per_maand, score))
        print("Het random gegenereerde getal is: ", random_getal)
        print(winnaar, ", Jij wint hierbij", gewonnen_tickets(random_getal), "filmtickets!.")


if __name__ == '__main__':
    main()