def main():
    positieve_getallen = []
    negatieve_getallen = []
    for i in range(1, 11):
        getal = int(input("Geef een getal in " + str(i) + ": "))
        if getal >= 0:
            positieve_getallen.append(getal)
        else:
            negatieve_getallen.append(getal)

    kleinste = negatieve_getallen[0]
    for getal in negatieve_getallen:
        if getal < kleinste:
            kleinste = getal

    print("\nLengte van lijst met positieve getallen:", len(positieve_getallen))
    print("Lengte van lijst met negatieve getallen:", len(negatieve_getallen))
    print("waarden van lijst positieve getallen:", positieve_getallen)
    print("waarden van lijst negatieve getallen:", negatieve_getallen)
    print("Kleinste getal in negatieve getallen is:", kleinste)

if __name__ == '__main__':
    main()