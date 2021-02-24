def vervang_tekens(string, nieuwe_string):
    # for i in range(len(string)):
    #     if string[i] < chr(97) and string[i] > chr(122):
    #         nieuwe_string = string.replace(string[i], " ")
    # return nieuwe_string
    for letter in string:
        if letter < 'a' or letter > 'z':
            nieuwe_string = string.replace(letter, " ")
    return nieuwe_string

def main():
    string = "ph@t l00t"
    nieuwe_string = ""

    print(vervang_tekens(string, nieuwe_string))

if __name__ == '__main__':
    main()