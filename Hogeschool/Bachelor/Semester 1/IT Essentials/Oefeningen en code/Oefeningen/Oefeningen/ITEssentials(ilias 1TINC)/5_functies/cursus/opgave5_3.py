def printx():
    print("x", end=" ")

def printmeerderex(aantal):
    for i in range(1, aantal + 1):
        printx()

aantal = int(input("Aantal keer: "))

printmeerderex(aantal)