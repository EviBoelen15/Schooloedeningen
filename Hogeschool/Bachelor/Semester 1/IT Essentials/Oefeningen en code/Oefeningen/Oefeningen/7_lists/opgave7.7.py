def main():
    def delete_double(list):
        for element in list:
            if list.count(element) > 1:
                list.remove(element)
            else:
                print(element)

    numberlist = ["1", "1", "1", "1", "2", "5", "6", "8", "5", "5", "6", "8", "8", "7", "5"]
    delete_double(numberlist)


if __name__ == '__main__':
    main()