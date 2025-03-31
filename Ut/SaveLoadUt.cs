﻿namespace MyDBNs
{
    public class SaveLoadUt : BaseUt
    {
        private void Ut1()
        {

        }

        private void Ut2()
        {
            Util.DeleteAllTable();

            sql_statements.Parse("CREATE TABLE A ( C1 VARCHAR(123), C2 NUMBER)");
            sql_statements.Parse("INSERT INTO A ( C1, C2 ) VALUES ( 'ABC', 11 )");
            sql_statements.Parse("INSERT INTO A ( C1 ) VALUES ( 'def' )");
            sql_statements.Parse("INSERT INTO A ( C2 ) VALUES ( 22 )");
            sql_statements.Parse("INSERT INTO A VALUES ( 'GG', 33 )");
            sql_statements.Parse("INSERT INTO A ( C2, C1 ) VALUES ( 55, 'EE' )");
            sql_statements.Parse("INSERT INTO A VALUES ( null, 66 )");
            sql_statements.Parse("INSERT INTO A VALUES ( 'G', null )");

            sql_statements.Parse("SAVE DB SaveLoadUt.db");
            Util.DeleteAllTable();

            sql_statements.Parse("load DB SaveLoadUt.db");
            List<object[]> rows = RunSelectStatementAndConvertResult("SELECT * FROM A");
            Check(rows.Count == 7);
        }

        public void Ut()
        {
            Ut1();
            Ut2();
        }
    }
}
