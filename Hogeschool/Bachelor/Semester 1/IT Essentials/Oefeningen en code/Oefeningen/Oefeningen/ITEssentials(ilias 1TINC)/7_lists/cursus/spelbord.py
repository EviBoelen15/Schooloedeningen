def toon_bord(spelbord):
    print("  1 2 3")
    for rij in range(3):
        print(rij + 1, end=" ")
        for kol in range(3):
            print(spelbord[rij][kol], end=" ")
        print()

def main():
    bord = [["-", "-", "-"], ["-", "-", "-"], ["-", "-", "-"]]
    bord[1][1] = "X"
    bord[0][2] = "O"
    toon_bord(bord)

if __name__ == '__main__':
    main()
