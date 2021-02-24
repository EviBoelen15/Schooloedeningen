#driehoek optellend
for i in range(5):
    for j in range(i + 1):
        print(j + 1, end="")
    print(" ")

#driehoek optellend
start = 1
for i in range(5):
   for j in range(i + 1):
      print(start, end=" ")
      start += 1
   print("")

#aftellende driehoek in "n" aantal keren met "c" symbool
def triangle(c, n):
    for i in range(n, 0, -1):
        print(c * i)

triangle("X", 5)


# printen van een pyramide
def triangle(n):
    # number of spaces
    k = 2 * n - 2

    # outer loop to handle number of rows
    for i in range(0, n):

        # inner loop to handle number spaces
        # values changing acc. to requirement
        for j in range(0, k):
            print(end=" ")

            # decrementing k after each loop
        k = k - 1

        # inner loop to handle number of columns
        # values changing acc. to outer loop
        for j in range(0, i + 1):
            # printing stars
            print("* ", end="")

            # ending line after each row
        print("\r")

    # Driver Code


n = 5
triangle(n)