// Assuming currentWeekTable and previousWeekTable are your DataTables
DataTable currentWeekTable = ... // your current week DataTable
DataTable previousWeekTable = ... // your previous week DataTable

// Create a list to store items not present in Column2 of previousWeekTable
List<string> itemsNotInPreviousWeek = new List<string>();

// Method to get the value of "Column1"
string getColumn1Value(DataRow row)
{
    return row["Column1"].ToString();
}

// Iterate through rows in currentWeekTable
foreach (DataRow row in currentWeekTable.Rows)
{
    string valueInColumn1 = getColumn1Value(row);

    // Check if the value in Column1 is not present in Column2 of previousWeekTable
    if (!previousWeekTable.AsEnumerable().Any(r => r["Column2"].ToString() == valueInColumn1))
    {
        itemsNotInPreviousWeek.Add(valueInColumn1);
    }
}

foreach (var item in itemsNotInPreviousWeek)
{
    // Do something with the items not present in Column2 of previousWeekTable
    // For example, you can print them or perform some other operations
    Console.WriteLine(item);
}
