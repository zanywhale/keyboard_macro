using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        //키보드 이벤트 
        [DllImport("user32.dll")]
        public static extern void keybd_event(
            byte bVk,  //virtual-key code
            byte bScan, //hardware scan code
            int dwFlags,  //function options 
            ref int dwExtraInfo  //additional keystroke data 
        );

        static void Main(string[] args)
        {
            const byte CtrlKey = 0x11;
            const byte WinKey = 0x5B;
            const byte RightKey = 0x27;
            const byte LeftKey = 0x25;
            const byte AltKey = 0x12;
            const byte LeftShift = 0xa0;
            const int KEYUP = 0x02;
            const int SpaceBar = 0x20;
            const int zero = 0x30;
            const int one = 0x31;
            const int two = 0x32;
            const int three = 0x33;
            const int four = 0x34;
            const int five = 0x35;
            const int six = 0x36;
            const int seven = 0x37;
            const int eight = 0x38;
            const int nine = 0x39;
            const int A = 0x41;
            const int B = 0x42;
            const int C = 0x43;
            const int D = 0x44;
            const int E = 0x45;
            const int F = 0x46;
            const int G = 0x47;
            const int H = 0x48;
            const int I = 0x49;
            const int J = 0x4A;
            const int K = 0x4B;
            const int L = 0x4C;
            const int M = 0x4D;
            const int N = 0x4E;
            const int O = 0x4F;
            const int P = 0x50;
            const int Q = 0x51;
            const int R = 0x52;
            const int S = 0x53;
            const int T = 0x54;
            const int U = 0x55;
            const int V = 0x56;
            const int W = 0x57;
            const int X = 0x58;
            const int Y = 0x59;
            const int Z = 0x5A;


            if (args.Length != 2)
            {
                Console.WriteLine("Usage : \n./keyboard [PATH] [SlEEP TIME]");
                System.Environment.Exit(1);
            }

            int info = 0;
            char INPUT = '\x00';
            StreamReader reader;
            reader = new StreamReader(@args[0]);
            Thread.Sleep(5000);

            do
            {
                INPUT = (char)reader.Read();
                switch (INPUT)
                {
                    case (char)0x09:
                        keybd_event(0x09, 0, 0, ref info);
                        keybd_event(0x09, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '\n':
                        keybd_event(0x0d, 0, 0, ref info);
                        keybd_event(0x0d, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case ' ':
                        keybd_event(SpaceBar, 0, 0, ref info);
                        keybd_event(SpaceBar, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '0':
                        keybd_event(zero, 0, 0, ref info);
                        keybd_event(zero, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case ')':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(zero, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(zero, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '1':
                        keybd_event(one, 0, 0, ref info);
                        keybd_event(one, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '!':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(one, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(one, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '2':
                        keybd_event(two, 0, 0, ref info);
                        keybd_event(two, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '@':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(two, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(two, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '3':
                        keybd_event(three, 0, 0, ref info);
                        keybd_event(three, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '#':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(three, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(three, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '4':
                        keybd_event(four, 0, 0, ref info);
                        keybd_event(four, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '$':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(four, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(four, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '5':
                        keybd_event(five, 0, 0, ref info);
                        keybd_event(five, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '%':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(five, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(five, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '6':
                        keybd_event(six, 0, 0, ref info);
                        keybd_event(six, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '^':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(six, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(six, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '7':
                        keybd_event(seven, 0, 0, ref info);
                        keybd_event(seven, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '&':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(seven, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(seven, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '8':
                        keybd_event(eight, 0, 0, ref info);
                        keybd_event(eight, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '*':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(eight, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(eight, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '9':
                        keybd_event(nine, 0, 0, ref info);
                        keybd_event(nine, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '(':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(nine, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(nine, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'A':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(A, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(A, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'B':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(B, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(B, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'C':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(C, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(C, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'D':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(D, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(D, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'E':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(E, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(E, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'F':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(F, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(F, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'G':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(G, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(G, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'H':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(H, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(H, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'I':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(I, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(I, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'J':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(J, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(J, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'K':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(K, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(K, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'L':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(L, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(L, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'M':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(M, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(M, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'N':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(N, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(N, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'O':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(O, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(O, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'P':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(P, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(P, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'Q':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(Q, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(Q, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'R':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(R, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(R, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'S':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(S, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(S, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'T':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(T, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(T, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'U':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(U, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(U, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'V':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(V, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(V, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'W':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(W, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(W, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'X':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(X, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(X, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'Y':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(Y, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(Y, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'Z':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(Z, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(Z, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'a':
                        keybd_event(A, 0, 0, ref info);
                        keybd_event(A, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'b':
                        keybd_event(B, 0, 0, ref info);
                        keybd_event(B, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'c':
                        keybd_event(C, 0, 0, ref info);
                        keybd_event(C, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'd':
                        keybd_event(D, 0, 0, ref info);
                        keybd_event(D, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'e':
                        keybd_event(E, 0, 0, ref info);
                        keybd_event(E, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'f':
                        keybd_event(F, 0, 0, ref info);
                        keybd_event(F, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'g':
                        keybd_event(G, 0, 0, ref info);
                        keybd_event(G, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'h':
                        keybd_event(H, 0, 0, ref info);
                        keybd_event(H, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'i':
                        keybd_event(I, 0, 0, ref info);
                        keybd_event(I, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'j':
                        keybd_event(J, 0, 0, ref info);
                        keybd_event(J, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'k':
                        keybd_event(K, 0, 0, ref info);
                        keybd_event(K, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'l':
                        keybd_event(L, 0, 0, ref info);
                        keybd_event(L, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'm':
                        keybd_event(M, 0, 0, ref info);
                        keybd_event(M, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'n':
                        keybd_event(N, 0, 0, ref info);
                        keybd_event(N, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'o':
                        keybd_event(O, 0, 0, ref info);
                        keybd_event(O, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'p':
                        keybd_event(P, 0, 0, ref info);
                        keybd_event(P, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'q':
                        keybd_event(Q, 0, 0, ref info);
                        keybd_event(Q, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'r':
                        keybd_event(R, 0, 0, ref info);
                        keybd_event(R, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 's':
                        keybd_event(S, 0, 0, ref info);
                        keybd_event(S, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 't':
                        keybd_event(T, 0, 0, ref info);
                        keybd_event(T, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'u':
                        keybd_event(U, 0, 0, ref info);
                        keybd_event(U, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'v':
                        keybd_event(V, 0, 0, ref info);
                        keybd_event(V, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'w':
                        keybd_event(W, 0, 0, ref info);
                        keybd_event(W, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'x':
                        keybd_event(X, 0, 0, ref info);
                        keybd_event(X, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'y':
                        keybd_event(Y, 0, 0, ref info);
                        keybd_event(Y, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case 'z':
                        keybd_event(Z, 0, 0, ref info);
                        keybd_event(Z, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '[':
                        keybd_event(0xDB, 0, 0, ref info);
                        keybd_event(0xDB, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '{':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(0xDB, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(0xDB, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '\\':
                        keybd_event(0xDC, 0, 0, ref info);
                        keybd_event(0xDC, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '|':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(0xDC, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(0xDC, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case ']':
                        keybd_event(0xDD, 0, 0, ref info);
                        keybd_event(0xDD, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '}':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(0xDD, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(0xDD, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '\'':
                        keybd_event(0xDE, 0, 0, ref info);
                        keybd_event(0xDE, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '\"':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(0xDE, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(0xDE, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '`':
                        keybd_event(0xC0, 0, 0, ref info);
                        keybd_event(0xC0, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '~':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(0xC0, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(0xC0, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '/':
                        keybd_event(0xBF, 0, 0, ref info);
                        keybd_event(0xBF, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '?':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(0xBF, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(0xBF, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case ';':
                        keybd_event(0xBA, 0, 0, ref info);
                        keybd_event(0xBA, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case ':':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(0xBA, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(0xBA, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '=':
                        keybd_event(0xBB, 0, 0, ref info);
                        keybd_event(0xBB, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '+':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(0xBB, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(0xBB, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case ',':
                        keybd_event(0xBC, 0, 0, ref info);
                        keybd_event(0xBC, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '<':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(0xBC, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(0xBC, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '-':
                        keybd_event(0xBD, 0, 0, ref info);
                        keybd_event(0xBD, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '_':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(0xBD, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(0xBD, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '.':
                        keybd_event(0xBE, 0, 0, ref info);
                        keybd_event(0xBE, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;

                    case '>':
                        keybd_event(LeftShift, 0, 0, ref info);
                        keybd_event(0xBE, 0, 0, ref info);
                        keybd_event(LeftShift, 0, KEYUP, ref info);
                        keybd_event(0xBE, 0, KEYUP, ref info);
                        Thread.Sleep(int.Parse(args[1]));
                        break;
                }
            } while (!reader.EndOfStream);
        }
    }
}