def main():
    tekstvar1 = input("Tekst 1: ")
    tekstvar2 = input("Tekst 2: ")

    while len(tekstvar1) < 4:
        tekstvar1 += "*"
    tekstvar1 = tekstvar1[0:4].upper()

    while len(tekstvar2) < 4:
        tekstvar2 = "+" + tekstvar2
    tekstvar2 = tekstvar2[len(tekstvar2) - 4:].lower()

    nieuwtekst = tekstvar1 + tekstvar2
    print(nieuwtekst)


if __name__ == '__main__':
    main()
