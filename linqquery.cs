(from row1 in dt1.AsEnumerable()
                         join row2 in dt2.AsEnumerable() on row1.Field<string>("Column1") equals row2.Field<string>("Column2") into gj
                         from subRow in gj.DefaultIfEmpty()
                         where subRow == null
                         select row1.Field<string>("Column1")).ToList();
