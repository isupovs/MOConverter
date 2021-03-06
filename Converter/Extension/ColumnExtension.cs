﻿using Microsoft.SqlServer.Management.Smo;

namespace Converter.Extension
{
    public static class ColumnExtension
    {
        internal static string QName(this Column self) => $"[{self.Name}]";

        internal static string FName(this Column self) => $"{((Table) self.Parent).FName()}.[{self.Name}]";

        internal static string UdtName(this Column self) =>
            $"{((UserDefinedTableType) self.Parent).FName()}.[{self.Name}]";


    }
}
