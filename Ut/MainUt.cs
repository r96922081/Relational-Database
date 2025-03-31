namespace MyDBNs
{
    public class MainUt
    {
        public static void Ut()
        {
            Gv.ut = false;

            if (Gv.ut)
            {
                new GroupByUt().Ut();
                new SaveLoadUt().Ut();
                new CreateDropUt().Ut();
                new InsertUt().Ut();
                new SelectUt().Ut();
                new BooleanExpressionUt().Ut();
                new ArithmeticExpressionUt().Ut();
                new DeleteUt().Ut();
                new UpdateUt().Ut();
                new TransactionUt().Ut();
                new JoinUt().Ut();

                Console.WriteLine("MyDB Ut Done!");

                InteractiveConsole.Interactive();
            }
            else
            {
                sql_statements.Parse("LOAD DB DEMO.DB");
                InteractiveConsole.Interactive();
            }
        }

    }
}
