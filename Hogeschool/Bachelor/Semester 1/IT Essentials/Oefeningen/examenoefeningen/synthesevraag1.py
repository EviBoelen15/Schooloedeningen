def producten_bijbestellen(lijstartikels, lijstvoorraad):
    print('\n' + "Lijst van bij te bestellen producten")
    for i in range(len(lijstartikels)):
        in_voorraad = lijstartikels[i].split("-")
        voorraad = int(in_voorraad[len(in_voorraad) - 1])
        bestelhoeveelheid = int(in_voorraad[2])
        if voorraad > lijstvoorraad[i] and in_voorraad[0] == "S":
            te_bestellen = voorraad - lijstvoorraad[i]
            if te_bestellen % bestelhoeveelheid != 0:
                te_bestellen += (bestelhoeveelheid - (te_bestellen % bestelhoeveelheid))
            print("Product", lijstartikels[i], "te bestellen: ", te_bestellen, "stuks.")


def lijst_actieartikelen(lijstartikels, lijstvoorraad):
    print('\n' + "Lijst van actie artikkelen")
    for i in range(len(lijstartikels)):
        gesplitst_type = lijstartikels[i].split("-")
        type = gesplitst_type[0]
        if type == "A":
            nieuw_artikelnummer = gesplitst_type[0] + "-" + gesplitst_type[1] + "-" + str(lijstvoorraad[i])
            lijstartikels[i] = nieuw_artikelnummer
            if lijstvoorraad[i] > 0:
                print(lijstartikels[i])


def voeg_voorraad_toe(lijst, aantal):
    lijst.append(aantal)


def main():
    voorraad = 0
    lijst_artikelen = ["S-kaftE34-5-100", "S-DVD345-1-124", "A-penD34-125", "S-boekX33-3-256", "A-bal34-145",
                       "S-boekZ34-2-26", "A-ballon34-15"]
    lijst_voorraad = []
    i = 0
    for i in range(len(lijst_artikelen)):
        voorraad_artikel = lijst_artikelen[i]
        voorraad = int(input('Geef het aantal artikels in voorraad van het artikel ' + voorraad_artikel + ': '))

        gesplitst_artikel = lijst_artikelen[i].split("-")
        while voorraad_artikel[0:1] == "A" and voorraad > int(gesplitst_artikel[len(gesplitst_artikel) - 1]):
            print("Foute ingave! Zo veel artikels kunnen niet in voorraad zijn! ")
            voorraad = int(input('Geef het aantal artikels in voorraad van het artikel' + voorraad_artikel + ': '))
        voeg_voorraad_toe(lijst_voorraad, voorraad)

    producten_bijbestellen(lijst_artikelen, lijst_voorraad)
    lijst_actieartikelen(lijst_artikelen, lijst_voorraad)


if __name__ == '__main__':
    main()