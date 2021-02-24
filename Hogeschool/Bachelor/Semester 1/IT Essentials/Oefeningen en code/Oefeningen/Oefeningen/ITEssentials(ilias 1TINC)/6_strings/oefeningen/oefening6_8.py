def volgende_letter(letter):
    if letter == "Z":
        return "A"
    else:
        return chr(ord(letter) + 1)

def main():
    karakter = input("Geef hier een karakter op: ").upper()

    letter = karakter

    for i in range(7):
        print(letter, end=" ")
        letter = volgende_letter(letter)
        for j in range(i):
            print(letter, end=" ")
            letter = volgende_letter(letter)
        print()

if __name__ == '__main__':
    main()