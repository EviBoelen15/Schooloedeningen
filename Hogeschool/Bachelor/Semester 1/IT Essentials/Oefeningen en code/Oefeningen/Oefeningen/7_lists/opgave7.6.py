def main():
    def tel_voorkomens(list, string):
        print(list.count(string))

    listnaam = ['1', '1', '1', '1', '2', '5', '6', '8', '5', '5', '6', '8', '8', '7', '5']
    tel_voorkomens(listnaam, '1')


if __name__ == '__main__':
    main()
