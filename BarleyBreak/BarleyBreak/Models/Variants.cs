namespace BarleyBreak.Models
{
    class Variants
    {
        public bool HaveTopAction { get; set; }
        public bool HaveLeftAction { get; set; }
        public bool HaveRightAction { get; set; }
        public bool HaveBottomAction { get; set; }

        public Variants(bool top, bool left, bool right, bool bottom)
        {
            this.HaveTopAction = top;
            this.HaveLeftAction = left;
            this.HaveRightAction = right;
            this.HaveBottomAction = bottom;
        }
    }
}
