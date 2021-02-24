from random import randint, random

def main():
    willekeurig_getal = randint(0, 10)

    print(willekeurig_getal)

    print("*****************************************")

    for i in range(1, 11):
        gehele_getallen = randint(1, 9)
        print(str(i) + ". " + str(gehele_getallen))

    print("*****************************************")

    veelvoud_getal = randint(-20, 100) * 10

    print(veelvoud_getal)

    print("*****************************************")

    reeel_getal = randint(0, 999)

    print(reeel_getal / 10)

if __name__ == '__main__':
    main()