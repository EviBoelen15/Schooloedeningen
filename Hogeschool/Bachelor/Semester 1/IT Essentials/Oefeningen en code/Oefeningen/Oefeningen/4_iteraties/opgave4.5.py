nummer = 1
totaal = 0
while (nummer * nummer) % 1000 != 0:
    totaal += nummer
    nummer += 1
print("Totaal is", totaal)