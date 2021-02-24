def main():
    tekst = input("Geef hier uw tekst: ")
    plaatsT = tekst.find('t')
    uitvoer = ""
    for letter in tekst:
        if letter == "T" or letter == "t":
            uitvoer = tekst[:plaatsT + 1] + tekst[plaatsT:].upper()

    print(uitvoer)
if __name__ == "__main__":
    main()