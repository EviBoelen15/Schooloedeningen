# def concateneer_string(eerste_string, tweede_string):
#     eerste_string = check_lengte(eerste_string, "*")
#     tweede_string = check_lengte(tweede_string, "+")
#
#     return eerste_string[:4].upper() + tweede_string[-4:].lower()
#
# def check_lengte(string, karakter):
#     if len(string) < 4:
#         toevoegen_karakter = 4 - len(string)
#         for i in range(toevoegen_karakter):
#             string += karakter
#     return string

def main():
    # string1 = input("Geef hier eerste string in: ")
    # string2 = input("Geef hier tweede string in: ")

    # nieuwe_string = concateneer_string(string1, string2)

    # print(nieuwe_string)

    tekst1 = "abcdzrf"
    tekst2 = "GHFGFHHT"

    while len(tekst1) < 4:
        tekst1 += "*"
    tekst1 = tekst1[0:4].upper()

    while len(tekst2) < 4:
        tekst2 = "+" + tekst2
    tekst2 = tekst2[len(tekst2) - 4:].lower()

    resultaat = tekst1 + tekst2

    print(resultaat)

if __name__ == '__main__':
    main()

