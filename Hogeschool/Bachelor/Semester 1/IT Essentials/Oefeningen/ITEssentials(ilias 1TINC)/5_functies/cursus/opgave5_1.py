# Parameters mogen zelfde naam hebben als argumenten
def print_lijn(aantal_tekens, teken):
    for i in range(1, aantal_tekens + 1):
        print(teken, end=" ")

aantal_tekens = int(input("Aantal tekens: "))
teken = input("Teken: ")

print_lijn(aantal_tekens, teken)
