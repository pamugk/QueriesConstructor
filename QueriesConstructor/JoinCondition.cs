namespace QueryConstructor
{
    internal class JoinCondition
    {
        public FKInfo Info { get; }

        public JoinCondition(FKInfo info)
        {
            Info = info;
        }

        public override bool Equals(object obj)
        {
            return obj is JoinCondition && ((JoinCondition) obj).Info.Equals(Info);
        }

        public override string ToString()
        {
            return $"[{Info.PKeyTable}].[{Info.PKey}] = [{Info.FTable}].[{Info.FKey}]";
        }
    }
}