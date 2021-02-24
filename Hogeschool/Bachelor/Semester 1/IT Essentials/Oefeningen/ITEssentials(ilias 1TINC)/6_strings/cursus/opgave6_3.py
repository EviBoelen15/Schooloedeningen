def main():
    naam1 = "iliasss"
    naam2 = "ilias"
    min_lengte = len(naam1)

    if len(naam2) < min_lengte:
        min_lengte = len(naam2)

    for letter in range(min_lengte):
        if naam1[letter] == naam2[letter]:
            print(naam1[letter], letter)

if __name__ == '__main__':
    main()