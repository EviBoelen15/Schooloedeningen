def main():
    nummer_lijst = [5, 7, 25, 3, 6]
    grootste = nummer_lijst[0]
    kleinste = nummer_lijst[0]
    som = 0
    for i in nummer_lijst:
        if i > grootste:
            grootste = i
        elif i < kleinste:
            kleinste = i
        som += i

    print("Grootste getal:", grootste)
    print("Kleinste getal:", kleinste)
    print("Som van alle getallen:", som)

if __name__ == '__main__':
    main()