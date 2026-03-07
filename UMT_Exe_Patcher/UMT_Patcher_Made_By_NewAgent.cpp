#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <fstream>
#include <vector>
#include <cstring>
#include <ctime>
#include <conio.h>
#include <cstdio>
#include <string>

using namespace std;

vector<unsigned char> targetHex = {
0x68,0x74,0x74,0x70,0x73,0x3A,0x2F,0x2F,0x61,0x70,0x69,0x2E,
0x75,0x6E,0x69,0x76,0x65,0x72,0x73,0x61,0x6C,0x6D,0x69,0x6E,
0x65,0x63,0x72,0x61,0x66,0x74,0x74,0x6F,0x6F,0x6C,0x2E,0x63,
0x6F,0x6D
};

string readLimitedInput(int maxLen)
{
    string input;
    char c;

    while (true)
    {
        c = _getch();

        if (c == 13)
            break;

        if (c == 8)
        {
            if (!input.empty())
            {
                input.pop_back();
                cout << "\b \b";
            }
        }
        else if (input.length() < maxLen)
        {
            input += c;
            cout << c;
        }
    }

    cout << endl;
    return input;
}

void waitForEnter()
{
    cout << "\nPress ENTER To Close The Program";
    cin.ignore();
    cin.get();
}

int main()
{
    cout << "----------------------------------------------------\n";
    cout << "      Universal Minecraft Tool Cracker Patcher      \n";
    cout << " This Program Was Made By NewAgent Aka I Am Covid-19\n";
    cout << "----------------------------------------------------\n\n";

    cout << "Give Me Your Proved URL\n";
    cout << "THIS WILL STAY Inside The Program Forever\n\n";

    cout << "DISCLAMIER YOU NEED To ENTER Your Correct URL To Contune\n";
    cout << "OTHER Wise It Will Not Work\n\n";

    cout << "Would You Like To Continue? YES/NO Y/N\n";
    cout << "Type: --> ";

    string choice;
    cin >> choice;

    if (choice == "N" || choice == "n" || choice == "No" || choice == "no")
    {
        cout << "\nCracking Program Closed\n";
        waitForEnter();
        return 0;
    }

    if (!(choice == "Y" || choice == "y" || choice == "Yes" || choice == "yes"))
    {
        cout << "\nInvalid Input\n";
        waitForEnter();
        return 0;
    }

    cin.ignore();

    string url;

    while (true)
    {
        cout << "\nEnter URL (EXACTLY 38 CHARACTERS LONG)\n";
        cout << "Type: --> ";

        url = readLimitedInput(38);

        if (url.length() < 38)
        {
            cout << "\nERROR: URL Is To Short IT MUST Be Exactly 38 Characters Long\n";
            continue;
        }

        break;
    }

    ifstream fileCheck("UniversalMinecraftTool.exe", ios::binary);

    if (!fileCheck)
    {
        cout << "\nERROR: UniversalMinecraftTool.exe WASN'T Found\n";
        cout << "Place This Patcher With The Same Folder As The UMT EXE\n";
        waitForEnter();
        return 0;
    }

    vector<unsigned char> data((istreambuf_iterator<char>(fileCheck)), {});
    fileCheck.close();

    bool found = false;

    for (size_t i = 0; i <= data.size() - targetHex.size(); i++)
    {
        if (memcmp(&data[i], targetHex.data(), targetHex.size()) == 0)
        {
            memcpy(&data[i], url.c_str(), 38);
            found = true;
        }
    }

    if (!found)
    {
        cout << "\nCould Not Patch UMT Make Sure It's The Correct File\n";
        waitForEnter();
        return 0;
    }

    time_t t = time(nullptr);
    tm now;
    localtime_s(&now, &t);
    int year = now.tm_year + 1900;

    string filename = "UMT_Cracked_" + to_string(year) + ".exe";

    ifstream checkFile(filename);

    if (checkFile.good())
    {
        checkFile.close();

        cout << "\n" << filename << " Already Exists\n";
        cout << "Do You Want To Replace It? YES/NO Y/N\n";
        cout << "Type: --> ";

        string replaceChoice;
        cin >> replaceChoice;

        if (replaceChoice == "N" || replaceChoice == "n" || replaceChoice == "No" || replaceChoice == "no")
        {
            cout << "\nReplacement Has Been Canceled\n";
            waitForEnter();
            return 0;
        }

        if (replaceChoice == "Y" || replaceChoice == "y" || replaceChoice == "Yes" || replaceChoice == "yes")
        {
            remove(filename.c_str());
            cout << "\nReplaced The UMT_Cracked EXE With New One\n";
        }
        else
        {
            cout << "\nInvalid Input\n";
            waitForEnter();
            return 0;
        }
    }

    ofstream out(filename, ios::binary);
    out.write((char*)data.data(), data.size());
    out.close();

    cout << "\n----------------------------------------------\n";
    cout << "URL Successfully Embedded Into Program\n";
    cout << "This URL Will Stay Inside The Program Forever\n";
    cout << "----------------------------------------------\n";

    cout << "\nSaved As: " << filename << endl;

    waitForEnter();

    return 0;
}