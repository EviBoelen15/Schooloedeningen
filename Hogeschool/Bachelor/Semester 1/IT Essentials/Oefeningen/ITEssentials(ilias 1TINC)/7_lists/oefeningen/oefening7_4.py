def main():
    # alfabet_lijst = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
    #                  "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"]
    #
    # string = input("Geef iets in: ").lower()
    #
    # for letter in alfabet_lijst:
    #     if letter in string:
    #         print(str(letter) + ": " + str(string.count(letter)))

    # alfabet_lijst = []

    # for i in range(ord('a'), ord('z') + 1):
    #     alfabet_lijst.append(chr(i))

    gebruiker_input = input("Geef iets in: ")

    for i in range(ord('a'), ord('z') + 1):
        letter = chr(i)
        if letter in gebruiker_input:
            print(letter + ": " + str(gebruiker_input.count(letter)))

if __name__ == '__main__':
    main()