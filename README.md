2 Задание - 5 практос

```csharp
    static string ReetCultString(string inputString)
    {
        char[] symbolsArray = inputString.ToCharArray();

        for (int i = 2; i < symbolsArray.Length; i += 3)
        {
            if (Char.IsLetter(symbolsArray[i]))
            {
                symbolsArray[i] = Char.ToUpper(symbolsArray[i]);
            }
        }

        string resultString = new string(symbolsArray);

        return resultString;
    }
```
