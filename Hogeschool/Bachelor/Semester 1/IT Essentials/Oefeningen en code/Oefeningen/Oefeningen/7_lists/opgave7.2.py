def main():
    list_getallen = [5, 6, 15, 68, 2, 65, 25, 4, 1, 3, 6, 8, 9]
    startgetal = 100
    for number in list_getallen:
        if number < startgetal:
            startgetal = number
    print(startgetal)


if __name__ == '__main__':
    main()