def zet_getal_om(invoergebruiker, liststrings, listgetallen):
    uitvoer = ""
    for i in range(len(invoergebruiker)):
        for j in range(len(listgetallen)):
            if int(invoergebruiker[i]) == listgetallen[j]:
                uitvoer += liststrings[j] + " "
    return uitvoer

def main():
    lijst_strings = ["nul", "een", "twee", "drie", "vier", "vijf", "zes", "zeven", "acht", "negen"]
    lijst_waardes = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]

    invoer = input("Input: ")

    print(zet_getal_om(invoer, lijst_strings, lijst_waardes))


if __name__ == '__main__':
    main()