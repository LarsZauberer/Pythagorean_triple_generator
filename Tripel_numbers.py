#Define the function
def Search_Numbers(From, To, SaveType, List):
    import math
    A = int(From)
    B = A
    S = 0
    while S == 0:
        #Calculation
        C = math.sqrt(A*A+B*B)
        #Is it a tripel?
        if float(int(C)) == C:
            if SaveType == "show":
                print (str(A) + "/" + str(B) + "/" + str(int(C)))
            else:
                List.insert(str(A) + "/" + str(B) + "/" + str(int(C)))
        #Is the end reached?
        if B == To:
            if A == To:
                S = 1
        #Make B bigger and reset A
        if A == To:
            A = B
            B = B+1
        #Make A bigger
        A = A+1
    if SaveType == "list":
        return List
    elif SaveType == "save":
        with open("Tripels.txt") as f:
            f.write(List)
    else:
        return 0

#Input of range
print ("From:")
Test_From = input()
print ("To:")
Test_To = input()

Search_Numbers(Test_From, Test_To, "show", 0)

Break = input()