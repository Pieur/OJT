#include<iostream>
using namespace std;



int main() {
	char loop = 'N';
	do {
		system("cls");
		string plaintext = " ", cipherText = " ", key = " ", cipheredKey = " ", text;
		int keyLen;
		char choice;
		cout << "Encryption[E] or Decryption [D]: ";
		cin >> choice;

		if (toupper(choice) == 'E') {
			cout << "Input the plaintext: ";
			cin >> plaintext;
			text = plaintext;
			cipherText = plaintext;
		}
		else if (toupper(choice) == 'D') {
			cout << "Input the ciphertext: ";
			cin >> cipherText;
			text = cipherText;
			plaintext = cipherText;
		}

		cout << "Enter the key: ";
		cin >> key;

		for (int i = 0; i < text.length(); i++) {//toupper
			text[i] = toupper(text[i]);
		}
		for (int i = 0; i < key.length(); i++) {
			key[i] = toupper(key[i]);
		}

		if (text.length() > key.length()) {//keylength for the elongated key
			keyLen = text.length();
			cipheredKey = text;
		}
		else {
			keyLen = key.length();
			cipheredKey = key;
		}

		int h = 0;//used for making the index of the key back to the beginning when it reaches the end of the key length
		if (keyLen != key.length()) {
			for (int i = 0; i < keyLen; i++) {//establishing the cipher key
				if (h == key.length()) {
					h = 0;
				}
				cipheredKey[i] = key[h];
				h++;
			}
		}

		system("pause");
		system("cls");
		plaintext = text;
		cipherText = text;
		int ascii, j=0;

		if (toupper(choice) == 'E') {
			for (int i = 0; i < text.length(); i++) {
				if (int(cipherText[i]) >= 65 && int(cipherText[i]) <= 90) {
					ascii = int(cipherText[i]) + int(cipheredKey[j]);
					if (ascii > 155) {
						ascii = ascii - 26;
					}
					plaintext[i] = char(ascii - 65);
				}
				else {
					j--;
					cipherText[i] = plaintext[i];
				}j++;
			}
		}
		else if (toupper(choice) == 'D') {
			for (int i = 0; i < text.length(); i++) {
				if (int(cipherText[i]) >= 65 && int(cipherText[i]) <= 90) {
					ascii = int(cipherText[i]) - int(cipheredKey[j]);
					if (ascii < 0) {
						ascii = ascii + 26;
					}
					plaintext[i] = char(ascii + 65);
				}
				else {
					j--;
					plaintext[i] = cipherText[i];
				}
				j++;
			}
		}



		cout << "Ciphertext: " << cipherText;
		cout << "\nKey       : " << cipheredKey;
		cout << "\nPlaintext : " << plaintext;
		cout << "\n\nAgain? (Y/N):  ";
		cin >> loop;
	} while (toupper(loop) == 'Y');

	
}