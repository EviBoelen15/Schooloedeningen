from random import randint

# def genereer_huiswerk():
#     for i in range(1, 6):
#         print("Reeks " + str(i))
#         for j in range(1, 6):
#             getal_een = randint(0, 20)
#             getal_twee = randint(0, 20)
#             if getal_twee > getal_een:
#                 print(str(j) + ")" + str(getal_twee) + " - " + str(getal_een))
#             else:
#                 print(str(j) + ")" + str(getal_een) + " - " + str(getal_twee))
#         print()
#
#
# def main():
#     genereer_huiswerk()
#
# if __name__ == '__main__':
#     main()

###################################Tweede Versie###################################

def genereer_huistaak():
    for i in range(1, 6):
        print("Reeks", i)
        for j in range(1, 6):
            groot_getal = randint(0, 20)
            klein_getal = randint(0, groot_getal) #genereert een getal tussen 0 en het vorig getal
            print(str(j) + ")" + str(groot_getal) + " - " + str(klein_getal) + " = ")

def main():
    genereer_huistaak()

if __name__ == '__main__':
    main()
