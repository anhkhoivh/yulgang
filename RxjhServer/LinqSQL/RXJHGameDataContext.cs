namespace LinqSQL
{
    using System;
    using System.Data;
    using System.Data.Linq;
    using System.Data.Linq.Mapping;

    [Database(Name="rxjhgame")]
    public class RXJHGameDataContext : DataContext
    {
        private static MappingSource mappingSource = new AttributeMappingSource();

        //public RXJHGameDataContext() : base(Settings.Default.rxjhgameConnectionString, mappingSource)
        //{
        //}

        public RXJHGameDataContext(IDbConnection connection) : base(connection, mappingSource)
        {
        }

        public RXJHGameDataContext(string connection) : base(connection, mappingSource)
        {
        }

        public RXJHGameDataContext(IDbConnection connection, MappingSource mappingSource) : base(connection, mappingSource)
        {
        }

        public RXJHGameDataContext(string connection, MappingSource mappingSource) : base(connection, mappingSource)
        {
        }

        public Table<TBL_XWWL_Char> TBL_XWWL_Chars
        {
            get
            {
                return base.GetTable<TBL_XWWL_Char>();
            }
        }

        public Table<LinqSQL.TBL_XWWL_Pigeons> TBL_XWWL_Pigeons
        {
            get
            {
                return base.GetTable<LinqSQL.TBL_XWWL_Pigeons>();
            }
        }
    }
}

