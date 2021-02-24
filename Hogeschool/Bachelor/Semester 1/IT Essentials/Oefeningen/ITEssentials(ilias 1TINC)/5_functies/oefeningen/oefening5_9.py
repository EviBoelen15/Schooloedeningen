def hotel_kosten(aantal_nachten):
    gratis_nachten = int(aantal_nachten / 3)
    prijs = 140.5 * aantal_nachten - gratis_nachten * 140.5
    return prijs

def vliegtuig_kosten(stad):
    reiskosten = 0
    if stad == "Barcelona":
        reiskosten = 183
    elif stad == "Rome":
        reiskosten = 220
    elif stad == "Berlijn":
        reiskosten = 125
    elif stad == "Oslo":
        reiskosten = 450
    return reiskosten

def huurauto_kosten(aantal_dagen):
    huurkosten = 40 * aantal_dagen
    korting = 0
    if aantal_dagen > 3:
        korting = 20
    elif aantal_dagen > 7:
        korting = 50

    return huurkosten - korting

def reis_kosten(stad, aantal_dagen):
    autoverhuur = huurauto_kosten(aantal_dagen)
    vluchten = vliegtuig_kosten(stad)
    hotelkosten = hotel_kosten(aantal_dagen - 1)

    return autoverhuur + vluchten + hotelkosten

def main():
    stad = input("Stad waar u naartoe wilt: ")

    while stad != "Barcelona" and stad != "Rome" and stad != "Berlijn" and stad != "Oslo":
        stad = input("Fout! Geef een juiste stad in: ")

    aantal_dagen = int(input("Aantal dagen: "))

    totaal = reis_kosten(stad, aantal_dagen)

    print("Totale kosten voor reis bedraagt: ", totaal)

if __name__ == '__main__':
    main()