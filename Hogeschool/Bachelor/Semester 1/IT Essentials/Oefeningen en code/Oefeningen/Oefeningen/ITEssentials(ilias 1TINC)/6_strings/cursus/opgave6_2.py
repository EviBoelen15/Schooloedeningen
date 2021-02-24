def main():
    tekst = "ilias"
    for letter in range(len(tekst)):
        if tekst[letter] in "aeiou":
            print(letter, end=" ")

if __name__ == '__main__':
    main()