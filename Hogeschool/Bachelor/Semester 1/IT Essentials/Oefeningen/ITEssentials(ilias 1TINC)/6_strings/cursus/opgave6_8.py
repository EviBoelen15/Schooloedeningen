def main():
    spreuk = "abracadabra"
    teller = 0
    nieuwe_spreuk = spreuk.replace("a", "o")
    print(nieuwe_spreuk)
    for letter in nieuwe_spreuk:
        if letter == "o":
            teller += 1

    print("Aantal o's:", teller)

if __name__ == '__main__':
    main()