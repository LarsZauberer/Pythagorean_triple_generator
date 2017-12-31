# tripel_numbers.py
# Application form LarsGaming
# Author: LarsZauberer
"""tripel_numbers.py
Returns LIST of pythagorean triple numbers in the given range
"""
import math

# Define the search function
def search_numbers(from_nbr, to_nbr, save_type):
    """search_numbers(from_nbr, to_nbr, save_type, listing).
    -> returns LIST of pythagorean triple numbers in the given range
    Keywords:
    from_nbr:   starting number as base of the triple
    to_nbr:     highest number as base of the triple
    save_type:  SHOW, LIST or SAVE
    """
    var_a = int(from_nbr)
    var_b = var_a
    var_c = 0
    var_s = 1
    listing = []
    while var_s:
        # Calculation
        var_c = math.sqrt(var_a*var_a+var_b*var_b)
        # Is it a tripel?
        if float(int(var_c)) == var_c:
            if save_type == "SHOW":
                print(str(var_a) + "/" + str(var_b) + "/" + str(int(var_c)))
            else:
                listing.append(str(var_a) + " / " + str(var_b) + " / " + str(int(var_c)))
        # Is the end reached?
        if var_b == int(to_nbr):
            if var_a == int(to_nbr):
                var_s = 0
        # Make B bigger and reset A
        if var_a == int(to_nbr):
            var_a = int(from_nbr)
            var_b = var_b+1
        # Make A bigger
        var_a = var_a+1
    if save_type == "LIST":
        return listing
    elif save_type == "SAVE":
        with open("Tripels.txt", "a+") as file:
            for i in listing:
                file.write(i + "\n")
        return 0
    else:
        return 0
# End of function "Search_Numbers"

# Stat of the Main App
# Input of range with verification on correct input
try:
    TEST_FROM = float(input("Number to Start from (FROM): "))
except ValueError:
    print("Please type in a number!")
try:
    TEST_TO = float(input("Maximum Number to go (TO):   "))
except ValueError:
    print("Please type in a number!")
print("OK : From " + str(TEST_FROM) +" to " + str(TEST_TO))
print("Starting by rounding the numbers")
ERGEBNIS = search_numbers(int(round(float(TEST_FROM))), int(round(float(TEST_TO))), "SAVE")
if ERGEBNIS != 0:
    print(ERGEBNIS)
print("Ende: Please press a ENTER!")
END_PROGRAM = input()