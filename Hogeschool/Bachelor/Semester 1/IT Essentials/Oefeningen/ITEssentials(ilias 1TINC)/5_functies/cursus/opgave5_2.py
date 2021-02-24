def print_rechthoek(aantal_rijen, aantal_kolommen, teken):
    for i in range(1, aantal_rijen + 1):
        for j in range(1, aantal_kolommen + 1):
            print(teken, end=" ")
        print()


def print_lijn(aantal_tekens, teken):
    for i in range(1, aantal_tekens + 1):
        print(teken, end=" ")
    print()

def print_vierkant(aantal_rijen, aantal_kolommen, teken):
    for i in range(1, aantal_rijen + 1):
        print_lijn(aantal_kolommen, teken)

aantal_rijen = int(input("Geef het aantal rijen in: "))
aantal_kolommen = int(input("Geef het aantal kolommen in: "))
teken = input("Geef het karakter in: ")

print_rechthoek(aantal_rijen, aantal_kolommen, teken)

print("***************************************************")

print_vierkant(aantal_rijen, aantal_kolommen, teken)
