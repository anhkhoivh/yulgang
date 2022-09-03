namespace LinqSQL
{
    using System;
    using System.Data;
    using System.Data.Linq;
    using System.Data.Linq.Mapping;

    [Database(Name="publicdb")]
    public class PublicDBDataContext : DataContext
    {
        private static MappingSource mappingSource = new AttributeMappingSource();

        //public PublicDBDataContext() : base(Settings.Default.publicdbConnectionString, mappingSource)
        //{
        //}

        public PublicDBDataContext(IDbConnection connection) : base(connection, mappingSource)
        {
        }

        public PublicDBDataContext(string connection) : base(connection, mappingSource)
        {
        }

        public PublicDBDataContext(IDbConnection connection, MappingSource mappingSource) : base(connection, mappingSource)
        {
        }

        public PublicDBDataContext(string connection, MappingSource mappingSource) : base(connection, mappingSource)
        {
        }

        public Table<TBL_QUESTDROP> TBL_QUESTDROPs
        {
            get
            {
                return base.GetTable<TBL_QUESTDROP>();
            }
        }
    }
}

