namespace Logic.Core
{
    public interface IProtossUnit
    {
        void Attack(Unit unit);
        void Attack(ZergUnit zerg);
        void Attack(ProtossUnit protoss);
        void Attack(TerranUnit terran);
        int Shield { get; set; }
        int MaxShield { get; set; }
        void RegenerateShield();
    }
}