def prioriteitsbepaling(gezinsinkomen, aantalkinderen, code):
    prioriteit = ""
    DIT_JAAR = 2019
    wel_of_niet = code[0]

    if wel_of_niet == "J":
        start_jaar = int(code[1:])
        if DIT_JAAR - start_jaar < 5:
            prioriteit = "*****"

    if gezinsinkomen < 2000 and aantalkinderen >= 3:
        prioriteit = "*"
    elif gezinsinkomen < 2000 and aantalkinderen < 3:
        prioriteit = "**"
    elif 2000 <= gezinsinkomen < 2500:
        prioriteit = "***"
    elif gezinsinkomen >= 2500:
        prioriteit = "****"

    return prioriteit


def goedkopere_bouwlening(aantalkinderen, gezinsinkomen, naamMan, naamVrouw):
    if aantalkinderen >= 1 or gezinsinkomen <= 1500:
        return True

def is_weduw(naamMan, naamVrouw):
    if naamMan == "xx":
        return
    elif naamVrouw == "xx":
        return True

def print_lijst(naamMan, naamVrouw, prioriteit, bouwlening, aantalklant, uitvoer):
    splitnaamMan = naamMan.split()
    splitnaamVrouw = naamVrouw.split()
    print("{:3s} {:3s} {} {}").format("nr", "familienaam", "prioriteit", "bouwlening")
    for i in range(aantalklant):
        if is_weduw(naamMan, naamVrouw):
            print("{:3i} {:3s} {} {}").format((aantalklant + ", "), uitvoer, prioriteit, bouwlening)




def main():
    aantalklanten = 0
    code = input("Code (J voor sociale woning + sinds welk jaar en N voor niet isociale woning: ")

    while code.lower() != "s":
        naam_man = input("Achternaam en voornam man: (indien weduw geef xxx in) ")
        naam_vrouw = input("Achternaam en voornaam vrouw: (indien weduw geef xxx in) ")
        inkomen_man = float(input("Inkomen man: (indien weduw geef 0 in) "))
        inkomen_vrouw = float(input("Inkomen vrouw: (indien weduw geef 0 in) "))
        aantal_kinderen = int(input("Aantal kinderen: "))

        gezins_inkomen = inkomen_man + inkomen_vrouw
        prioriteit = prioriteitsbepaling(gezins_inkomen, aantal_kinderen, code)
        aantalklanten += 1




if __name__ == '__main__':
    main()