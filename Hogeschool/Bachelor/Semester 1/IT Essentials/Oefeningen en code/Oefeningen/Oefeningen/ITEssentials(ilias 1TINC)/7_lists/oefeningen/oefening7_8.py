# def bereken_laagste_score()
def main():
    lijst = []
    for i in range(1, 6):
        behaalde_cijfer = input("Behaalde cijfer voor de 4 vakken per student: ")
        lijst.append(behaalde_cijfer.split(' '))
    print(lijst)
if __name__ == '__main__':
    main()