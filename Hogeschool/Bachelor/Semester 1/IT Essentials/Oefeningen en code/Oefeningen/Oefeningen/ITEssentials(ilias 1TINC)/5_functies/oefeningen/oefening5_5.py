# def inkom_check(lidnummer):
#     twee_eerste_cijfers = str((lidnummer // 100000) % 10) + str((lidnummer // 1000) % 10)
#     twee_laatste_cijfers = str((lidnummer // 10) % 10) + str((lidnummer // 1) % 10)
#
#     if twee_eerste_cijfers == twee_laatste_cijfers:
#         print("Gratis")
#     else:
#         print("Niet gratis")
#     print(str(twee_eerste_cijfers), str(twee_laatste_cijfers))
#
# def main():
#     lidnummer = int(input("Geef uw 7-cijferige lidnummer op: "))
#     inkom_check(lidnummer)
#
# if __name__ == '__main__':
#     main()


###################Tweede Versie############################

def bereken_waarde(nummer, waarde):
    return int(nummer / waarde) % 10

def check_inkom(lidnummer):
    tweede_getal = bereken_waarde(lidnummer, 100000)
    vierde_getal = bereken_waarde(lidnummer, 1000)
    zesde_getal = bereken_waarde(lidnummer, 10)
    zevende_getal = bereken_waarde(lidnummer, 1)

    if tweede_getal == zesde_getal and vierde_getal == zevende_getal:
        print("Gratis inkom")
    else:
        print("Inkom niet gratis")

def main():
    lidnummer = int(input("Lidnummer: "))
    check_inkom(lidnummer)

if __name__ == '__main__':
    main()