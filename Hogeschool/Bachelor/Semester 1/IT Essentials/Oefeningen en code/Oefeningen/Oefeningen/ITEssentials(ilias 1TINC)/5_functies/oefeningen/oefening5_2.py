def is_schrikkeljaar(jaartal):
    if (jaartal % 4 == 0 and jaartal % 100 != 0) or jaartal % 400 == 0:
        return True
    else:
        return False

def main():
    jaartal = int(input("Geef een jaartal op: "))
    # print(is_schrikkeljaar(jaartal))
    if is_schrikkeljaar(jaartal):
        print("Ja", jaartal, "is een schrikkeljaar")
    else:
        print("Nee", jaartal, "is GEEN schrikkeljaar")

if __name__ == '__main__':
    main()