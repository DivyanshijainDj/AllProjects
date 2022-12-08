Console.WriteLine("Assignment 3");
List<string> listArray = new List<string>(new string[] { "Santosh", "Rathod", "Tony", "Rody", "Santosh", "Rathod", "Karan", "Mody", "Ark", "ames", "Paper", "Pots", "Jarvise" });
String[] strArray = new string[] { "Santosh", "Rathod", "Tony", "Rody", "Santosh", "Rathod", "Karan", "Mody", "Ark", "ames", "Paper", "Pots", "Jarvise" };
int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 5, 2, 3, 5 };
List<int> listIntArray = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 5, 2, 3, 5 });
Boolean flag = true;
string? continueExecution = "y";
do
{
    Console.WriteLine("1. Sort String Array Based in the Length");
    Console.WriteLine("2. Using List Sort String Array Based in the Length");
    Console.WriteLine("3. Print Index of Even Odd Numbers");
    Console.WriteLine("4. Using List Print Index of Even Odd Numbers");
    Console.WriteLine("5. Print Index of Prime number");
    Console.WriteLine("6. Using List Print Index of Prime Numbers");
    Console.WriteLine("7. Print String Contains \"a\" \"A\"");
    Console.WriteLine("8. Using List Print String Contains \"a\" \"A\"");
    Console.WriteLine("9. Print String starts with A or K or M");
    Console.WriteLine("10. Using List Print String starts with A or K or M");
    Console.WriteLine("11. Print Repeated String in the Array");
    Console.WriteLine("12. Using List Print Repeated String in the Array");
    Console.WriteLine("13. Print Repeated Numbers in the Array");
    Console.WriteLine("14. Using List Print Repeated Numbers in the Array");
    Console.WriteLine("Enter your choice to perform operation");

    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        //Case1 Sort String Array Based in the Length
        case 1:

            // Array.Sort(strArray);
            for (int i = 0; i < strArray.Length - 1; i++)
            {

                if (strArray[i].Length > strArray[i + 1].Length)
                {
                    String tempstr = strArray[i];
                    strArray[i] = strArray[i + 1];
                    strArray[i + 1] = tempstr;
                    i = -1;
                }
            }
            Console.WriteLine("After sort");
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }
            break;
        case 2:
            //Case1 Using List
            //listArray.Sort();
            for (int i = 0; i < listArray.Count - 1; i++)
            {

                if (listArray[i].Length > listArray[i + 1].Length)
                {
                    String tempstr = listArray[i];
                    listArray[i] = listArray[i + 1];
                    listArray[i + 1] = tempstr;
                    i = -1;
                }
            }
            Console.WriteLine("After sort");
            for (int i = 0; i < listArray.Count; i++)
            {
                Console.WriteLine(listArray[i]);
            }
            break;
        case 3:
            //Case2 Index of Even and ODD
            Console.WriteLine("Even numbers index");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine($"{arr[i]} is at index: {i}");
                }
            }
            Console.WriteLine("Odd numbers index");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    Console.WriteLine($"{arr[i]} is at index: {i}");
                }
            }
            break;

        case 4:
            //Using List
            Console.WriteLine("Even numbers index");
            for (int i = 0; i < listIntArray.Count; i++)
            {
                if (listIntArray[i] % 2 == 0)
                {
                    Console.WriteLine($"{listIntArray[i]} is at index: {i}");
                }
            }
            Console.WriteLine("Odd numbers index");
            for (int i = 0; i < listIntArray.Count; i++)
            {
                if (listIntArray[i] % 2 == 1)
                {
                    Console.WriteLine($"{listIntArray[i]} is at index: {i}");
                }
            }
            break;
        case 5:
            //Case 3 Prime

            for (int i = 0; i < arr.Length - 1; i++)//9
            {
                flag = false;
                for (int j = 2; j < arr[i] - 1; j++)//2 te 8
                {
                    if (arr[i] % j == 0)//9%2te8
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                    Console.WriteLine($"{arr[i]} is at index: {i}");
            }
            break;
        case 6:
            //Case3 Using List

            for (int i = 0; i < listIntArray.Count; i++)
            {
                flag = false;
                for (int j = 2; j < listIntArray[i] - 1; j++)
                {
                    if (listIntArray[i] % j == 0)
                    {
                        flag = true;
                        break;
                    }
                    break;
                }
                if (flag)
                    Console.WriteLine($"{listIntArray[i]} is at index: {i}");
            }
            break;
        case 7:
            // Case4 String Contains a
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Contains("a") || strArray[i].Contains("A"))
                {
                    Console.WriteLine(strArray[i]);
                }

            }
            break;
        case 8:
            // Case 4 using list
            foreach (string str in listArray)
            {
                if (str.Contains("a") || str.Contains("A"))
                {
                    Console.WriteLine(str);
                }

            }
            break;
        case 9:
            // Case 5 Start with A or K or M

            foreach (var item in strArray)
            {
                if (item.StartsWith("A"))
                {
                    Console.WriteLine(item);
                }
                if (item.StartsWith("M"))
                {
                    Console.WriteLine(item);
                }
                if (item.StartsWith("K"))
                {
                    Console.WriteLine(item);
                }
            }
            break;

        case 10:
            //using List
            foreach (var item in listArray)
            {
                if (item.StartsWith("A"))
                {
                    Console.WriteLine(item);
                }
                if (item.StartsWith("M"))
                {
                    Console.WriteLine(item);
                }
                if (item.StartsWith("K"))
                {
                    Console.WriteLine(item);
                }
            }
            break;
        case 11:
            //Case 6 print repeated string
            String[] strArr = new string[] { "Santosh", "Rathod", "Tony", "Rody", "Santosh", "Santosh", "Rathod", "Karan", "Mody", "Ark", "ames", "Paper", "Pots", "Jarvise" };
            for (int i = 0; i < strArr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < strArr.Length; j++)
                {
                    if (strArr[i] == strArr[j])
                    {
                        count++;
                        strArr[j] = String.Empty;
                    }
                }
                if (count > 1 && strArr[i] != String.Empty)
                    Console.WriteLine($"The '{strArr[i]}' appears {count} times in array presents");
            }
            break;
        case 12:
            // using list
            List<string> strList = new List<string>(new string[] { "Santosh", "Rathod", "Tony", "Rody", "Santosh", "Rathod", "Karan", "Mody", "Ark", "ames", "Paper", "Pots", "Jarvise" });
            for (int i = 0; i < strList.Count; i++)
            {
                int count = 1;
                for (int j = i + 1; j < strList.Count; j++)
                {
                    if (strList[i] == strList[j])
                    {
                        count++;
                        strList[j] = String.Empty;
                    }
                }
                if (count > 1 && strList[i] != String.Empty
                    )
                    Console.WriteLine($"The '{strList[i]}' appears {count} times in array presents");
            }
            break;
        case 13:
            // Case 7 print repeated numbers
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr[j] = '\0';
                    }
                }
                if (count > 1 && arr[i] != '\0')
                    Console.WriteLine($"The '{arr[i]}' appears {count} times in array presents");
            }
            break;
        case 14:
            //using List
            for (int i = 0; i < listIntArray.Count; i++)
            {
                int count = 1;
                for (int j = i + 1; j < listIntArray.Count; j++)
                {
                    if (listIntArray[i] == listIntArray[j])
                    {
                        count++;
                        listIntArray[j] = '\0';
                    }
                }
                if (count > 1 && listIntArray[i] != '\0')
                    Console.WriteLine($"The '{listIntArray[i]}' appears {count} times in array presents");
            }
            break;
        default:
            Console.WriteLine("Enter Valid option");
            break;

    }
    Console.WriteLine("Please enter y or Y to continue");
    continueExecution = Console.ReadLine();
    Console.Clear();
} while (continueExecution == "y" || continueExecution == "Y");