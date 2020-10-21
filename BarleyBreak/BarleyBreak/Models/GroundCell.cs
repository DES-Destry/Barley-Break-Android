namespace BarleyBreak.Models
{
    class GroundCell
    {
        public int Place { get; set; }
        public string Value { get; set; }
        public Variants Variants { get; set; }

        public GroundCell(int place, string value, bool top, bool left, bool right, bool bottom)
        {
            this.Place = place;
            this.Value = value;
            Variants = new Variants(top, left, right, bottom);
        }

        public GroundCell(int place, string value, Variants variants)
        {
            this.Place = place;
            this.Value = value;
            this.Variants = variants;
        }
    }
}
