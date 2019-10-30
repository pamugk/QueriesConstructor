namespace QueryConstructor
{
    internal class LogicOperation
    {
        public string RealName { get; }
        public string VisibleName { get; }

        public LogicOperation(string realName, string visibleName)
        {
            RealName = realName;
            VisibleName = visibleName;
        }

        public override string ToString()
        {
            return VisibleName;
        }
    }
}