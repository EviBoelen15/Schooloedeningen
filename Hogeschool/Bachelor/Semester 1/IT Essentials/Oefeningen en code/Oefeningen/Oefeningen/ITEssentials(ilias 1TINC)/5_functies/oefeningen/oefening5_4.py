from random import randint

def raad_getal(getal, gok):
    if gok < getal:
        return "Hoger"
    elif gok > getal:
        return "Lager"
    else:
        return "Proficiat"

def main():
    getal = randint(1, 10)
    print(getal)
    teller = 0
    gevonden = False

    while teller < 4 and gevonden is not True:
        gok = int(input("Doe een gok: "))
        output = raad_getal(getal, gok)
        print(output)
        if output == "Proficiat":
            gevonden = True
        teller += 1

if __name__ == '__main__':
    main()
