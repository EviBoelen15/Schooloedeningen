def bereken_belasting(getal):
    if getal <= 25000:
        belasting = getal * 0.384
    else:
        belasting = 25000 * 0.384
        if getal <= 55000:
            belasting += (getal - 25000) * 0.5
        else:
            belasting += 30000 * 0.5 + (getal - 55000) * 0.6
    return belasting

def main():
    getal = int(input("Geef getal op: "))
    print("De belasting bedraagt: ", bereken_belasting(getal))

if __name__ == '__main__':
    main()