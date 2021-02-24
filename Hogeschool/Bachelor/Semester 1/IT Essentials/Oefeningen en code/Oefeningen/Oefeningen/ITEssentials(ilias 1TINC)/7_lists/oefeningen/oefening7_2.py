from random import randint
def som_getallen_groter_dan(mijn_lijst, minimum):
    resultaat = 0
    for i in mijn_lijst:
        if i > minimum:
            resultaat += i

    return resultaat

def main():
    getallen_lijst = []
    totaal = 0
    # som = 0

    for i in range(500):
        getallen_lijst.append(randint(0, 10000))
        if getallen_lijst[i] > 5000:
            totaal += 1

    if totaal < (len(getallen_lijst) / 2):
        # for i in getallen_lijst:
        #     if i > 5000:
        #         som += i
        groter_dan = som_getallen_groter_dan(getallen_lijst, 5000)
        output = "minder dan 250 getallen zijn groter dan 5000, totale som van getallen groter dan 5000: {}".format(groter_dan)
    else:
        # for i in getallen_lijst:
        #     if i > 8000:
        #         som += i
        groter_dan = som_getallen_groter_dan(getallen_lijst, 8000)
        output = "Meer dan 250 getallen zijn groter dan 5000, totale som van getallen groter dan 8000: {}".format(groter_dan)

    print(output)


if __name__ == '__main__':
    main()