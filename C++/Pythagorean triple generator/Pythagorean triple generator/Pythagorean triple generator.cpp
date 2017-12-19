// Pythagorean triple generator.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "math.h"
using namespace std;

int main()
{
	int From;
	int To;
	int S = 0;
	cout << "From:";
	cin >> From;
	cout << "To:";
	cin >> To;
	int A = From;
	int B = A;
	float long C;
	int Break;

	while (S == 0) {
		C = sqrt(A*A + B*B);
		int Cr = C;
		if (Cr == C) {
			cout << A << "/" << B << "/" << Cr << endl;
		}
		if (A == To) {
			if (B == To) {
				S = 1;
			}
			A = B;
			B = B + 1;
		}
		A = A + 1;
	}
	cin >> Break;
    return 0;
}

