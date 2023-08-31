
using System.Linq;



    public static class Class1
    {

        [Microsoft.SqlServer.Server.SqlFunction]
        public static int FirstCharacterOccurence(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            char ch = str[0];
            return str.Where(f => f == ch).Count();
        }


    [Microsoft.SqlServer.Server.SqlProcedure]
    public static int SumaDosValores(int val1, int val2)
    {
        
        return val1 + val2;
    }
}

