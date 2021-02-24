def main():
    woord = input("Geef een woord: ")

    if len(woord) % 2 == 0:
        print(woord[:len(woord) // 2 - 1] + woord[len(woord) // 2 - 1].upper() + woord[len(woord) // 2].upper() + woord[len(woord) // 2 + 1:])
    else:
        print(woord[:len(woord) // 2] + woord[len(woord) // 2].upper() + woord[len(woord) // 2 + 1:])
if __name__ == '__main__':
    main()