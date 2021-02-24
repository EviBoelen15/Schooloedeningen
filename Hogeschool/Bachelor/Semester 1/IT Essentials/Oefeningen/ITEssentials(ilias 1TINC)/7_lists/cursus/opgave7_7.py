def get_number_of_participants(tabel_list):
    return len(tabel_list[0])


def get_number_of_tests(tabel_list):
    return len(tabel_list)


def highest_heart_rate(tabel_list):
    highest = tabel_list[0][0]
    for i in range(len(tabel_list)):
        for j in range(len(tabel_list[i])):
            if tabel_list[i][j] > highest:
                highest = tabel_list[i][j]

    return highest


def lowest_heart_rate(tabel_list):
    lowest = tabel_list[0][0]
    for i in range(len(tabel_list)):
        for j in range(len(tabel_list[i])):
            if tabel_list[i][j] < lowest:
                lowest = tabel_list[i][j]

    return lowest


def average_heart_rate(tabel_list):
    average_list = []
    number_participants = get_number_of_tests(tabel_list)
    for i in range(get_number_of_participants(tabel_list)):
        total = 0
        for j in range(number_participants):
            total += tabel_list[i][j]
        average_list.append(int(total / len(tabel_list[0])))

    return average_list

# def get_heart_rate_difference(tabel_list):
#     result = []
#     number_of_participants = get_number_of_participants(tabel_list)
#     number_of_tests = get_number_of_tests(tabel_list)
#     for participant in range(number_of_participants):
#         highest = tabel_list[0][participant]
#         lowest = tabel_list[0][participant]
#
def main():
    tabel_list = [[72, 75, 71, 73, 72, 76],
                  [91, 90, 94, 93, 88, 91],
                  [130, 135, 143, 142, 129, 138],
                  [120, 118, 110, 105, 121, 119]]

    print("Number of participants per test:", get_number_of_participants(tabel_list))

    print("Number of tests:", get_number_of_tests(tabel_list))

    print("Highest heart rate:", highest_heart_rate(tabel_list))

    print("Lowest heart rate:", lowest_heart_rate(tabel_list))

    print("Average value per test:", average_heart_rate(tabel_list))
if __name__ == '__main__':
    main()
