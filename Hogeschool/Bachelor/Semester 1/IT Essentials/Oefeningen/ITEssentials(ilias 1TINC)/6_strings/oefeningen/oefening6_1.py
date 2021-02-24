# def tekst_omzetten(tekst):
    # letter = tekst.find("t")
    # if letter in tekst:
    #    if len(tekst) % 2 == 0:
    #         return tekst.upper()
    #    else:
    #        return tekst.lower()
    # else:
    #    print("Geen letter t in opgegeven tekst")

def main():
    nieuwe_tekst = ""
    tekst = input("Geef hier tekst in: ")
    index_van_t = tekst.upper().find("T")
    if index_van_t == -1:
        print("De gegeven tekst bevat geen t of T")
    else:
        nieuwe_tekst = tekst[0:index_van_t + 1]
        if len(tekst) % 2 == 0:
            nieuwe_tekst += tekst[:index_van_t + 1].lower()
        else:
            nieuwe_tekst = tekst[:index_van_t + 1].upper()
    print(nieuwe_tekst)

if __name__ == '__main__':
    main()