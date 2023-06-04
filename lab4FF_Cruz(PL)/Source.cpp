#include<iostream>
#include<set>
using namespace std;

void printResult(set<int> Res) {
	for (auto elem : Res) {
		cout << elem << " ";
	}
	cout << endl;
	system("pause");
}
void Un(set<int> a, set<int> b, set<int> res) {
	for (auto elem1 : a) {
		for (auto elem2 : b) {
			if (elem1 != elem2) {
				res.insert(elem1);			
			}	
			if (elem2 != elem1) {
				res.insert(elem2);

			}
				
		}
	}
	cout << "\n\t==UNION==\n";
	cout << "The union of sets A and B is/are: ";
	for (auto elem : res) {
		std::cout << " " << elem;
	}

}
void In(set<int> a, set<int> b, set<int> res) {
	for (auto elem1 : a) {
		for (auto elem2 : b) {
			if (elem1 == elem2) {
				res.insert(elem1);
			}
			if (elem2 == elem1) {
				res.insert(elem2);

			}

		}
	}
	cout << "\n\t==INTERSECTION==\n";
	cout << "The intersection of sets A and B is/are: ";
	for (auto elem : res) {
		std::cout << " " << elem;
	}

}

void Dif(set<int> a, set<int> b, set<int> res, int dfChoice) {
	if (dfChoice == 1) {
		for (auto elem1 : a) {
			for (auto elem2 : b) {
				if (elem1 != elem2) {
					res.insert(elem1);
				}
			}
		}
		for (auto elem1 : a) {
			for (auto elem2 : b) {
				if (elem1 == elem2) {
					res.erase(elem1);
				}

			}
		}
	}
	else if (dfChoice == 2) {
		for (auto elem1 : b) {
			for (auto elem2 : a) {
				if (elem1 != elem2) {
					res.insert(elem1);
				}
			}
		}
		for (auto elem1 : b) {
			for (auto elem2 : a) {
				if (elem1 == elem2) {
					res.erase(elem1);
				}
			
			}
		}
	}
	cout << "\n\t==DIFFERENCE==\n";
	cout << "The difference of sets A and B is/are: ";
	for (auto elem : res) {
		std::cout << " " << elem;
	}
}
void cardnl(int aLent, int bLent) {
	cout << "\n\t==CARDINALITY==\n";
	cout << "The cardinality of sets A and B is: " << aLent + bLent << "\n\n";
	system("pause");

}
int main() {
	char endloop = 'N';
	do{
		set<int> A;
		set<int> B;
		set<int>result;
		int value, value2;
		int aLen = 0, bLen = 0;
		int choice, diff_choice;
		bool chValidation = false, validation = false;

		do {
			system("cls");
			validation = false;
			chValidation = false;
			A.clear();
			B.clear();
			result.clear();
			cout << "\t==Menu== \n[1]Union \n[2]Interesection \n[3]Difference \n[4]Cardinality \n====================\nEnter your choice: ";
			cin >> choice;
			if (choice < 1 || choice > 4) {
				chValidation = true;
				cout << "\n\nTry again!\n\n";
				system("pause");
			}
			if (chValidation == false) {
				if (validation == false) {
					cout << "====================\nEnter the number of elements inside the set A: ";
					cin >> aLen;
					for (int i = 0; i < aLen; i++) {
						cout << "Enter a number for set A element number " << i + 1 << ": ";
						cin >> value;
						for (auto elem : A) {
							if (elem == value) {
								cout << "\n\nTry again!\n\n";
								validation = true;
								system("pause");
								break;
							}
							else
								validation = false;
						}
						A.insert(value);
						if (validation==true) 
							break;					
					}
				}
				if (validation == false) {
					cout << "====================\nEnter the number of elements inside the set B: ";
					cin >> bLen;
					for (int i = 0; i < bLen; i++) {
						cout << "Enter a number for set B element number" << i + 1 << ": ";
						cin >> value2;

						for (auto elem : B) {
							if (elem == value2) {
								cout << "\n\nTry again!\n\n";
								validation = true;
								system("pause");
								break;
							}
							else
								validation = false;
						}
						B.insert(value2);
						if (validation == true)
							break;
					}
				}
			}
			else
				validation = true;
		} while (validation == true);
		if (choice == 1) {
			Un(A, B, result);
		}
		else if (choice == 2) {
			In(A, B, result);
		}
		else if (choice == 3) {
			cout << "\t==OPTION==\n\n";
			cout << "[1] A-B\n[2] B-A\n";
			do {				
				cout << "Choice: ";
				cin >> diff_choice;
				if (diff_choice != 1 && diff_choice != 2) 
					cout << "\n\nTry again!\n\n";
				
			}while(diff_choice != 1 && diff_choice != 2);
			
			Dif(A, B, result, diff_choice);
		}
		else if (choice == 4) {
			cardnl(aLen, bLen);
		}
		do{
			cout << "\n\nEnter again?(Y/N): ";
			cin >> endloop;
			if (toupper(endloop) != 'Y' && toupper(endloop) != 'N')
				cout << "\n\nTry again!\n\n";
			cout << endl;
		} while (toupper(endloop) != 'Y'&& toupper(endloop) != 'N');
		
	} while (toupper(endloop) == 'Y');
}