#Imports
import math

#Variables
S = 0

#Input of range
print "From:"
From = raw_input()
print "To:"
To = raw_input()
From = int(From)
To = int(To)

#Update Variables
A = From
B = A

while S == 0:
    #Calculation
    C = math.sqrt(A*A+B*B)
    #Is it a tripel?
    if float(int(C)) == C:
        print str(A) + "/" + str(B) + "/" + str(int(C))
    #Is the end reached?
    if B == To:
        if A == To:
            S = 1
    #Make B bigger
    if A == To:
        A = B
        B = B+1
    #Make A bigger
    A = A+1
