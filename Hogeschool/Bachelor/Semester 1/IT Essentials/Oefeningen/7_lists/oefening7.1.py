def main():
    def bereken_gemiddelde(list):
        index = 0
        som = 0
        while index < len(list):
            print(index)
            som += list[index]
            index += 1
        gemiddelde = som / index

        kleinerdan = 0
        for number in list:
            if number < gemiddelde:
                kleinerdan += 1
        print("Gemiddelde: ", gemiddelde)
        print("Aantal getallen kleiner dan het gemiddelde: ", kleinerdan)

    bereken_gemiddelde(list(range(0, 20)))

if __name__ == '__main__':
    main()