def main():
    tekst = "de quick fox jumps over de lazy cat"
    nieuwe_tekst = tekst.replace("d", "th").replace("cat", "dog")
    print(tekst)
    print(nieuwe_tekst)

if __name__ == '__main__':
    main()  