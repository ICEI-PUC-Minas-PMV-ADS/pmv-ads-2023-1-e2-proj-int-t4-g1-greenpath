using System;
namespace GreenPath.ViewModels
{
    public class HomeViewModel
    {
        //public IEnumerable<Vagas>? Vagas { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public HomeUserCreateViewModel Register { get; set; } = new HomeUserCreateViewModel();
    }
}

