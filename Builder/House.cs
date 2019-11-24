namespace Builder
{
    public class House:IHousePlan
    {
        public string _basement;
        public string _structure;
        public string _roof;
        public string _interior;
        public void SetBasement(string basement)
        {
            this._basement = basement;
        }

        public void SetStructure(string structure)
        {
            this._structure = structure;
        }

        public void SetRoof(string roof)
        {
            this._roof = roof;
        }

        public void SetInterior(string interior)
        {
            this._interior = interior;
        }
    }
}
