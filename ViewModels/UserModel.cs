namespace ApiSalao.ViewModels
{
    public record UserModel{

        public string? email { get; set; }
        public string? name { get; set; }
        public string? password { get; set; }
        public int? Phone { get; set; }
    } 
}