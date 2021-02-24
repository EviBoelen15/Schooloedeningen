import random

def main():
    list_elementen = [random.randint(0, 10001) for i in range(500)]
    totaalelement = 0
    groterdan = 0
    resultaat = 0

    for number in list_elementen:
        if number > 5000:
            groterdan += 1
            totaalelement += 1
        else:
            totaalelement += 1
        if groterdan < 250:
            if number > 5000:
                resultaat += number
        else:
            if number > 8000:
                resultaat += number

    print("Aantal getallen groter dan 5000: ", groterdan)
    print(resultaat)


if __name__ == '__main__':
    main()