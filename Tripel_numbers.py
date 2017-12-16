import math
S = 0
print "From:"
From = raw_input()
print "To:"
To = raw_input()
From = int(From)
To = int(To)
A = From
B = A
while S == 0:
    C = math.sqrt(A*A+B*B)
    if float(int(C)) == C:
        print str(A) + "/" + str(B) + "/" + str(int(C))
    if B == To:
        if A == To:
            S = 1
    if A == To:
        A = B
        B = B+1
    A = A+1
