namespace QueryConstructor
{
    internal struct FKInfo
    {
        public string FKey { get; }
        public string FTable { get; }

        public string PKey { get; }
        public string PKeyTable { get; }

        public FKInfo(string fKey, string fTable, string pKey, string pKeyTable)
        {
            FKey = fKey;
            FTable = fTable;
            PKey = pKey;
            PKeyTable = pKeyTable;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is FKInfo))
                return false;
            var temp = (FKInfo)obj;
            return temp.PKeyTable == PKeyTable &&
                   temp.PKey == PKey &&
                   temp.FTable == FTable &&
                   temp.FKey == FKey ||
                        temp.FTable == PKeyTable &&
                        temp.FKey == PKey &&
                        temp.PKeyTable == FTable &&
                        temp.PKey == FKey;
        }
    }
}