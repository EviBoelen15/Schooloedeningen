totaal = 0
teller = 0
gemiddelde = 0

while teller < 5:
    totaal += int(input("Geef een nummer:"))
    teller += 1
    gemiddelde = totaal / teller


print("Totaal is", totaal, gemiddelde)