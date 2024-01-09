// Create a DataTable
DataTable dataTable = new DataTable("MyTable");

// Add columns to the DataTable
dataTable.Columns.Add("ID", typeof(int));
dataTable.Columns.Add("Name", typeof(string));
dataTable.Columns.Add("Age", typeof(int));

// Add rows to the DataTable
DataRow row1 = dataTable.NewRow();
row1["ID"] = 1;
row1["Name"] = "John";
row1["Age"] = 25;
dataTable.Rows.Add(row1);

DataRow row2 = dataTable.NewRow();
row2["ID"] = 2;
row2["Name"] = "Alice";
row2["Age"] = 30;
dataTable.Rows.Add(row2);

// Access data in the DataTable
foreach (DataRow row in dataTable.Rows)
{
    Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}, Age: {row["Age"]}");
}
