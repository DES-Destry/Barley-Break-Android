namespace BarleyBreak.Models
{
    class GroundCell
    {
        public int Place { get; set; }
        public string Value { get; set; }
        public Variants Variants { get; set; }

        public GroundCell(int place, string value)
        {
            this.Place = place;
            this.Value = value;
            Variants = new Variants(false, false, false, false);
        }

        public GroundCell(int place, string value, Variants variants)
        {
            this.Place = place;
            this.Value = value;
            this.Variants = variants; 
        }

        public GroundCell CanMoveUp()
        {
            this.Variants.HaveTopAction = true;
            return this;
        }

        public GroundCell CanMoveLeft()
        {
            this.Variants.HaveLeftAction = true;
            return this;
        }

        public GroundCell CanMoveRight()
        {
            this.Variants.HaveRightAction = true;
            return this;
        }

        public GroundCell CanMoveDown()
        {
            this.Variants.HaveBottomAction = true;
            return this;
        }
    }
}
