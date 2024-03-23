namespace Mission11.Models.ViewModels
{
    public class PaginationInfo
    {
        public int TotalNumItems { get; set; }
        public int PageNum { get; set; } = 0;
        public int ItemsPerPage { get; set; }
        public int TotalNumPages => (int) (Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));
    }
}
