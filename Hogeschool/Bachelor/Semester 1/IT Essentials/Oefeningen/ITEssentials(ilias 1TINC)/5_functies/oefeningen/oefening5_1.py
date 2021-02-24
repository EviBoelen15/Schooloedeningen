def omzetten_dollar_euro(dollar):
    return round(dollar * 1.21, 2)

def main():
    euro = float(input("Geef aantal euro om om te rekenen: "))
    while euro != 0:
        print("$" + str(omzetten_dollar_euro(euro)))
        euro = float(input("Geef aantal euro om om te rekenen: "))

if __name__ == '__main__':
    main()