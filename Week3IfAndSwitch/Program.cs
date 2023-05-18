//modulus - % - võimaldab leida ülejäägi jagamistehtest; ehk kui a = 25, b = 8, siis a / b tuleb 3 (sest 8 mahub 3 korda 25 sisse), aga a % b annab 1, sest 25-8x3=1
//kui väiksem väärtus % suuremaga, nt a = 24, b = 8 b % a, siis annab vastuseks b väärtuse (24 inimesele jagada 8 küpsist, siis ei hakka küpsiseid murdma, jätad kõik küpsised endale)
int a = 24;
int b = 8;

int c = b % a; //tehted -> +;-;*;/;

Console.WriteLine(c);
