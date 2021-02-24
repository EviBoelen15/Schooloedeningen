naam = str(input("Naam: "))
percent = int(input("Behaalde percentage: "))

while naam != "xx" or "XX":
    if (percent < 0 or percent > 100):
        print("ongelevdig percent")
    elif(percent >= 0 or percent <= 100):
        if(percent < 60):
            print("onvoldoende")
        elif(percent < 70):
            print("voldoende")
        elif(percent < 80):
            print("onderscheiding")
        elif(percent < 85):
            print("grote onderscheiding")
        else:
            print("grootste onderscheiding")

    naam = str(input("Naam: "))
    percent = int(input("Behaalde percentage: "))

print("klaar!")