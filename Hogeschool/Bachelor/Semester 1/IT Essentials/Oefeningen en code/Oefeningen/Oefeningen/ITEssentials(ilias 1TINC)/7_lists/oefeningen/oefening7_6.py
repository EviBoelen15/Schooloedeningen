def bepaal_sterrenbeeld(geboortedatum, ster_lijst):
    maand = int(geboortedatum[3: 5])
    dag = int(geboortedatum[0: 2])
    if dag < 21:
        sterrenbeeld = ster_lijst[maand - 2]
    else:
        sterrenbeeld = ster_lijst[maand - 1]

    return sterrenbeeld

def bereken_naam_persoon(voornaam, naam):
    naam_persoon = voornaam[0] + ". " + naam
    return naam_persoon.upper()

def main():
    sterrenbeeld_lijst = ["waterman", "vissen", "ram", "stier", "tweelingen", "kreeft", "leeuw", "maagd",
                     "weegschaal", "schorpioen", "boogschutter", "steenbok"]

    naam = input("Naam: ")

    while naam != "/":
        voornaam = input("Voornaam: ")
        geboortedatum = input("Geboortedatum: ")

        print(bereken_naam_persoon(voornaam, naam), bepaal_sterrenbeeld(geboortedatum, sterrenbeeld_lijst))


        naam = input("Naam: ")



if __name__ == '__main__':
    main()