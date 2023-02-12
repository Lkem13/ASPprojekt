namespace ASPprojekt.Areas.Identity.Data
{
    public class SelectPositionModel
    {
        public Int32 Position { get; set; }
        public IEnumerable<PositionModel> Positions { get; set; }
    }
}
