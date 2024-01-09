var itemsNotInColumn2 = dt.AsEnumerable()
    .Select(row => row.Field<string>("Column1"))
    .Except(dt.AsEnumerable().Select(row => row.Field<string>("Column2")));
