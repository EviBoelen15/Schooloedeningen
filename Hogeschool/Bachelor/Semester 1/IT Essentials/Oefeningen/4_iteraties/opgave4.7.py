welkgetal = int(input("Van welk getal wil je de faculteit berekenen?"))
teller = 1
faculteit = 1

while (teller <= welkgetal):
    faculteit = faculteit * teller
    teller +=1
    print(faculteit)
