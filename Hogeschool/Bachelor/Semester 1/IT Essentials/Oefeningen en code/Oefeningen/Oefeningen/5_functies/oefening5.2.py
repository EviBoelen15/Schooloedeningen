def schrikkeljaar(jaar):
    if (jaar % 4 == 0 and jaar % 100 != 0) or jaar % 400 == 0:
        return True
    else:
        return False

def main():
    jaartal = int(input("Geef een jaartal in: "))
    if schrikkeljaar(jaartal):
        print("Het jaar", jaartal, "is een schrikkeljaar")
    else:
        print("Het jaar", jaartal, "is geen schrikkeljaar")


if __name__ == '__main__':
    main()