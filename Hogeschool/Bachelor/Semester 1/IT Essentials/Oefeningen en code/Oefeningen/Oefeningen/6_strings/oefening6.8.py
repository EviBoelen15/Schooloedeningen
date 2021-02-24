def volgende_letter(letter):
    if letter == "Z":
        return "A"
    else:
        return chr(ord(letter) + 1)

def main():
    karakter = input("Met welke letter wil je beginnen? ").upper()



    for i in range(5):
        print(karakter, end=" ")
        karakter = volgende_letter(karakter)
        for j in range(i):
            print(karakter, end=" ")
            karakter = volgende_letter(karakter)
        print()

if __name__ == '__main__':
    main()