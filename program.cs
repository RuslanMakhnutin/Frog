int indexX = 0, indexY = 0;

string[,] StringArray = new string[3, 4];
string[,] ResultArray = new string[3, 4];

StringArray[0, 0] = "Hello"; StringArray[0, 1] = "2"; StringArray[0, 2] = "world"; StringArray[0, 3] = ":-)"; 
StringArray[1, 0] = "1234"; StringArray[1, 1] = "1567"; StringArray[1, 2] = "-2"; StringArray[1, 3] = "computer science";
StringArray[2, 0] = "Russia"; StringArray[2, 1] = "Denmark"; StringArray[2, 2] = "Kazan";

int sizeX = StringArray.GetLength(0) - 1;
int sizeY = StringArray.GetLength(1) - 1;

SymbolChecker();

void SymbolChecker()
{
    if (indexX <= sizeX)
    {
        if (indexY <= sizeY)
        {
            if (StringArray[indexX, indexY] != null && StringArray[indexX, indexY].Length <= 3 )
            {
                ResultArray[indexX, indexY] = StringArray[indexX, indexY];
                Console.Write(ResultArray[indexX, indexY] + " ");
                indexY++;
            }

            else
            {
                indexY++;
            }
        }
        else
        {
            Console.WriteLine();
            indexX++;
            indexY = 0;
        }
        SymbolChecker();
    }
}
