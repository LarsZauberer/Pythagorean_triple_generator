#Imports
import math

def tripel_numbers_generator(From, To, R_Type):
        #Variables
        S = 0
        list_output = []
        #Update Variables
        A = From
        B = A
        while S == 0:
            #Calculation
            C = math.sqrt(A*A+B*B)
            #Is it a tripel?
            if float(int(C)) == C:
                if R_Type == "print":
                    print (str(A) + "/" + str(B) + "/" + str(int(C)))
                elif R_Type == "list":
                    list_output.append(str(A) + "/" + str(B) + "/" + str(int(C)))
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
        return list_output

if __name__ == "__main__":
    #Input of range
    print ("From:")
    From = input()
    print ("To:")
    To = input()
    From = int(From)
    To = int(To)

    tripel_numbers_generator(From, To, "print")

Break = input()
