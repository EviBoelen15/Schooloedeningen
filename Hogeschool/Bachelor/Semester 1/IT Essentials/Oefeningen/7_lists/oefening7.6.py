import datetime
def main():
    lijst_sterrenbeelden = []
    def sterrenbeeld_bepalen(geboortedatum):
        if geboortedatum.month == 1 and geboortedatum.day > 21 or geboortedatum.month == 2 and geboortedatum.day <= 21:
            sterrenbeeld = "Waterman"
        elif geboortedatum.month == 2 and geboortedatum.day > 21 or geboortedatum.month == 3 and geboortedatum.day <= 21:
            sterrenbeeld = "vissen"
        elif geboortedatum.month == 3 and geboortedatum.day > 21 or geboortedatum.month == 4 and geboortedatum.day <= 21:
            sterrenbeeld = "ram"
        elif geboortedatum.month == 4 and geboortedatum.day > 21 or geboortedatum.month == 5 and geboortedatum.day <= 21:
            sterrenbeeld = "stier"
        elif geboortedatum.month == 5 and geboortedatum.day > 21 or geboortedatum.month == 6 and geboortedatum.day <= 21:
            sterrenbeeld = "tweelingen"
        elif geboortedatum.month == 6 and geboortedatum.day > 21 or geboortedatum.month == 7 and geboortedatum.day <= 21:
            sterrenbeeld = "kreeft"
        elif geboortedatum.month == 7 and geboortedatum.day > 21 or geboortedatum.month == 8 and geboortedatum.day <= 21:
            sterrenbeeld = "leeuw"
        elif geboortedatum.month == 8 and geboortedatum.day > 21 or geboortedatum.month == 9 and geboortedatum.day <= 21:
            sterrenbeeld = "maagd"
        elif geboortedatum.month == 9 and geboortedatum.day > 21 or geboortedatum.month == 10 and geboortedatum.day <= 21:
            sterrenbeeld = "weegschaal"
        elif geboortedatum.month == 10 and geboortedatum.day > 21 or geboortedatum.month == 11 and geboortedatum.day <= 21:
            sterrenbeeld = "schorpioen"
        elif geboortedatum.month == 11 and geboortedatum.day > 21 or geboortedatum.month == 12 and geboortedatum.day <= 21:
            sterrenbeeld = "boogschutter"
        elif geboortedatum.month == 12 and geboortedatum.day > 21 or geboortedatum.month == 1 and geboortedatum.day <= 21:
            sterrenbeeld = "steenbok"
        return sterrenbeeld

    def toevoegen_aan_list(pnaam, pvoornaam, pgeboortedatum, lijst):
        gegevens = (pnaam, pvoornaam, pgeboortedatum)
        lijst.append(gegevens)


    naam = input("Naam: ")

    while naam != "/":
        voornaam = input("Voornaam: ")
        date_entry = input('Enter a date in YYYY-MM-DD format')
        year, month, day = map(int, date_entry.split('-'))
        geboortedatum = datetime.date(year, month, day)
        toevoegen_aan_list(naam, voornaam, geboortedatum, lijst_sterrenbeelden)
        print(sterrenbeeld_bepalen(geboortedatum))

        naam = input("Naam: ")

    print(lijst_sterrenbeelden)


if __name__ == '__main__':
    main()