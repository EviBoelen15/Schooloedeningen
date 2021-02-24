def main():
    voornaam = "ilias"
    achternaam = "agnaou"
    volledige_naam = ""

    volledige_naam += voornaam[0].upper() + ". " + achternaam[0].upper() + achternaam[1:].lower()
    print(volledige_naam)


if __name__ == '__main__':
    main()