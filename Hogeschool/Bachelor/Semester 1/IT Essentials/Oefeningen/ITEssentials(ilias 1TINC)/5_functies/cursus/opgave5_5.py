def is_even(getal):
    return getal % 2 == 0

def is_oneven(getal):
    return not is_even(getal)

getal = int(input("Getal: "))
print(is_oneven(getal))