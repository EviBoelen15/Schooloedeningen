brutoloon = float(input("Geef uw bruto loon in: "))

vakantiegeld = brutoloon * 0.05
if (vakantiegeld >= 350):
    bijdragen = 350 * 0.08
if (vakantiegeld < 350):
    bijdragen = vakantiegeld * 0.08

print(brutoloon)
print(vakantiegeld)
print(bijdragen)