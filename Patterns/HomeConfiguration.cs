/*
MSSV: 202418832
Họ tên: Bùi Ngọc Trâm Anh
*/

namespace labw10.Patterns
{
    public sealed class HomeConfiguration
    {
        private static readonly Lazy<HomeConfiguration> _lazy =
            new(() => new HomeConfiguration());

        public static HomeConfiguration Instance => _lazy.Value;

        public string HomeName { get; set; } = "My Home";
        public int NightLightLevel { get; set; } = 30;

        private HomeConfiguration()
        {
        }
    }
}
