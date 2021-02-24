def voorwaarde_temperatuur(listTemperatuur):
    som_temperatuur = 0
    i = 1
    j = 0

    #Gemiddelde van temperatuur berekenen
    for i in range(len(listTemperatuur)):
        som_temperatuur += int(listTemperatuur[i])
        #i += 1
    gemiddelde = som_temperatuur / i

    #Laagste temperatuur berekenen
    laagstegetal = 0
    for j in range(len(listTemperatuur)):
        if laagstegetal > int(listTemperatuur[j]):
            laagstegetal = int(listTemperatuur[j])
            #j += 1
    #voldoet het laagste getal aan de voorwaarden?
    if laagstegetal > 15 and (laagstegetal > (gemiddelde * 0.20)):
        return True
    else:
        return False


def voorwaarde_neerslag(listNeerslag):
    i = 0

    for i in range(len(listNeerslag)):
        if listNeerslag[i] == "veel" or listNeerslag[i] == "overvloed":
            return False
        else:
            return True
        #i += 1


def voeg_toe(list, variabele):
    list.append(variabele)


def print_listen(listNeerslag, listTemperatuur):
    i = 0

    print("{:8s} {:15s} {}".format("Dag", "neerslag", "temperatuur"))
    for j in range(len(listNeerslag)):
        #print((i + 1), listNeerslag[j], listTemperatuur[j])
        print("{:>3} {:>13s} {:>17s}".format((j + 1), listNeerslag[j], listTemperatuur[j]))
        #j += 1


def main():
    list_temperatuur = []
    list_neerslag = []
    i = 0

    neerslag = input("Neerslag: ")

    while neerslag != "overvloed" and i < 7:
        temperatuur = input("Temperatuur: ")
        voeg_toe(list_neerslag, neerslag)
        voeg_toe(list_temperatuur, temperatuur)
        i += 1
        neerslag = input("Neerslag: ")

    #print(list_neerslag)
    #print(list_temperatuur)
    print_listen(list_neerslag, list_temperatuur)
    if voorwaarde_temperatuur(list_temperatuur) and voorwaarde_neerslag(list_neerslag):
        print("We gaan op uitstap")
    else:
        print("We gaan niet op uitstap")


if __name__ == '__main__':
    main()