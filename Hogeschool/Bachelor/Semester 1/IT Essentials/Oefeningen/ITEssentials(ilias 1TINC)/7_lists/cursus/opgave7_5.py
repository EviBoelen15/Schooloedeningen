def lijst_tel(mijn_lijst, element):
    aantal = mijn_lijst.count(element)
    print(element, "komt", aantal, "keer voor")
    for i in range(len(mijn_lijst)):
        print(mijn_lijst[i], end=" ")

def main():
    mijn_lijst = [2, 8, 4, 2, 6]

    lijst_tel(mijn_lijst, 2)

if __name__ == '__main__':
    main()